/***
 *     ▄▄▄       ██ ▄█▀ ██▓ ██▓
 *    ▒████▄     ██▄█▒ ▓██▒▓██▒
 *    ▒██  ▀█▄  ▓███▄░ ▒██▒▒██░
 *    ░██▄▄▄▄██ ▓██ █▄ ░██░▒██░
 *     ▓█   ▓██▒▒██▒ █▄░██░░██████▒
 *     ▒▒   ▓▒█░▒ ▒▒ ▓▒░▓  ░ ▒░▓  ░
 *      ▒   ▒▒ ░░ ░▒ ▒░ ▒ ░░ ░ ▒  ░
 *      ░   ▒   ░ ░░ ░  ▒ ░  ░ ░
 *          ░  ░░  ░    ░      ░  ░
 *
 *     my simple log library
 *     For code updates visit repository on https://github.com/sutaj
 */
using System;
using System.Management;
using static akil_LogLib.vars;

namespace akil_LogLib
{
    /// <summary>
    /// Some hardware information gathering
    /// </summary>
    internal static class HardwareInfo
    {
        internal static string GetPhysicalMemory()
        {
            try
            {
                ManagementScope oMs = new ManagementScope();
                ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
                ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
                ManagementObjectCollection oCollection = oSearcher.Get();

                long MemSize = 0;
                long mCap = 0;

                foreach (ManagementObject obj in oCollection)
                {
                    mCap = Convert.ToInt64(obj["Capacity"]);
                    MemSize += mCap;
                }
                MemSize = (MemSize / 1024) / 1024;
                return MemSize.ToString() + "MB";
            }
            catch (Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
                return string.Empty;
            }
        }

        internal static string GetNoRamSlots()
        {
            try
            {
                int MemSlots = 0;
                ManagementScope oMs = new ManagementScope();
                ObjectQuery oQuery2 = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
                ManagementObjectSearcher oSearcher2 = new ManagementObjectSearcher(oMs, oQuery2);
                ManagementObjectCollection oCollection2 = oSearcher2.Get();
                foreach (ManagementObject obj in oCollection2)
                {
                    MemSlots = Convert.ToInt32(obj["MemoryDevices"]);
                }
                return MemSlots.ToString();
            }catch(Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
                return string.Empty;
            }
        }

        internal static string GetCPUManufacturer()
        {
            try
            {
                string cpuMan = String.Empty;
                ManagementClass mgmt = new ManagementClass("Win32_Processor");
                ManagementObjectCollection objCol = mgmt.GetInstances();

                foreach (ManagementObject obj in objCol)
                {
                    if (cpuMan == String.Empty)
                    {
                        cpuMan = obj.Properties["Manufacturer"].Value.ToString();
                    }
                }
                return cpuMan;
            }catch(Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
                return string.Empty;
            }
        }

        internal static int GetCPUCurrentClockSpeed()
        {
            try
            {
                int cpuClockSpeed = 0;
                ManagementClass mgmt = new ManagementClass("Win32_Processor");
                ManagementObjectCollection objCol = mgmt.GetInstances();

                foreach (ManagementObject obj in objCol)
                {
                    if (cpuClockSpeed == 0)
                    {
                        cpuClockSpeed = Convert.ToInt32(obj.Properties["CurrentClockSpeed"].Value.ToString());
                    }
                }
                return cpuClockSpeed;
            }catch (Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
                return -1;
            }
        }

        public static double? GetCpuSpeedInGHz()
        {
            try
            {
                double? GHz = null;
                using (ManagementClass mc = new ManagementClass("Win32_Processor"))
                {
                    foreach (ManagementObject mo in mc.GetInstances())
                    {
                        GHz = 0.001 * (UInt32)mo.Properties["CurrentClockSpeed"].Value;
                        break;
                    }
                }
                return GHz;
            }catch(Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
                return -1;
            }
        }

        public static string GetOSInformation()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return ((string)wmi["Caption"]).Trim() + ", " + (string)wmi["Version"] + ", " + (string)wmi["OSArchitecture"];
                }
                catch (Exception ex)
                {
                    _throwed_exceptions.Insert(_updCount(), ex);
                }
            }
            return "[unknown]";
        }

        public static String GetProcessorInformation()
        {
            try
            {
                ManagementClass mc = new ManagementClass("win32_processor");
                ManagementObjectCollection moc = mc.GetInstances();
                String info = String.Empty;
                foreach (ManagementObject mo in moc)
                {
                    string name = (string)mo["Name"];
                    name = name.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®").Replace("(r)", "®").Replace("(C)", "©").Replace("(c)", "©").Replace("    ", " ").Replace("  ", " ");

                    info = name + ", " + (string)mo["Caption"] + ", " + (string)mo["SocketDesignation"];
                }
                return info;
            }catch(Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
                return string.Empty;
            }
        }

        public static String GetComputerName()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
                ManagementObjectCollection moc = mc.GetInstances();
                String info = String.Empty;
                foreach (ManagementObject mo in moc)
                {
                    info = (string)mo["Name"];
                }
                return info;
            }catch (Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
                return string.Empty;
            }
        }

    }
}
