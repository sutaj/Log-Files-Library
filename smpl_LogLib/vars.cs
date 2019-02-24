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
using System.Collections.Generic;

namespace akil_LogLib
{
    public static class vars
    {
        private static DateTime _dt;
        private static timeStampType _timeStampType = timeStampType.Square_Bracket;
        private static string logDirectory = Environment.CurrentDirectory;
        private static string customTimeStamp = string.Empty;

        public static string TimeStamp { get => _getts(); }
        public static string TimeStampClean { get => _getts(true); }
        /// <summary>
        /// System specific new line. Instead "\r\n" for Windows, "\n" for Linux etc...
        /// </summary>
        internal static string _n = Environment.NewLine;

        // for more complex exceptions tracking.
        /// <summary>
        /// Exceptions throwed by library
        /// </summary>
        public static List<Exception> _throwed_exceptions = new List<Exception>(512);
        /// <summary>
        /// Display style of returned timestamp
        /// </summary>
        public static timeStampType TimeStampType { get => _timeStampType; set => _timeStampType = value; }
        /// <summary>
        /// Directory to store log files
        /// </summary>
        public static string LogDirectory { get => logDirectory; set => logDirectory = value; }
        /// <summary>
        /// Log separator
        /// </summary>
        public static string LogSep { get { return "-------------------------------------------------------------------------"; } }
        /// <summary>
        /// Custom timestamp %Y% for year, %M% for month, %D% for day, %h% - hour, %m% - minute, %s% - second
        /// </summary>
        public static string CustomTimeStamp { get => customTimeStamp; set => customTimeStamp = value; }

        private static string _getts(bool clean = false)
        {
            _dt = DateTime.Now;  // update DateTime
            string _ret = string.Empty;

            if (!clean)
            {
                switch (_timeStampType)
                {
                    case timeStampType.Bracket:
                        _ret = $"({_dt.Year}-{_dt.Month:00}-{_dt.Day:00} {_dt.Hour:00}:{_dt.Minute:00}.{_dt.Second:00})";
                        break;
                    case timeStampType.Square_Bracket:
                        _ret = $"[{_dt.Year}-{_dt.Month:00}-{_dt.Day:00} {_dt.Hour:00}:{_dt.Minute:00}.{_dt.Second:00}]";
                        break;
                    case timeStampType.Tabulation:
                        _ret = $"\t{_dt.Year}-{_dt.Month:00}-{_dt.Day:00} {_dt.Hour:00}:{_dt.Minute:00}.{_dt.Second:00}\t";
                        break;
                    case timeStampType.Colon:
                        _ret = $":{_dt.Year}-{_dt.Month:00}-{_dt.Day:00} {_dt.Hour:00}:{_dt.Minute:00}.{_dt.Second:00}:";
                        break;
                    case timeStampType.Space:
                        _ret = $" {_dt.Year}-{_dt.Month:00}-{_dt.Day:00} {_dt.Hour:00}:{_dt.Minute:00}.{_dt.Second:00} ";
                        break;
                    case timeStampType.clean:
                        _ret = $"{_dt.Year}-{_dt.Month:00}-{_dt.Day:00} {_dt.Hour:00}:{_dt.Minute:00}.{_dt.Second:00}";
                        break;
                    case timeStampType.Custom:
                        // faster is regex or string replacing? I'm not trusting in regex in any language... string raplace then!
                        if (customTimeStamp == string.Empty) // custom timestamp is not set. use default
                        {
                            _ret = $"[{_dt.Year}-{_dt.Month:00}-{_dt.Day:00} {_dt.Hour:00}:{_dt.Minute:00}.{_dt.Second:00}]";
                        }
                        else
                        {
                            _ret = customTimeStamp
                                .Replace("%Y%", $"{_dt.Year}")
                                .Replace("%M%", $"{_dt.Month:00}")
                                .Replace("%D%", $"{_dt.Day:00}")
                                .Replace("%h%", $"{_dt.Hour:00}")
                                .Replace("%m%", $"{_dt.Minute:00}")
                                .Replace("%s%", $"{_dt.Second:00}");
                        }
                        break;
                    default:
                        _ret = $"[{_dt.Year}-{_dt.Month:00}-{_dt.Day:00} {_dt.Hour:00}:{_dt.Minute:00}.{_dt.Second:00}]";
                        break;
                }
            }
            else
            {
                _ret = $"{_dt.Year}-{_dt.Month:00}-{_dt.Day:00} {_dt.Hour:00}:{_dt.Minute:00}.{_dt.Second:00}";
            }
            return _ret;
        }

        internal static int _updCount()
        {
            return _throwed_exceptions.Count;
        }

        #region Enums
        public enum exceptions
        {
            GLOBAL,
            MainLib,
            LogView,
            System,
            IO,
            unknown
        }
        public enum timeStampType
        {
            Bracket,
            Square_Bracket,
            Tabulation,
            Colon,
            Space,
            Custom,
            clean
        }
        #endregion

    }
}
