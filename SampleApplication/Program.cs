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
using System.Windows.Forms;
using static akil_LogLib.vars;

namespace SampleApplication
{
    static internal class Program
    {
        internal static Timer _tick = new Timer();
        static int _tmpCount = _throwed_exceptions.Count;

        [STAThread]
        static void Main(string[] args)
        {
            _tick.Tick += _tick_tock;
            _tick.Interval = 200; // 5 times per second

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm.frmMain());
        }

        private static void _tick_tock(object sender, EventArgs e)
        {
            if (_tmpCount != _throwed_exceptions.Count)
            {
                Console.WriteLine($"{TimeStamp}\t -\t {_throwed_exceptions[_throwed_exceptions.Count-1].Message}");
                _tmpCount = _throwed_exceptions.Count;
            }
        }
    }
}
