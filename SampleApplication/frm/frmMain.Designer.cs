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
namespace SampleApplication.frm
{
    partial class frmMain
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
            this.c_NewLogFile = new System.Windows.Forms.Button();
            this.c_LogFileName = new System.Windows.Forms.Label();
            this.c_FileSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c_LogContent = new System.Windows.Forms.TextBox();
            this.c_NewEntry = new System.Windows.Forms.Button();
            this.c_showLogs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.c_customTimestamp = new System.Windows.Forms.TextBox();
            this.c_customTS = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // c_NewLogFile
            // 
            this.c_NewLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_NewLogFile.Location = new System.Drawing.Point(521, 12);
            this.c_NewLogFile.Name = "c_NewLogFile";
            this.c_NewLogFile.Size = new System.Drawing.Size(129, 142);
            this.c_NewLogFile.TabIndex = 0;
            this.c_NewLogFile.Text = "New\r\nLog file.";
            this.c_NewLogFile.UseVisualStyleBackColor = true;
            this.c_NewLogFile.Click += new System.EventHandler(this.c_NewLogFile_Click);
            // 
            // c_LogFileName
            // 
            this.c_LogFileName.AutoSize = true;
            this.c_LogFileName.Location = new System.Drawing.Point(13, 13);
            this.c_LogFileName.Name = "c_LogFileName";
            this.c_LogFileName.Size = new System.Drawing.Size(89, 13);
            this.c_LogFileName.TabIndex = 1;
            this.c_LogFileName.Text = "Log filename: null";
            // 
            // c_FileSize
            // 
            this.c_FileSize.AutoSize = true;
            this.c_FileSize.Location = new System.Drawing.Point(13, 33);
            this.c_FileSize.Name = "c_FileSize";
            this.c_FileSize.Size = new System.Drawing.Size(84, 13);
            this.c_FileSize.TabIndex = 2;
            this.c_FileSize.Text = "Log file size: null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log file content:";
            // 
            // c_LogContent
            // 
            this.c_LogContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_LogContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c_LogContent.Location = new System.Drawing.Point(16, 71);
            this.c_LogContent.Multiline = true;
            this.c_LogContent.Name = "c_LogContent";
            this.c_LogContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.c_LogContent.Size = new System.Drawing.Size(418, 83);
            this.c_LogContent.TabIndex = 3;
            // 
            // c_NewEntry
            // 
            this.c_NewEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_NewEntry.Location = new System.Drawing.Point(440, 12);
            this.c_NewEntry.Name = "c_NewEntry";
            this.c_NewEntry.Size = new System.Drawing.Size(75, 61);
            this.c_NewEntry.TabIndex = 5;
            this.c_NewEntry.Text = "New log\r\nentry";
            this.c_NewEntry.UseVisualStyleBackColor = true;
            this.c_NewEntry.Click += new System.EventHandler(this.c_NewEntry_Click);
            // 
            // c_showLogs
            // 
            this.c_showLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_showLogs.Location = new System.Drawing.Point(440, 79);
            this.c_showLogs.Name = "c_showLogs";
            this.c_showLogs.Size = new System.Drawing.Size(75, 75);
            this.c_showLogs.TabIndex = 6;
            this.c_showLogs.Text = "Show log\r\nbrowser";
            this.c_showLogs.UseVisualStyleBackColor = true;
            this.c_showLogs.Click += new System.EventHandler(this.c_showLogs_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Custom time stamp:\r\n%Y%-year, %M%-month, %D%-day, \r\n%h%-hour, %m%-minute, %s%-sec" +
    "ond";
            // 
            // c_customTimestamp
            // 
            this.c_customTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_customTimestamp.Location = new System.Drawing.Point(207, 170);
            this.c_customTimestamp.Name = "c_customTimestamp";
            this.c_customTimestamp.Size = new System.Drawing.Size(308, 20);
            this.c_customTimestamp.TabIndex = 8;
            this.c_customTimestamp.Text = "-=: %Y%.%M%.%D% -- %h%.%m%.%s% :=-";
            // 
            // c_customTS
            // 
            this.c_customTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_customTS.AutoSize = true;
            this.c_customTS.Location = new System.Drawing.Point(521, 173);
            this.c_customTS.Name = "c_customTS";
            this.c_customTS.Size = new System.Drawing.Size(142, 17);
            this.c_customTS.TabIndex = 9;
            this.c_customTS.Text = "custom timestamp on/off";
            this.c_customTS.UseVisualStyleBackColor = true;
            this.c_customTS.CheckedChanged += new System.EventHandler(this.c_customTS_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 203);
            this.Controls.Add(this.c_customTS);
            this.Controls.Add(this.c_customTimestamp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_showLogs);
            this.Controls.Add(this.c_NewEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_LogContent);
            this.Controls.Add(this.c_FileSize);
            this.Controls.Add(this.c_LogFileName);
            this.Controls.Add(this.c_NewLogFile);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lib Testing";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button c_NewLogFile;
        private System.Windows.Forms.Label c_LogFileName;
        private System.Windows.Forms.Label c_FileSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_LogContent;
        private System.Windows.Forms.Button c_NewEntry;
        private System.Windows.Forms.Button c_showLogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_customTimestamp;
        private System.Windows.Forms.CheckBox c_customTS;
    }
}