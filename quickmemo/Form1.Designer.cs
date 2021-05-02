
namespace quickmemo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Addbutton = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MemoListBox = new System.Windows.Forms.ListBox();
            this.MainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폴더위치설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일목록새로고침ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilePathtextBox = new System.Windows.Forms.TextBox();
            this.BodyrichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Addbutton
            // 
            this.Addbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Addbutton.Location = new System.Drawing.Point(713, 30);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 1;
            this.Addbutton.Text = "추가";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(42, 31);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(138, 21);
            this.SearchtextBox.TabIndex = 2;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // NametextBox
            // 
            this.NametextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NametextBox.Enabled = false;
            this.NametextBox.Location = new System.Drawing.Point(12, 413);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(168, 21);
            this.NametextBox.TabIndex = 4;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            this.NametextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReviseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quickmemo.Properties.Resources.search__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MemoListBox
            // 
            this.MemoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MemoListBox.FormattingEnabled = true;
            this.MemoListBox.ItemHeight = 12;
            this.MemoListBox.Location = new System.Drawing.Point(12, 66);
            this.MemoListBox.Name = "MemoListBox";
            this.MemoListBox.Size = new System.Drawing.Size(168, 340);
            this.MemoListBox.TabIndex = 0;
            this.MemoListBox.SelectedIndexChanged += new System.EventHandler(this.MemoListBox_SelectedIndexChanged);
            // 
            // MainmenuStrip
            // 
            this.MainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.MainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainmenuStrip.Name = "MainmenuStrip";
            this.MainmenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainmenuStrip.TabIndex = 7;
            this.MainmenuStrip.Text = "menuStrip1";
            this.MainmenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폴더위치설정ToolStripMenuItem,
            this.파일목록새로고침ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 폴더위치설정ToolStripMenuItem
            // 
            this.폴더위치설정ToolStripMenuItem.Name = "폴더위치설정ToolStripMenuItem";
            this.폴더위치설정ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.폴더위치설정ToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.폴더위치설정ToolStripMenuItem.Text = "폴더 위치 설정";
            this.폴더위치설정ToolStripMenuItem.Click += new System.EventHandler(this.폴더위치설정ToolStripMenuItem_Click);
            // 
            // 파일목록새로고침ToolStripMenuItem
            // 
            this.파일목록새로고침ToolStripMenuItem.Name = "파일목록새로고침ToolStripMenuItem";
            this.파일목록새로고침ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.파일목록새로고침ToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.파일목록새로고침ToolStripMenuItem.Text = "파일 목록 새로고침";
            this.파일목록새로고침ToolStripMenuItem.Click += new System.EventHandler(this.파일목록새로고침ToolStripMenuItem_Click);
            // 
            // FilePathtextBox
            // 
            this.FilePathtextBox.BackColor = System.Drawing.SystemColors.Control;
            this.FilePathtextBox.Enabled = false;
            this.FilePathtextBox.Location = new System.Drawing.Point(360, 31);
            this.FilePathtextBox.Name = "FilePathtextBox";
            this.FilePathtextBox.Size = new System.Drawing.Size(347, 21);
            this.FilePathtextBox.TabIndex = 8;
            // 
            // BodyrichTextBox
            // 
            this.BodyrichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyrichTextBox.Location = new System.Drawing.Point(198, 66);
            this.BodyrichTextBox.Name = "BodyrichTextBox";
            this.BodyrichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.BodyrichTextBox.Size = new System.Drawing.Size(590, 368);
            this.BodyrichTextBox.TabIndex = 9;
            this.BodyrichTextBox.Text = "";
            this.BodyrichTextBox.TextChanged += new System.EventHandler(this.BodyrichTextBox_TextChanged);
            this.BodyrichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemoEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BodyrichTextBox);
            this.Controls.Add(this.FilePathtextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.MemoListBox);
            this.Controls.Add(this.MainmenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainmenuStrip;
            this.Name = "Form1";
            this.Text = "빠른 메모";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainmenuStrip.ResumeLayout(false);
            this.MainmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox MemoListBox;
        private System.Windows.Forms.MenuStrip MainmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폴더위치설정ToolStripMenuItem;
        private System.Windows.Forms.TextBox FilePathtextBox;
        private System.Windows.Forms.ToolStripMenuItem 파일목록새로고침ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox BodyrichTextBox;
    }
}

