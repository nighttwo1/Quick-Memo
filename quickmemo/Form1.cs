using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace quickmemo
{
    public partial class Form1 : Form
    {
        
        private string path = "";
        private string txtmem = ".txt";
        private void mGetFileList()
        {
            if (path != "")
            {
                FilePathtextBox.Text = path;
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
                string[] filearr = di.GetFiles("*.txt").Select(o => o.Name.Substring(0, o.Name.Length - 4)).ToArray();
                Array.Sort(filearr, new Compare.StringAsNumericComparer());
                for (int i = 0; i < filearr.Length; i++)
                {
                    MemoListBox.Items.Add(filearr[i]);
                }
                Addbutton.Enabled = true;
            }
            else
            {
                Addbutton.Enabled = false;
            }

        }

        // 앱 처음 실행시 저장된 폴더 경로가 없으면 폴더를 선택할 수 있도록 CommonOpenFileDialog를 띄운다.
        private void mInitFolderPath()
        {
            path = Properties.Settings.Default.ini_path;
            if (path == "")
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.InitialDirectory = path;
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    //선택된 폴더 경로 저장
                    path = dialog.FileName + "\\"; // 테스트용, 폴더 선택이 완료되면 선택된 폴더를 label에 출력
                }
                Properties.Settings.Default.ini_path = path;
                Properties.Settings.Default.Save();
                FilePathtextBox.Text = "";
                FilePathtextBox.Text = path;

            }
        }

        public Form1()
        {
            InitializeComponent();
            mInitFolderPath();
            mGetFileList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MemoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MemoListBox.SelectedIndex == -1)
            {
                NametextBox.Enabled = false;
                return;
            }
            NametextBox.Enabled = true;
            // 파일 이름 표현
            NametextBox.Text = MemoListBox.SelectedItem.ToString();

            // 파일 불러오기
            if(System.IO.File.Exists(path+ NametextBox.Text + txtmem)){
                StreamReader sr = new StreamReader(path + NametextBox.Text + txtmem);
                string body = "";
                body = sr.ReadToEnd();
                BodyrichTextBox.Text = body;
                sr.Close();
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            //파일 생성
            string mNewTitle = "새로운 메모0";
            if (System.IO.File.Exists(path + mNewTitle + txtmem))
            {
                mNewTitle = mNewTitle.Substring(0, mNewTitle.Length - 1);
                int i = 1;
                while(true)
                {
                    if(!System.IO.File.Exists(path + mNewTitle + i + txtmem)){
                        break;
                    }
                    i++;
                }

                mNewTitle += i;
                MemoListBox.Items.Add(mNewTitle);
                StreamWriter writer;
                writer = File.CreateText(path + mNewTitle + txtmem);
                writer.Write("");
                writer.Close();

            }
            else
            {
                MemoListBox.Items.Add(mNewTitle);
                StreamWriter writer;
                writer = File.CreateText(path + mNewTitle + txtmem);
                writer.Write("");
                writer.Close();
            }

            // 새로운 파일에 포커스 두기
            for (int i = MemoListBox.Items.Count - 1; i >= 0; i--){
                if(MemoListBox.Items[i].ToString().CompareTo(mNewTitle) == 0)
                {
                    MemoListBox.SetSelected(i, true);
                }
            }
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReviseEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int mSelectedPosition = MemoListBox.SelectedIndex;
                if (System.IO.File.Exists(path+ MemoListBox.Items[mSelectedPosition].ToString() + txtmem))
                {
                    string mNewTitle = NametextBox.Text;
                    System.IO.File.Move(path + MemoListBox.Items[mSelectedPosition].ToString() + txtmem, path + mNewTitle + txtmem);
                    MemoListBox.Items[mSelectedPosition] = mNewTitle;
                }
                
            }
        }

        
        private void mCreateFileQuick()
        {
            // 선택된 아이템이 없을 경우
            if (MemoListBox.SelectedItem == null)
            {
                //파일 생성
                string mNewTitle = "새로운 메모0";
                if (System.IO.File.Exists(path + mNewTitle + txtmem))
                {
                    mNewTitle = mNewTitle.Substring(0, mNewTitle.Length - 1);
                    int i = 1;
                    while (true)
                    {
                        if (!System.IO.File.Exists(path + mNewTitle + i + txtmem))
                        {
                            break;
                        }
                        i++;
                    }

                    mNewTitle += i;
                    MemoListBox.Items.Add(mNewTitle);
                    StreamWriter writer;
                    writer = File.CreateText(path + mNewTitle + txtmem);
                    writer.Write(BodyrichTextBox.Text);
                    writer.Close();

                }
                else
                {
                    MemoListBox.Items.Add(mNewTitle);
                    StreamWriter writer;
                    writer = File.CreateText(path + mNewTitle + txtmem);
                    writer.Write(BodyrichTextBox.Text);
                    writer.Close();
                }

                // 새로운 파일에 포커스 두기
                for (int i = MemoListBox.Items.Count - 1; i >= 0; i--)
                {
                    if (MemoListBox.Items[i].ToString().CompareTo(mNewTitle) == 0)
                    {
                        MemoListBox.SetSelected(i, true);
                    }
                }
            }
        }



        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            MemoListBox.Items.Clear();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
            string[] filearr = di.GetFiles("*.txt").Select(o => o.Name.Substring(0, o.Name.Length - 4)).ToArray();
            Array.Sort(filearr, new Compare.StringAsNumericComparer());
            for (int i = 0; i < filearr.Length; i++)
            {
                if (filearr[i].ToLower().Contains(SearchtextBox.Text.ToLower()))
                {
                    MemoListBox.Items.Add(filearr[i]);
                }
            }
        }

        private void 폴더위치설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = path;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path = dialog.FileName+"\\"; // 테스트용, 폴더 선택이 완료되면 선택된 폴더를 label에 출력
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FilePathtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void 파일목록새로고침ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoListBox.Items.Clear();
            mGetFileList();
        }

        private void BodyrichTextBox_TextChanged(object sender, EventArgs e)
        {
            this.BodyrichTextBox.LostFocus += OnDefocus;
        }

        private void OnDefocus(object sender, EventArgs e)
        {
            string title = NametextBox.Text;
            if (System.IO.File.Exists(path + title + txtmem))
            {
                string textbody = BodyrichTextBox.Text;
                System.IO.File.WriteAllText(path + title + txtmem, textbody, Encoding.UTF8);
            }
        }


        private void MemoEvent(object sender, KeyEventArgs e)
        {
            // 메모장 문자열 검색
            if (e.Control & e.KeyCode == Keys.F)
            {

            }
            // 메모장 내용 저장
            else if (e.Control & e.KeyCode == Keys.S)
            {
                mCreateFileQuick();

                string title = NametextBox.Text;
                if (System.IO.File.Exists(path + title + txtmem))
                {

                    string textbody = BodyrichTextBox.Text;
                    System.IO.File.WriteAllText(path + title + txtmem, textbody, Encoding.UTF8);
                }
            }
        }
    }
}
