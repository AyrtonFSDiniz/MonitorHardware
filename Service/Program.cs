using System;
using System.Diagnostics;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
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

            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            PerformanceCounter diskPhysicalCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            PerformanceCounter diskLogicalCounter = new PerformanceCounter("LogicalDisk", "% Disk Time", "_Total");
            //PerformanceCounter cpuTempCounter = new PerformanceCounter("Thermal Zone Information", "Temperature", "CPU");
            //PerformanceCounter gpuTempCounter = new PerformanceCounter("Thermal Zone Information", "Temperature", "GPU");

            while (true)
            {
                Console.WriteLine("CPU: " + cpuCounter.NextValue() + "%");
                Console.WriteLine("RAM: " + ramCounter.NextValue() + "MB");
                Console.WriteLine("Disk (Physical): " + diskPhysicalCounter.NextValue() + "%");
                Console.WriteLine("Disk (Logical): " + diskLogicalCounter.NextValue() + "%");
                //Console.WriteLine("CPU Temperature: " + cpuTempCounter.NextValue() + "°C");
                //Console.WriteLine("GPU Temperature: " + gpuTempCounter.NextValue() + "°C");
                Console.WriteLine();
                System.Threading.Thread.Sleep(3000);
            }
        }

        private string ObtainProcessName()
    {
        string baseProcessName;
        string processName = null;
        int processId;
        bool notFound = true;
        int processOptionsChecked = 0;
        int maxNrOfParallelProcesses = 3 + 1;

        try
        {
            baseProcessName = Process.GetCurrentProcess().ProcessName;
        }
        catch (Exception exception)
        {
            return null;
        }

        try
        {
            processId = Process.GetCurrentProcess().Id;
        }
        catch (Exception exception)
        {
            return null;
        }

        while (notFound)
        {
            processName = baseProcessName;
            if (processOptionsChecked > maxNrOfParallelProcesses)
            {
                break;
            }

            if (1 == processOptionsChecked)
            {
                processName = string.Format("{0}_{1}", baseProcessName, processId);
            }
            else if (processOptionsChecked > 1)
            {
                processName = string.Format("{0}#{1}", baseProcessName, processOptionsChecked - 1);
            }

            try
            {
                PerformanceCounter counter = new PerformanceCounter("Process", "ID Process", processName);
                if (processId == (int)counter.NextValue())
                {
                    notFound = !true;
                }
            }
            catch (Exception)
            {
            }
            processOptionsChecked++;
        }
        return processName;
    }
    }
}