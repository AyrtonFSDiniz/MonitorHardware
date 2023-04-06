using OpenHardwareMonitor.Hardware;
using System.Management;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var processComputer = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            var processComputerCollection = processComputer.Get();
            Dictionary<string, string> processComputerDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerCollection)
            {
                var processComputerObject = (ManagementObject)item;
                processComputerDictionary.Add("Name", processComputerObject["Name"].ToString());
                processComputerDictionary.Add("NumberOfCores", processComputerObject["NumberOfCores"].ToString());
                processComputerDictionary.Add("NumberOfLogicalProcessors", processComputerObject["NumberOfLogicalProcessors"].ToString());
                processComputerDictionary.Add("MaxClockSpeed", processComputerObject["MaxClockSpeed"].ToString());
                processComputerDictionary.Add("CurrentClockSpeed", processComputerObject["CurrentClockSpeed"].ToString());
                processComputerDictionary.Add("L2CacheSize", processComputerObject["L2CacheSize"].ToString());
                processComputerDictionary.Add("L3CacheSize", processComputerObject["L3CacheSize"].ToString());
            }

            var processComputerSystem = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            var processComputerSystemCollection = processComputerSystem.Get();
            Dictionary<string, string> processComputerSystemDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemCollection)
            {
                var processComputerSystemObject = (ManagementObject)item;
                processComputerSystemDictionary.Add("Manufacturer", processComputerSystemObject["Manufacturer"].ToString());
                processComputerSystemDictionary.Add("Model", processComputerSystemObject["Model"].ToString());
                processComputerSystemDictionary.Add("TotalPhysicalMemory", processComputerSystemObject["TotalPhysicalMemory"].ToString());
            }

            var processComputerSystemProduct = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystemProduct");
            var processComputerSystemProductCollection = processComputerSystemProduct.Get();
            Dictionary<string, string> processComputerSystemProductDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemProductCollection)
            {
                var processComputerSystemProductObject = (ManagementObject)item;
                processComputerSystemProductDictionary.Add("UUID", processComputerSystemProductObject["UUID"].ToString());
            }

            var processComputerSystemOS = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            var processComputerSystemOSCollection = processComputerSystemOS.Get();
            Dictionary<string, string> processComputerSystemOSDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemOSCollection)
            {
                var processComputerSystemOSObject = (ManagementObject)item;
                processComputerSystemOSDictionary.Add("Caption", processComputerSystemOSObject["Caption"].ToString());
                processComputerSystemOSDictionary.Add("OSArchitecture", processComputerSystemOSObject["OSArchitecture"].ToString());
                processComputerSystemOSDictionary.Add("Version", processComputerSystemOSObject["Version"].ToString());
                processComputerSystemOSDictionary.Add("BuildNumber", processComputerSystemOSObject["BuildNumber"].ToString());
                processComputerSystemOSDictionary.Add("SerialNumber", processComputerSystemOSObject["SerialNumber"].ToString());
                processComputerSystemOSDictionary.Add("InstallDate", processComputerSystemOSObject["InstallDate"].ToString());
            }

            var processComputerSystemBIOS = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            var processComputerSystemBIOSCollection = processComputerSystemBIOS.Get();
            Dictionary<string, string> processComputerSystemBIOSDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemBIOSCollection)
            {
                var processComputerSystemBIOSObject = (ManagementObject)item;
                processComputerSystemBIOSDictionary.Add("Manufacturer", processComputerSystemBIOSObject["Manufacturer"].ToString());
                processComputerSystemBIOSDictionary.Add("Name", processComputerSystemBIOSObject["Name"].ToString());
                processComputerSystemBIOSDictionary.Add("Version", processComputerSystemBIOSObject["Version"].ToString());
                processComputerSystemBIOSDictionary.Add("SerialNumber", processComputerSystemBIOSObject["SerialNumber"].ToString());
                processComputerSystemBIOSDictionary.Add("ReleaseDate", processComputerSystemBIOSObject["ReleaseDate"].ToString());
            }

            var processComputerSystemBaseBoard = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            var processComputerSystemBaseBoardCollection = processComputerSystemBaseBoard.Get();
            Dictionary<string, string> processComputerSystemBaseBoardDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemBaseBoardCollection)
            {
                var processComputerSystemBaseBoardObject = (ManagementObject)item;
                processComputerSystemBaseBoardDictionary.Add("Manufacturer", processComputerSystemBaseBoardObject["Manufacturer"].ToString());
                processComputerSystemBaseBoardDictionary.Add("Product", processComputerSystemBaseBoardObject["Product"].ToString());
                processComputerSystemBaseBoardDictionary.Add("Version", processComputerSystemBaseBoardObject["Version"].ToString());
                processComputerSystemBaseBoardDictionary.Add("SerialNumber", processComputerSystemBaseBoardObject["SerialNumber"].ToString());
            }

            var processComputerSystemDiskDrive = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            var processComputerSystemDiskDriveCollection = processComputerSystemDiskDrive.Get();
            Dictionary<string, string> processComputerSystemDiskDriveDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemDiskDriveCollection)
            {
                var processComputerSystemDiskDriveObject = (ManagementObject)item;
                processComputerSystemDiskDriveDictionary.Add("Model", processComputerSystemDiskDriveObject["Model"].ToString());
                processComputerSystemDiskDriveDictionary.Add("InterfaceType", processComputerSystemDiskDriveObject["InterfaceType"].ToString());
                processComputerSystemDiskDriveDictionary.Add("Size", processComputerSystemDiskDriveObject["Size"].ToString());
                processComputerSystemDiskDriveDictionary.Add("SerialNumber", processComputerSystemDiskDriveObject["SerialNumber"].ToString());
            }

            var processComputerSystemVideoController = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            var processComputerSystemVideoControllerCollection = processComputerSystemVideoController.Get();
            Dictionary<string, string> processComputerSystemVideoControllerDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemVideoControllerCollection)
            {
                var processComputerSystemVideoControllerObject = (ManagementObject)item;
                processComputerSystemVideoControllerDictionary.Add("Name", processComputerSystemVideoControllerObject["Name"].ToString());
                processComputerSystemVideoControllerDictionary.Add("VideoProcessor", processComputerSystemVideoControllerObject["VideoProcessor"].ToString());
                processComputerSystemVideoControllerDictionary.Add("AdapterRAM", processComputerSystemVideoControllerObject["AdapterRAM"].ToString());
                processComputerSystemVideoControllerDictionary.Add("DriverVersion", processComputerSystemVideoControllerObject["DriverVersion"].ToString());
            }

            var processComputerSystemNetworkAdapter = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
            var processComputerSystemNetworkAdapterCollection = processComputerSystemNetworkAdapter.Get();
            Dictionary<string, string> processComputerSystemNetworkAdapterDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemNetworkAdapterCollection)
            {
                var processComputerSystemNetworkAdapterObject = (ManagementObject)item;
                processComputerSystemNetworkAdapterDictionary.Add("Name", processComputerSystemNetworkAdapterObject["Name"].ToString());
                processComputerSystemNetworkAdapterDictionary.Add("MACAddress", processComputerSystemNetworkAdapterObject["MACAddress"].ToString());
                processComputerSystemNetworkAdapterDictionary.Add("Manufacturer", processComputerSystemNetworkAdapterObject["Manufacturer"].ToString());
                processComputerSystemNetworkAdapterDictionary.Add("NetConnectionID", processComputerSystemNetworkAdapterObject["NetConnectionID"].ToString());
                processComputerSystemNetworkAdapterDictionary.Add("NetConnectionStatus", processComputerSystemNetworkAdapterObject["NetConnectionStatus"].ToString());
            }

            var processComputerSystemSoundDevice = new ManagementObjectSearcher("SELECT * FROM Win32_SoundDevice");
            var processComputerSystemSoundDeviceCollection = processComputerSystemSoundDevice.Get();
            Dictionary<string, string> processComputerSystemSoundDeviceDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemSoundDeviceCollection)
            {
                var processComputerSystemSoundDeviceObject = (ManagementObject)item;
                processComputerSystemSoundDeviceDictionary.Add("Name", processComputerSystemSoundDeviceObject["Name"].ToString());
                processComputerSystemSoundDeviceDictionary.Add("Manufacturer", processComputerSystemSoundDeviceObject["Manufacturer"].ToString());
                processComputerSystemSoundDeviceDictionary.Add("DriverVersion", processComputerSystemSoundDeviceObject["DriverVersion"].ToString());
            }
            
            var processComputerSystemPrinter = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");
            var processComputerSystemPrinterCollection = processComputerSystemPrinter.Get();
            Dictionary<string, string> processComputerSystemPrinterDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemPrinterCollection)
            {
                var processComputerSystemPrinterObject = (ManagementObject)item;
                processComputerSystemPrinterDictionary.Add("Name", processComputerSystemPrinterObject["Name"].ToString());
                processComputerSystemPrinterDictionary.Add("DriverName", processComputerSystemPrinterObject["DriverName"].ToString());
                processComputerSystemPrinterDictionary.Add("PortName", processComputerSystemPrinterObject["PortName"].ToString());
                processComputerSystemPrinterDictionary.Add("Shared", processComputerSystemPrinterObject["Shared"].ToString());
            }

            var processComputerSystemKeyboard = new ManagementObjectSearcher("SELECT * FROM Win32_Keyboard");
            var processComputerSystemKeyboardCollection = processComputerSystemKeyboard.Get();
            Dictionary<string, string> processComputerSystemKeyboardDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemKeyboardCollection)
            {
                var processComputerSystemKeyboardObject = (ManagementObject)item;
                processComputerSystemKeyboardDictionary.Add("Name", processComputerSystemKeyboardObject["Name"].ToString());
                processComputerSystemKeyboardDictionary.Add("Description", processComputerSystemKeyboardObject["Description"].ToString());
                processComputerSystemKeyboardDictionary.Add("PNPDeviceID", processComputerSystemKeyboardObject["PNPDeviceID"].ToString());
            }

            var processComputerSystemMouse = new ManagementObjectSearcher("SELECT * FROM Win32_PointingDevice");
            var processComputerSystemMouseCollection = processComputerSystemMouse.Get();
            Dictionary<string, string> processComputerSystemMouseDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemMouseCollection)
            {
                var processComputerSystemMouseObject = (ManagementObject)item;
                processComputerSystemMouseDictionary.Add("Name", processComputerSystemMouseObject["Name"].ToString());
                processComputerSystemMouseDictionary.Add("Description", processComputerSystemMouseObject["Description"].ToString());
                processComputerSystemMouseDictionary.Add("PNPDeviceID", processComputerSystemMouseObject["PNPDeviceID"].ToString());
            }

            var processComputerSystemMonitor = new ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor");
            var processComputerSystemMonitorCollection = processComputerSystemMonitor.Get();
            Dictionary<string, string> processComputerSystemMonitorDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemMonitorCollection)
            {
                var processComputerSystemMonitorObject = (ManagementObject)item;
                processComputerSystemMonitorDictionary.Add("Name", processComputerSystemMonitorObject["Name"].ToString());
                processComputerSystemMonitorDictionary.Add("Description", processComputerSystemMonitorObject["Description"].ToString());
                processComputerSystemMonitorDictionary.Add("PNPDeviceID", processComputerSystemMonitorObject["PNPDeviceID"].ToString());
            }

            var processComputerSystemSystemEnclosure = new ManagementObjectSearcher("SELECT * FROM Win32_SystemEnclosure");
            var processComputerSystemSystemEnclosureCollection = processComputerSystemSystemEnclosure.Get();
            Dictionary<string, string> processComputerSystemSystemEnclosureDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemSystemEnclosureCollection)
            {
                var processComputerSystemSystemEnclosureObject = (ManagementObject)item;
                processComputerSystemSystemEnclosureDictionary.Add("Name", processComputerSystemSystemEnclosureObject["Name"].ToString());
                processComputerSystemSystemEnclosureDictionary.Add("Description", processComputerSystemSystemEnclosureObject["Description"].ToString());
                processComputerSystemSystemEnclosureDictionary.Add("PNPDeviceID", processComputerSystemSystemEnclosureObject["PNPDeviceID"].ToString());
            }

            var processComputerSystemProcessor = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            var processComputerSystemProcessorCollection = processComputerSystemProcessor.Get();
            Dictionary<string, string> processComputerSystemProcessorDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemProcessorCollection)
            {
                var processComputerSystemProcessorObject = (ManagementObject)item;
                processComputerSystemProcessorDictionary.Add("Name", processComputerSystemProcessorObject["Name"].ToString());
                processComputerSystemProcessorDictionary.Add("Description", processComputerSystemProcessorObject["Description"].ToString());
                processComputerSystemProcessorDictionary.Add("PNPDeviceID", processComputerSystemProcessorObject["PNPDeviceID"].ToString());
            }

            var processComputerSystemMemory = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            var processComputerSystemMemoryCollection = processComputerSystemMemory.Get();
            Dictionary<string, string> processComputerSystemMemoryDictionary = new Dictionary<string, string>();
            foreach (var item in processComputerSystemMemoryCollection)
            {
                var processComputerSystemMemoryObject = (ManagementObject)item;
                processComputerSystemMemoryDictionary.Add("Name", processComputerSystemMemoryObject["Name"].ToString());
                processComputerSystemMemoryDictionary.Add("Description", processComputerSystemMemoryObject["Description"].ToString());
                processComputerSystemMemoryDictionary.Add("PNPDeviceID", processComputerSystemMemoryObject["PNPDeviceID"].ToString());
            }
        }
    }
}