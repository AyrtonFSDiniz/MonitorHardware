using OpenHardwareMonitor.Hardware;
using System.Management;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.RAMEnabled = true;
            computer.HDDEnabled = true;
            computer.MainboardEnabled = true;
            computer.FanControllerEnabled = true;

            int interval = 3000;
            Console.WriteLine("##### Monitor de Hardware #####");
            Console.WriteLine();
            Console.WriteLine("Qual o tempo de atualização de dados que você deseja?");
            // verificar se o valor recebido é um numero, se não for avisar o usuário de que o valor padrão será utilizado
            try
            {
                interval = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Valor inválido, o valor padrão será utilizado.");
            }

            while (true)
            {
                foreach (var hardware in computer.Hardware)
                {
                    hardware.Update();
                    Console.WriteLine("Hardware: " + hardware.Name);
                    Console.WriteLine("Hardware Type: " + hardware.HardwareType);

                    foreach (var sensor in hardware.Sensors)
                    {
                        Console.WriteLine("-> Sensor: " + sensor.Name + " Valor: " + sensor.Value);
                    }
                    Console.WriteLine();
                }
                System.Threading.Thread.Sleep(interval);
            }
        }
    }
}