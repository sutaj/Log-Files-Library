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
 *     my simple log library - test/sample project
 *     For code updates visit repository on https://github.com/sutaj
 */
using System;
using System.IO;
using System.Windows.Forms;
using static akil_LogLib.vars;
using static akil_LogLib.xDebug;
using static akil_LogLib.LogLib;

namespace SampleApplication.frm
{
    public partial class frmMain : Form
    {
        Timer _tick = new Timer();
        long _tmp_lenght = 0, _l;

        public frmMain()
        {
            InitializeComponent();
            _tick.Tick += _tick_tock;
            _tick.Interval = 250;
            //vars.LogDirectory = "data";
        }

        private void _tick_tock(object sender, EventArgs e)
        {
            if(logFile != null)
            {
                if (File.Exists(Path.Combine(LogDirectory, logFile)))
                {
                    _l = new FileInfo(Path.Combine(LogDirectory, logFile)).Length;
                    c_FileSize.Text = $"Log file size: { _l / 1024} kb.";
                    c_LogFileName.Text = $"Log filename: {logFile}";
                    if (_l != _tmp_lenght)
                    {
                        c_LogContent.Clear();
                        c_LogContent.Text = File.ReadAllText(Path.Combine(LogDirectory, logFile));
                        c_LogContent.Select(c_LogContent.Text.Length-1, c_LogContent.Text.Length);
                        c_LogContent.ScrollToCaret();
                        _l = _tmp_lenght;
                    }
                }
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Program._tick.Start();
            _tick.Start();
            Console.WriteLine($"Main form loaded at {TimeStampClean}.");
        }

        private void c_showLogs_Click(object sender, EventArgs e)
        {
            if(LogViewShow() == true)
            {
                Console.WriteLine($"{TimeStamp}\t -\t Log view window oppened.");
            }
            else
            {
                Console.WriteLine($"{TimeStamp}\t -\t Unable to open log view window.");
            }
        }

        private void c_NewLogFile_Click(object sender, EventArgs e)
        {
            if (NewFile())
            {
                c_LogFileName.Text = $"Log filename: {logFile}";
                Console.WriteLine($"{TimeStamp}\t -\t New log file {Path.Combine(LogDirectory, logFile)} created.");
            }
            else
            {
                Console.WriteLine($"{TimeStamp}\t -\t Unable to create new log file. Check throwed exception.");
            }
        }

        private void c_customTS_CheckedChanged(object sender, EventArgs e)
        {
            if (c_customTS.Checked)
            {
                CustomTimeStamp = c_customTimestamp.Text;
                TimeStampType = timeStampType.Custom;
            }
            else
            {
                TimeStampType = timeStampType.Square_Bracket;
            }
        }

        private void c_NewEntry_Click(object sender, EventArgs e)
        {
            if(logFile == string.Empty)
            {
                Console.WriteLine($"{TimeStamp}\t -\t New log file in {Path.Combine(LogDirectory, logFile)}.");
            }
            if(Add($"New test log entry. Some random number {new Random(DateTime.Now.Minute*DateTime.Now.Millisecond).Next(1000, 99999)}..."))
            {
                Console.WriteLine($"{TimeStamp}\t -\t New entry in log file. Filesize {new FileInfo(Path.Combine(LogDirectory, logFile)).Length}b.");
            }
            else
            {
                Console.WriteLine($"{TimeStamp}\t -\t Unable to add entry into log file.");
            }
        }
    }
}
