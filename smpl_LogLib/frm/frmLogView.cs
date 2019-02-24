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
using System.IO;
using System.Windows.Forms;
using static akil_LogLib.vars;

namespace akil_LogLib.frm
{
    public partial class frmLogView : Form
    {
        Timer _tick = new Timer();
        public frmLogView()
        {
            InitializeComponent();
            _tick.Tick += _tick_tock;
            _tick.Interval = 250; // 4 times/sec
        }

        private void _tick_tock(object sender, EventArgs e)
        {
            if (Directory.GetFiles(LogDirectory, "*.log").Length != c_FileList.Items.Count)
            {
                UpdList();
            }
        }

        private void UpdList()
        {
            try
            {
                c_FileList.Items.Clear();
                foreach (var file in Directory.GetFiles(LogDirectory, "*.log"))
                {
                    c_FileList.Items.Add(file.Replace($"{LogDirectory}\\", string.Empty));
                }
                if (c_FileList.Items.Count > 0)
                {
                    c_FileList.Items[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
            }
        }

        private void frmLogView_Load(object sender, EventArgs e)
        {
            UpdList();
            _tick.Start();
        }

        private void c_FileList_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                c_FileContent.Text = File.ReadAllText(Path.Combine(LogDirectory, c_FileList.Items[c_FileList.SelectedIndices[0]].Text));
            }
            catch(Exception ex) {
                _throwed_exceptions.Insert(_updCount(), ex);
            }
        }

        private void c_FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // buggy, but it's for debug only...
                if (c_FileList.SelectedItems.Count > 0)
                {
                    // look at that... not buggy anymore :)
                    c_filesize.Text = $"{new FileInfo(Path.Combine(LogDirectory, c_FileList.Items[c_FileList.SelectedIndices[0]].Text)).Length} bytes";
                }
            }
            catch (Exception ex)
            {
                _throwed_exceptions.Insert(_updCount(), ex);
            }
        }
    }
}
