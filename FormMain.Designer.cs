namespace batch_rename
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panelHead = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonChooseDir = new System.Windows.Forms.Button();
            this.splitContainerBody = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxSrc = new System.Windows.Forms.RichTextBox();
            this.panelSrcHead = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSrc = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxDest = new System.Windows.Forms.RichTextBox();
            this.panelDestHead = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDest = new System.Windows.Forms.Panel();
            this.checkBoxDeleteOld = new System.Windows.Forms.CheckBox();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.buttonRefreshDest = new System.Windows.Forms.Button();
            this.buttonBatchRename = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelPictureHead = new System.Windows.Forms.Panel();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.groupBoxHead = new System.Windows.Forms.GroupBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelHead.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.splitContainerBody.Panel1.SuspendLayout();
            this.splitContainerBody.Panel2.SuspendLayout();
            this.splitContainerBody.SuspendLayout();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSrcHead.SuspendLayout();
            this.panelSrc.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDestHead.SuspendLayout();
            this.panelDest.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // statusStrip
            // 
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Location = new System.Drawing.Point(0, 668);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1172, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.panel5);
            this.panelHead.Controls.Add(this.panel4);
            this.panelHead.Controls.Add(this.panel3);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1172, 79);
            this.panelHead.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBoxDir);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(161, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(710, 79);
            this.panel5.TabIndex = 2;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDir.Location = new System.Drawing.Point(0, 27);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(710, 28);
            this.textBoxDir.TabIndex = 3;
            this.textBoxDir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDir_KeyDown);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 61);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(710, 18);
            this.panel9.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(710, 27);
            this.panel8.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxFileType);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(871, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 79);
            this.panel4.TabIndex = 1;
            // 
            // comboBoxFileType
            // 
            this.comboBoxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Items.AddRange(new object[] {
            "JPG文件(*.jpg)",
            "PNG文件(*.png)",
            "BMP文件(*.bmp)",
            "DIB文件(*.dib)",
            "JPEG文件(*.jpeg)",
            "文本文件(*.txt)",
            "所有文件(*.*)"});
            this.comboBoxFileType.Location = new System.Drawing.Point(106, 26);
            this.comboBoxFileType.Name = "comboBoxFileType";
            this.comboBoxFileType.Size = new System.Drawing.Size(175, 26);
            this.comboBoxFileType.TabIndex = 2;
            this.comboBoxFileType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件类型：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonChooseDir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 79);
            this.panel3.TabIndex = 0;
            // 
            // buttonChooseDir
            // 
            this.buttonChooseDir.Location = new System.Drawing.Point(12, 21);
            this.buttonChooseDir.Name = "buttonChooseDir";
            this.buttonChooseDir.Size = new System.Drawing.Size(134, 37);
            this.buttonChooseDir.TabIndex = 1;
            this.buttonChooseDir.Text = "选择文件目录";
            this.buttonChooseDir.UseVisualStyleBackColor = true;
            this.buttonChooseDir.Click += new System.EventHandler(this.buttonChooseDir_Click);
            // 
            // splitContainerBody
            // 
            this.splitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBody.Location = new System.Drawing.Point(0, 79);
            this.splitContainerBody.Name = "splitContainerBody";
            // 
            // splitContainerBody.Panel1
            // 
            this.splitContainerBody.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainerBody.Panel2
            // 
            this.splitContainerBody.Panel2.Controls.Add(this.panel6);
            this.splitContainerBody.Panel2.Controls.Add(this.panelPictureHead);
            this.splitContainerBody.Panel2.Controls.Add(this.panelPicture);
            this.splitContainerBody.Size = new System.Drawing.Size(1172, 589);
            this.splitContainerBody.SplitterDistance = 721;
            this.splitContainerBody.TabIndex = 9;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.panel1);
            this.splitContainerLeft.Panel1.Controls.Add(this.panelSrcHead);
            this.splitContainerLeft.Panel1.Controls.Add(this.panelSrc);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.panel2);
            this.splitContainerLeft.Panel2.Controls.Add(this.panelDestHead);
            this.splitContainerLeft.Panel2.Controls.Add(this.panelDest);
            this.splitContainerLeft.Size = new System.Drawing.Size(721, 589);
            this.splitContainerLeft.SplitterDistance = 239;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxSrc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 491);
            this.panel1.TabIndex = 3;
            // 
            // richTextBoxSrc
            // 
            this.richTextBoxSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSrc.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxSrc.Name = "richTextBoxSrc";
            this.richTextBoxSrc.Size = new System.Drawing.Size(239, 491);
            this.richTextBoxSrc.TabIndex = 2;
            this.richTextBoxSrc.Text = "";
            this.richTextBoxSrc.SelectionChanged += new System.EventHandler(this.richTextBoxSrc_SelectionChanged);
            this.richTextBoxSrc.VScroll += new System.EventHandler(this.richTextBoxSrc_VScroll);
            this.richTextBoxSrc.TextChanged += new System.EventHandler(this.richTextBoxSrc_TextChanged);
            this.richTextBoxSrc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBoxSrc_MouseDown);
            // 
            // panelSrcHead
            // 
            this.panelSrcHead.Controls.Add(this.label2);
            this.panelSrcHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSrcHead.Location = new System.Drawing.Point(0, 0);
            this.panelSrcHead.Name = "panelSrcHead";
            this.panelSrcHead.Size = new System.Drawing.Size(239, 48);
            this.panelSrcHead.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "原文件名：";
            // 
            // panelSrc
            // 
            this.panelSrc.Controls.Add(this.buttonRefresh);
            this.panelSrc.Controls.Add(this.buttonSort);
            this.panelSrc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSrc.Location = new System.Drawing.Point(0, 539);
            this.panelSrc.Name = "panelSrc";
            this.panelSrc.Size = new System.Drawing.Size(239, 50);
            this.panelSrc.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.AutoEllipsis = true;
            this.buttonRefresh.Location = new System.Drawing.Point(8, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(81, 37);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(94, 6);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(81, 37);
            this.buttonSort.TabIndex = 0;
            this.buttonSort.Text = "排序";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBoxDest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 491);
            this.panel2.TabIndex = 3;
            // 
            // richTextBoxDest
            // 
            this.richTextBoxDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDest.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxDest.Name = "richTextBoxDest";
            this.richTextBoxDest.Size = new System.Drawing.Size(478, 491);
            this.richTextBoxDest.TabIndex = 2;
            this.richTextBoxDest.Text = "";
            // 
            // panelDestHead
            // 
            this.panelDestHead.Controls.Add(this.label3);
            this.panelDestHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDestHead.Location = new System.Drawing.Point(0, 0);
            this.panelDestHead.Name = "panelDestHead";
            this.panelDestHead.Size = new System.Drawing.Size(478, 48);
            this.panelDestHead.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "新文件名：";
            // 
            // panelDest
            // 
            this.panelDest.Controls.Add(this.checkBoxDeleteOld);
            this.panelDest.Controls.Add(this.checkBoxOverwrite);
            this.panelDest.Controls.Add(this.buttonRefreshDest);
            this.panelDest.Controls.Add(this.buttonBatchRename);
            this.panelDest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDest.Location = new System.Drawing.Point(0, 539);
            this.panelDest.Name = "panelDest";
            this.panelDest.Size = new System.Drawing.Size(478, 50);
            this.panelDest.TabIndex = 0;
            // 
            // checkBoxDeleteOld
            // 
            this.checkBoxDeleteOld.AutoSize = true;
            this.checkBoxDeleteOld.Location = new System.Drawing.Point(332, 14);
            this.checkBoxDeleteOld.Name = "checkBoxDeleteOld";
            this.checkBoxDeleteOld.Size = new System.Drawing.Size(124, 22);
            this.checkBoxDeleteOld.TabIndex = 3;
            this.checkBoxDeleteOld.Text = "删除原文件";
            this.checkBoxDeleteOld.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(220, 14);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(106, 22);
            this.checkBoxOverwrite.TabIndex = 2;
            this.checkBoxOverwrite.Text = "覆盖模式";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshDest
            // 
            this.buttonRefreshDest.Location = new System.Drawing.Point(9, 6);
            this.buttonRefreshDest.Name = "buttonRefreshDest";
            this.buttonRefreshDest.Size = new System.Drawing.Size(75, 37);
            this.buttonRefreshDest.TabIndex = 1;
            this.buttonRefreshDest.Text = "刷新";
            this.buttonRefreshDest.UseVisualStyleBackColor = true;
            this.buttonRefreshDest.Click += new System.EventHandler(this.buttonRefreshDest_Click);
            // 
            // buttonBatchRename
            // 
            this.buttonBatchRename.Location = new System.Drawing.Point(89, 6);
            this.buttonBatchRename.Name = "buttonBatchRename";
            this.buttonBatchRename.Size = new System.Drawing.Size(116, 37);
            this.buttonBatchRename.TabIndex = 0;
            this.buttonBatchRename.Text = "批量重命名";
            this.buttonBatchRename.UseVisualStyleBackColor = true;
            this.buttonBatchRename.Click += new System.EventHandler(this.buttonBatchRename_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(447, 491);
            this.panel6.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::batch_rename.Properties.Resources.caihonggongyi;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(447, 491);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // panelPictureHead
            // 
            this.panelPictureHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPictureHead.Location = new System.Drawing.Point(0, 0);
            this.panelPictureHead.Name = "panelPictureHead";
            this.panelPictureHead.Size = new System.Drawing.Size(447, 48);
            this.panelPictureHead.TabIndex = 2;
            // 
            // panelPicture
            // 
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPicture.Location = new System.Drawing.Point(0, 539);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(447, 50);
            this.panelPicture.TabIndex = 0;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // groupBoxHead
            // 
            this.groupBoxHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxHead.Location = new System.Drawing.Point(0, 79);
            this.groupBoxHead.Name = "groupBoxHead";
            this.groupBoxHead.Size = new System.Drawing.Size(1172, 2);
            this.groupBoxHead.TabIndex = 10;
            this.groupBoxHead.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 690);
            this.Controls.Add(this.groupBoxHead);
            this.Controls.Add(this.splitContainerBody);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(980, 610);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量文件重命名小工具";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Leave += new System.EventHandler(this.FormMain_Leave);
            this.panelHead.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainerBody.Panel1.ResumeLayout(false);
            this.splitContainerBody.Panel2.ResumeLayout(false);
            this.splitContainerBody.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            this.splitContainerLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelSrcHead.ResumeLayout(false);
            this.panelSrcHead.PerformLayout();
            this.panelSrc.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelDestHead.ResumeLayout(false);
            this.panelDestHead.PerformLayout();
            this.panelDest.ResumeLayout(false);
            this.panelDest.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.SplitContainer splitContainerBody;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.Panel panelSrc;
        private System.Windows.Forms.Panel panelDest;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Button buttonChooseDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFileType;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonBatchRename;
        private System.Windows.Forms.Panel panelSrcHead;
        private System.Windows.Forms.Panel panelDestHead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPictureHead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxSrc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxDest;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBoxHead;
        private System.Windows.Forms.Button buttonRefreshDest;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.CheckBox checkBoxDeleteOld;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

