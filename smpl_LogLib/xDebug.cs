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
using System.Windows.Forms;
using static akil_LogLib.vars;

namespace akil_LogLib
{
    public static class xDebug
    {
        static Form LogView;

        public static bool LogViewShow()
        {
            bool _ret = false;
            try
            {
                LogView = new frm.frmLogView();
                LogView.Show();
                //_throwed_exceptions.Insert(_updCount(), new Exception("TEST"));
                _ret = true;
            }
            catch (Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
                //MessageBox.Show($"Error while spawning Log Viewer form.{_n}Ex: {_n}.{_n}Restart and try again.");
                _ret = false;
            }
            
            return _ret;
        }
    }
}
