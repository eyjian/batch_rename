using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace batch_rename
{
    public partial class FormMain : Form
    {
        private string currentDir; // 当前目录
        private bool is_asc = false; // 是否为升序？
        private string[] filters = { "*.jpg", "*.png", "*.bmp", "*.dib", "*.jpeg", "*.txt", "*.*" };
        private string[] pictureFilters = { "*.jpg", "*.png", "*.bmp", "*.dib", "*.jpeg" };
        private HashSet<string> filterSet;
        private HashSet<string> pictureFilterSet; // 图片文件后缀集合

        public FormMain()
        {
            InitializeComponent();

            // filterSet
            filterSet = new HashSet<string>();
            foreach (string filter in filters)
            {
                filterSet.Add(filter);
            }

            // pictureFilterSet
            pictureFilterSet = new HashSet<string>();
            foreach (string pictureFilter in pictureFilters)
            {
                pictureFilterSet.Add(pictureFilter);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            statusStrip.Items.Add("v0.3"); // 版本信息
            statusStrip.Items.Add("欢迎使用");
            statusStrip.Items.Add(DateTime.Now.ToLocalTime().ToString()); // 时间
            statusStrip.Items.Add(""); // 统计
            statusStrip.Items.Add(""); // 选中的文件路径
            comboBoxFileType.SelectedIndex = 0; // *.jpg
            //comboBoxFileType.SelectedIndex = 5; // *.txt

            toolTip.SetToolTip(buttonChooseDir, "选择需重命名的文件所在目录");
            toolTip.SetToolTip(comboBoxFileType, "选择需重命名的文件类型");
            toolTip.SetToolTip(buttonRefresh, "重新扫描原文件目录");
            toolTip.SetToolTip(buttonRefreshDest, "重新同步原文件名到新文件名");
            toolTip.SetToolTip(checkBoxOverwrite, "勾上表示与新文件名同名的文件已存在时，覆盖掉已存在的同名文件，否则跳过同名的已存在文件");
            toolTip.SetToolTip(checkBoxDeleteOld, "勾上表示成功后删除原文件，否则保留原文件");
        }

        private void FormMain_Leave(object sender, EventArgs e)
        {
            timerTime.Stop();
        }

        private void richTextBoxSrc_MouseDown(object sender, MouseEventArgs e)
        {
            //int currentLine = richTextBoxSrc.GetLineFromCharIndex(richTextBoxSrc.SelectionStart);
            //changePicture(currentLine);
        }

        private void richTextBoxSrc_SelectionChanged(object sender, EventArgs e)
        {
            int currentLine = richTextBoxSrc.GetLineFromCharIndex(richTextBoxSrc.SelectionStart);
            changePicture(currentLine);

            //richTextBoxDest.SelectionStart = richTextBoxSrc.SelectionStart;
            //richTextBoxDest.SelectionLength = richTextBoxSrc.SelectionLength;
            //richTextBoxDest.ScrollToCaret();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            statusStrip.Items[2].Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void buttonChooseDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                currentDir = folderBrowserDialog.SelectedPath.Trim();
                textBoxDir.Text = currentDir;
                refreshDir(currentDir);
            }
        }
        private void comboBoxFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentDir != null && currentDir.Length > 0)
            {
                refreshDir(currentDir);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshDir(currentDir);
        }

        private string getFilter()
        {
            // comboBoxFileType
            // JPG文件(*.jpg)
            // PNG文件(*.png)
            // BMP文件(*.bmp)
            // DIB文件(*.dib)
            // JPEG文件(*.jpeg)
            // 文本文件(*.txt)
            // 所有文件(*.*)
            return filters[comboBoxFileType.SelectedIndex];
        }

        private void refreshDir(string dirpath)
        {
            if (dirpath == null || dirpath.Length == 0)
            {
                MessageBox.Show("请先选择好文件目录。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string filter = getFilter();
                DirectoryInfo folder = new DirectoryInfo(dirpath);

                richTextBoxSrc.Clear();
                foreach (FileInfo file in folder.GetFiles(filter))
                {
                    if (richTextBoxSrc.Text.Length > 0)
                    {
                        richTextBoxSrc.AppendText("\n");
                    }

                    //richTextBoxSrc.AppendText(file.FullName); // 含目录部分
                    richTextBoxSrc.AppendText(file.Name); // 不含目录部分
                    richTextBoxDest.Lines = richTextBoxSrc.Lines;
                }
            }
        }

        private void changePicture(int currentLine)
        {
            //statusStrip.Items[0].Text = currentLine.ToString();

            if (currentLine >= 0 && currentLine < richTextBoxSrc.Lines.Length)
            {
                string line = richTextBoxSrc.Lines[currentLine].Trim();
                if (line.Length > 0)
                {
                    if (isPictureFile(line))
                    {
                        string filepath = currentDir + "\\" + line;

                        statusStrip.Items[4].Text = filepath;
                        if (System.IO.File.Exists(filepath))
                            pictureBox.ImageLocation = filepath;
                    }
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBoxSrc.Lines;
            Array.Sort(lines, new StringComparer(is_asc));
            is_asc = !is_asc;
            richTextBoxSrc.Lines = lines;
        }

        private void buttonRefreshDest_Click(object sender, EventArgs e)
        {
            richTextBoxDest.Lines = richTextBoxSrc.Lines;
        }

        private void buttonBatchRename_Click(object sender, EventArgs e)
        {
            string[] destFilenames = richTextBoxDest.Lines;
            string[] srcFilenames = richTextBoxSrc.Lines;

            if (destFilenames.Length == 0)
            {
                MessageBox.Show("无任何新文件名。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (srcFilenames.Length == 0)
            {
                MessageBox.Show("无任何原文件名。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (destFilenames.Length != srcFilenames.Length)
            {
                MessageBox.Show("原文件名个数和新文件名个数不相同。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (currentDir.Length == 0)
            {
                MessageBox.Show("请先选择好文件目录。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 批量重命名
                string destDirPath = currentDir + "\\new";

                try
                {
                    System.IO.Directory.CreateDirectory(destDirPath);
                    int successCount = 0; // 成功计数器
                    int existsCount = 0;
                    int errorCount = 0;

                    for (int i = 0; i < destFilenames.Length; i++)
                    {
                        string destFilepath = destDirPath + "\\" + destFilenames[i];
                        string srcFilepath = currentDir + "\\" + srcFilenames[i];

                        try
                        {
                            System.IO.File.Copy(srcFilepath, destFilepath, checkBoxOverwrite.Checked);
                            ++successCount;

                            if (checkBoxDeleteOld.Checked)
                            {
                                System.IO.File.Delete(srcFilepath); // 删除原文件
                            }
                        }
                        catch (System.IO.IOException ex)
                        {
                            if (ExceptionContainsErrorCode(ex, 183)) // ERROR_ALREADY_EXISTS
                            {
                                ++existsCount;
                            }
                            else
                            {
                                if (System.IO.File.Exists(destFilepath))
                                    ++existsCount;
                                else
                                    ++errorCount;
                            }
                        }
                        statusStrip.Items[3].Text = "成功数:" + successCount.ToString() +
                            " 出错数:" + errorCount.ToString() +
                            " 已存在数:" + existsCount.ToString();
                    }
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("创建目录 " + destDirPath + "失败。",
                        "遇到错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ExceptionContainsErrorCode(Exception e, int ErrorCode)
        {
            Win32Exception winEx = e as Win32Exception;

            if (winEx != null)
            {
                statusStrip.Items[2].Text = winEx.ErrorCode.ToString();
            }
            if (winEx != null && ErrorCode == winEx.ErrorCode)
            {
                return true;
            }
            if (e.InnerException != null)
            {
                return ExceptionContainsErrorCode(e.InnerException, ErrorCode);
            }

            return false;
        }

        private void richTextBoxSrc_TextChanged(object sender, EventArgs e)
        {

        }

        private string getSuffix(string filename)
        {
            return "*" + System.IO.Path.GetExtension(filename).ToLower();
        }

        private bool isPictureFile(string filename)
        {
            string suffix = getSuffix(filename);
            return pictureFilterSet.Contains(suffix);
        }

        private void richTextBoxSrc_VScroll(object sender, EventArgs e)
        {
        }

        private void textBoxDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 回车键
            {
                string dirpath = textBoxDir.Text.Trim();
                if (dirpath.Length > 0)
                {
                    if (System.IO.Directory.Exists(dirpath))
                    {
                        currentDir = dirpath;
                        refreshDir(currentDir);
                    }
                }
            }
        }
    }

    public class StringComparer : IComparer<string>
    {
        private bool is_asc = false;

        public StringComparer(bool asc)
        {
            this.is_asc = asc;
        }
        public int Compare(string x, string y)
        {
            int order = x.CompareTo(y);
            if (order == 0)
            {
                return 0;
            }
            else if (order == -1)
            {
                if (is_asc)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else

                if (is_asc)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
