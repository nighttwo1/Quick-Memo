using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quickmemo
{
    public partial class Form1 : Form
    {
        private void 파일목록새로고침ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoListBox.Items.Clear();
            mGetFileList();
        }

        private void 폴더위치설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = path;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path = dialog.FileName + "\\"; // 테스트용, 폴더 선택이 완료되면 선택된 폴더를 label에 출력
            }
            FilePathtextBox.Text = path;
            Properties.Settings.Default.ini_path = path;
            Properties.Settings.Default.Save();

            MemoListBox.Items.Clear();
            NametextBox.Text = "";
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
            string[] filearr = di.GetFiles("*.txt").Select(o => o.Name.Substring(0, o.Name.Length - 4)).ToArray();
            Array.Sort(filearr, new Compare.StringAsNumericComparer());
            for (int i = 0; i < filearr.Length; i++)
            {
                MemoListBox.Items.Add(filearr[i]);
            }
        }

    }
}
