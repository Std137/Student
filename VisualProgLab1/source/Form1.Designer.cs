namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            btnExt = new Button();
            btnReset = new Button();
            btnFind = new Button();
            cbRd2 = new CheckBox();
            cbRd1 = new CheckBox();
            lbFindRes = new ListBox();
            tbFindField = new TextBox();
            btnDel = new Button();
            BtnSendLeftAll = new Button();
            BtnSendRightAll = new Button();
            BtnSendLeft = new Button();
            BtnSendRight = new Button();
            btnAdd = new Button();
            btnClearRgt = new Button();
            btnClearLft = new Button();
            btnSortLftRght = new Button();
            btnSortLft = new Button();
            lbRight = new ListBox();
            lbLeft = new ListBox();
            cbSelSortRight = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            cbSelSortLeft = new ComboBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            btnStart = new Button();
            rbSelMail = new RadioButton();
            rbSelDgt = new RadioButton();
            rbSelAll = new RadioButton();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            resources.ApplyResources(файлToolStripMenuItem, "файлToolStripMenuItem");
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            // 
            // открытьToolStripMenuItem
            // 
            resources.ApplyResources(открытьToolStripMenuItem, "открытьToolStripMenuItem");
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            resources.ApplyResources(сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            resources.ApplyResources(выходToolStripMenuItem, "выходToolStripMenuItem");
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnExt);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnFind);
            panel1.Controls.Add(cbRd2);
            panel1.Controls.Add(cbRd1);
            panel1.Controls.Add(lbFindRes);
            panel1.Controls.Add(tbFindField);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(BtnSendLeftAll);
            panel1.Controls.Add(BtnSendRightAll);
            panel1.Controls.Add(BtnSendLeft);
            panel1.Controls.Add(BtnSendRight);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnClearRgt);
            panel1.Controls.Add(btnClearLft);
            panel1.Controls.Add(btnSortLftRght);
            panel1.Controls.Add(btnSortLft);
            panel1.Controls.Add(lbRight);
            panel1.Controls.Add(lbLeft);
            panel1.Controls.Add(cbSelSortRight);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbSelSortLeft);
            panel1.Controls.Add(label1);
            panel1.Name = "panel1";
            // 
            // btnExt
            // 
            resources.ApplyResources(btnExt, "btnExt");
            btnExt.Name = "btnExt";
            btnExt.UseVisualStyleBackColor = true;
            btnExt.Click += btnExt_Click;
            // 
            // btnReset
            // 
            resources.ApplyResources(btnReset, "btnReset");
            btnReset.Name = "btnReset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnFind
            // 
            resources.ApplyResources(btnFind, "btnFind");
            btnFind.Name = "btnFind";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // cbRd2
            // 
            resources.ApplyResources(cbRd2, "cbRd2");
            cbRd2.Name = "cbRd2";
            cbRd2.UseVisualStyleBackColor = true;
            // 
            // cbRd1
            // 
            resources.ApplyResources(cbRd1, "cbRd1");
            cbRd1.Checked = true;
            cbRd1.CheckState = CheckState.Checked;
            cbRd1.Name = "cbRd1";
            cbRd1.UseVisualStyleBackColor = true;
            // 
            // lbFindRes
            // 
            resources.ApplyResources(lbFindRes, "lbFindRes");
            lbFindRes.FormattingEnabled = true;
            lbFindRes.Name = "lbFindRes";
            lbFindRes.SelectionMode = SelectionMode.MultiExtended;
            // 
            // tbFindField
            // 
            resources.ApplyResources(tbFindField, "tbFindField");
            tbFindField.Name = "tbFindField";
            // 
            // btnDel
            // 
            resources.ApplyResources(btnDel, "btnDel");
            btnDel.Name = "btnDel";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // BtnSendLeftAll
            // 
            resources.ApplyResources(BtnSendLeftAll, "BtnSendLeftAll");
            BtnSendLeftAll.Name = "BtnSendLeftAll";
            BtnSendLeftAll.UseVisualStyleBackColor = true;
            BtnSendLeftAll.Click += BtnSendLeftAll_Click;
            // 
            // BtnSendRightAll
            // 
            resources.ApplyResources(BtnSendRightAll, "BtnSendRightAll");
            BtnSendRightAll.Name = "BtnSendRightAll";
            BtnSendRightAll.UseVisualStyleBackColor = true;
            BtnSendRightAll.Click += BtnSendRightAll_Click;
            // 
            // BtnSendLeft
            // 
            resources.ApplyResources(BtnSendLeft, "BtnSendLeft");
            BtnSendLeft.Name = "BtnSendLeft";
            BtnSendLeft.UseVisualStyleBackColor = true;
            BtnSendLeft.Click += BtnSendLeft_Click;
            // 
            // BtnSendRight
            // 
            resources.ApplyResources(BtnSendRight, "BtnSendRight");
            BtnSendRight.Name = "BtnSendRight";
            BtnSendRight.UseVisualStyleBackColor = true;
            BtnSendRight.Click += BtnSendRight_Click;
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClearRgt
            // 
            resources.ApplyResources(btnClearRgt, "btnClearRgt");
            btnClearRgt.Name = "btnClearRgt";
            btnClearRgt.UseVisualStyleBackColor = true;
            btnClearRgt.Click += btnClearRgt_Click;
            // 
            // btnClearLft
            // 
            resources.ApplyResources(btnClearLft, "btnClearLft");
            btnClearLft.Name = "btnClearLft";
            btnClearLft.UseVisualStyleBackColor = true;
            btnClearLft.Click += btnClearLft_Click;
            // 
            // btnSortLftRght
            // 
            resources.ApplyResources(btnSortLftRght, "btnSortLftRght");
            btnSortLftRght.Name = "btnSortLftRght";
            btnSortLftRght.UseVisualStyleBackColor = true;
            btnSortLftRght.Click += btnSortLftRght_Click;
            // 
            // btnSortLft
            // 
            resources.ApplyResources(btnSortLft, "btnSortLft");
            btnSortLft.Name = "btnSortLft";
            btnSortLft.UseVisualStyleBackColor = true;
            btnSortLft.Click += btnSortLft_Click;
            // 
            // lbRight
            // 
            resources.ApplyResources(lbRight, "lbRight");
            lbRight.FormattingEnabled = true;
            lbRight.Name = "lbRight";
            lbRight.SelectionMode = SelectionMode.MultiExtended;
            // 
            // lbLeft
            // 
            resources.ApplyResources(lbLeft, "lbLeft");
            lbLeft.FormattingEnabled = true;
            lbLeft.Name = "lbLeft";
            lbLeft.SelectionMode = SelectionMode.MultiExtended;
            // 
            // cbSelSortRight
            // 
            resources.ApplyResources(cbSelSortRight, "cbSelSortRight");
            cbSelSortRight.FormattingEnabled = true;
            cbSelSortRight.Items.AddRange(new object[] { resources.GetString("cbSelSortRight.Items"), resources.GetString("cbSelSortRight.Items1"), resources.GetString("cbSelSortRight.Items2"), resources.GetString("cbSelSortRight.Items3") });
            cbSelSortRight.Name = "cbSelSortRight";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // cbSelSortLeft
            // 
            resources.ApplyResources(cbSelSortLeft, "cbSelSortLeft");
            cbSelSortLeft.FormattingEnabled = true;
            cbSelSortLeft.Items.AddRange(new object[] { resources.GetString("cbSelSortLeft.Items"), resources.GetString("cbSelSortLeft.Items1"), resources.GetString("cbSelSortLeft.Items2"), resources.GetString("cbSelSortLeft.Items3") });
            cbSelSortLeft.Name = "cbSelSortLeft";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.Name = "richTextBox1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(btnStart);
            groupBox1.Controls.Add(rbSelMail);
            groupBox1.Controls.Add(rbSelDgt);
            groupBox1.Controls.Add(rbSelAll);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // btnStart
            // 
            resources.ApplyResources(btnStart, "btnStart");
            btnStart.Name = "btnStart";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // rbSelMail
            // 
            resources.ApplyResources(rbSelMail, "rbSelMail");
            rbSelMail.Name = "rbSelMail";
            rbSelMail.UseVisualStyleBackColor = true;
            // 
            // rbSelDgt
            // 
            resources.ApplyResources(rbSelDgt, "rbSelDgt");
            rbSelDgt.Name = "rbSelDgt";
            rbSelDgt.UseVisualStyleBackColor = true;
            // 
            // rbSelAll
            // 
            resources.ApplyResources(rbSelAll, "rbSelAll");
            rbSelAll.Checked = true;
            rbSelAll.Name = "rbSelAll";
            rbSelAll.TabStop = true;
            rbSelAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel panel1;
        private Label label1;
        private ComboBox cbSelSortLeft;
        private Label label3;
        private Button btnDel;
        private Button btnAdd;
        private Button btnClearLft;
        private Button btnSortLft;
        private Button BtnSendLeftAll;
        private Button BtnSendRightAll;
        private Button BtnSendLeft;
        private Button BtnSendRight;
        private Button btnClearRgt;
        private Button btnSortLftRght;
        private ComboBox cbSelSortRight;
        private Label label2;
        private TextBox tbFindField;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private ListBox lbFindRes;
        private RadioButton rbSelMail;
        private RadioButton rbSelDgt;
        private RadioButton rbSelAll;
        private Button btnStart;
        private Button btnFind;
        private CheckBox cbRd2;
        private CheckBox cbRd1;
        private Button btnExt;
        private Button btnReset;
        public ListBox lbLeft;
        public ListBox lbRight;
    }
}
