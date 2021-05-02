using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quickmemo
{
    public partial class Form1 : Form
    {
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
            if (System.IO.File.Exists(path + NametextBox.Text + txtmem))
            {
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
            for (int i = MemoListBox.Items.Count - 1; i >= 0; i--)
            {
                if (MemoListBox.Items[i].ToString().CompareTo(mNewTitle) == 0)
                {
                    MemoListBox.SetSelected(i, true);
                }
            }
        }

        private void ReviseEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int mSelectedPosition = MemoListBox.SelectedIndex;
                if (System.IO.File.Exists(path + MemoListBox.Items[mSelectedPosition].ToString() + txtmem))
                {
                    string mNewTitle = NametextBox.Text;
                    System.IO.File.Move(path + MemoListBox.Items[mSelectedPosition].ToString() + txtmem, path + mNewTitle + txtmem);
                    MemoListBox.Items[mSelectedPosition] = mNewTitle;
                }

            }
        }
        private void FileListKeyEvent(object sender, KeyEventArgs e)
        {
            if (MemoListBox.SelectedItem != null)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    // 파일 삭제
                    string mTitle = NametextBox.Text;
                    if (System.IO.File.Exists(path + mTitle + txtmem))
                    {
                        System.IO.File.Delete(path + mTitle + txtmem);
                    }

                    //Nametextbox & BodyrichTextbox text clear
                    NametextBox.Text = "";
                    NametextBox.Enabled = false;
                    BodyrichTextBox.Text = "";

                    // 파일 목록 새로고침
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
            }
        }
    }
}
