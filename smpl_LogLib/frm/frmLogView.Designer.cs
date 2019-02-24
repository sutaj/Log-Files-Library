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
namespace akil_LogLib.frm
{
    partial class frmLogView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.c_filesize = new System.Windows.Forms.ToolStripStatusLabel();
            this.c_FileContent = new System.Windows.Forms.TextBox();
            this.c_FileList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.c_FileList);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c_FileContent);
            this.splitContainer1.Size = new System.Drawing.Size(923, 390);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_filesize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 173);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(923, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // c_filesize
            // 
            this.c_filesize.Name = "c_filesize";
            this.c_filesize.Size = new System.Drawing.Size(27, 17);
            this.c_filesize.Text = "null";
            // 
            // c_FileContent
            // 
            this.c_FileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_FileContent.Location = new System.Drawing.Point(0, 0);
            this.c_FileContent.Multiline = true;
            this.c_FileContent.Name = "c_FileContent";
            this.c_FileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.c_FileContent.Size = new System.Drawing.Size(923, 191);
            this.c_FileContent.TabIndex = 0;
            // 
            // c_FileList
            // 
            this.c_FileList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.c_FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_FileList.GridLines = true;
            this.c_FileList.Location = new System.Drawing.Point(0, 0);
            this.c_FileList.MultiSelect = false;
            this.c_FileList.Name = "c_FileList";
            this.c_FileList.Size = new System.Drawing.Size(923, 173);
            this.c_FileList.TabIndex = 1;
            this.c_FileList.UseCompatibleStateImageBehavior = false;
            this.c_FileList.View = System.Windows.Forms.View.List;
            this.c_FileList.ItemActivate += new System.EventHandler(this.c_FileList_ItemActivate);
            this.c_FileList.SelectedIndexChanged += new System.EventHandler(this.c_FileList_SelectedIndexChanged);
            // 
            // frmLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 390);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmLogView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Log Viewer";
            this.Load += new System.EventHandler(this.frmLogView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel c_filesize;
        private System.Windows.Forms.TextBox c_FileContent;
        private System.Windows.Forms.ListView c_FileList;
    }
}