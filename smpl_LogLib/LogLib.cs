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

 // change syntax to compile this for .NET Core...

using System;
using System.IO;
using static akil_LogLib.vars;

namespace akil_LogLib
{
    public static class LogLib
    {
        private static string _logFile = string.Empty;

        public static string logFile { get => _logFile; set => _logFile = value; }

        /// <summary>
        /// Delete old log files...
        /// </summary>
        /// <param name="DaysToDelete">Days to delete files. [30 = delete files older than 30 days.]</param>
        public static void AutoCleanUp(int DaysToDelete)
        {
            int i = 0;
            foreach (var item in Directory.GetFiles(LogDirectory))
            {
                if (new FileInfo(item).CreationTime.AddDays((double)DaysToDelete) < DateTime.Now)
                {
                    // file is older, delete.
                    File.Delete(item);
                    i++;
                }
            }
        }

        /// <summary>
        /// Create new log file with header.
        /// </summary>
        /// <returns>true if all OK</returns>
        public static bool NewFile()
        {
            bool isOK = false;
            string _info_username, _info_machinemae, _info_osinfo,
                   _info_cpuinfo, _info_memory,
                   sep = LogSep;
            double? _info_cpuspeed;
            DateTime _dt = DateTime.Now;

            try
            {
                if (!Directory.Exists(LogDirectory))
                {
                    Directory.CreateDirectory(LogDirectory);
                }

                _info_username = Environment.UserName;
                _info_machinemae = Environment.MachineName;
                _info_osinfo = HardwareInfo.GetOSInformation();
                _info_cpuinfo = HardwareInfo.GetProcessorInformation();
                _info_cpuspeed = HardwareInfo.GetCpuSpeedInGHz();
                _info_memory = HardwareInfo.GetPhysicalMemory();
                _logFile = $"log-{_dt.Year}{_dt.Month:00}{_dt.Day:00}{_dt.Hour:00}{_dt.Minute:00}{_dt.Second:00}.log";

                string _LogMsg = $"{LogSep}{_n}\t{TimeStamp} » Starting new log file...{_n}\tBasic system information:{_n}" +
                    $"System:{_info_osinfo}{_n}\tUser account name: {_info_username}{_n}{_n}" +
                    $"\tCPU: {_info_cpuinfo} @ {_info_cpuspeed} Ghz{_n}{_n}\tMemory: {_info_memory}{_n}{LogSep}{_n}";

                using (FileStream fs = new FileStream(Path.Combine(LogDirectory, _logFile), FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(_LogMsg);
                    sw.Close();
                }
                isOK = true;
            }
            catch (Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
                isOK = false;
            }
            return isOK;
        }

        /// <summary>
        /// Add new entry to log file.
        /// </summary>
        /// <param name="msg">Log message</param>
        /// <param name="new_line">add new line [default - false]</param>
        /// <returns>true if entry added</returns>
        public static bool Add(string msg, bool new_line = false)
        {
            bool isOK = false;
            string nL = null;

            if (new_line)
            {
                nL = _n;
            }
            else
            {
                nL = null;
            }
            try
            {
                if (_logFile == string.Empty)
                {
                    NewFile();
                }
                string LogMSG = $"{nL}{TimeStamp} - {msg}";
                using (FileStream fs = new FileStream($"{LogDirectory}\\{_logFile}", FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(LogMSG);
                    sw.Close();
                }
                isOK = true;
            }
            catch (Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
                isOK = false;
            }
            return isOK;
        }

        #region small stuff
        public static void setTimestampType(timeStampType type)
        {
            TimeStampType = type;
        }
        #endregion
    }
}
