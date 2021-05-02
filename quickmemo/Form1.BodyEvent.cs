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
        private void BodyrichTextBox_TextChanged(object sender, EventArgs e)
        {
            this.BodyrichTextBox.LostFocus += OnDefocus;

        }

        private void OnDefocus(object sender, EventArgs e)
        {
            try
            {
                string title = NametextBox.Text;
                if (System.IO.File.Exists(path + title + txtmem))
                {
                    string textbody = BodyrichTextBox.Text;
                    System.IO.File.WriteAllText(path + title + txtmem, textbody, Encoding.UTF8);
                }
            }
            catch (IOException ex)
            {
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
            else if (e.Control & e.KeyCode == Keys.T)
            {
                BodyrichTextBox.Enabled = false;
                test_Body("글 확인: ");
                BodyrichTextBox.Enabled = true;
            }
        }
    }
}
