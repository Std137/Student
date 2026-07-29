using System.Text;
using System.Text.RegularExpressions;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            SaveDlg.Title = "Сохранить текстовый файл";
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);

                for (int i = 0; i < lbRight.Items.Count; i++)
                {
                    Writer.WriteLine((string)lbRight.Items[i]);
                }

                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tЛабораторная 1\t\n\tКрехтв В.В. ДПО-42\t\n\tVeleStudio@2026\t");
        }

 
        private void DeleteSelectedStrings(ListBox lbx)
        {
            lbx.BeginUpdate();
            for (int i = lbx.Items.Count - 1; i >= 0; i--)
            {
                if (lbx.GetSelected(i)) lbx.Items.RemoveAt(i);
            }
            lbx.EndUpdate();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lbFindRes.Items.Clear();

            string Find = tbFindField.Text;

            if (cbRd1.Checked)
            {
                foreach (string String in lbLeft.Items)
                {
                    if (String.Contains(Find)) lbFindRes.Items.Add(String);
                }
            }

            if (cbRd2.Checked)
            {
                foreach (string String in lbRight.Items)
                {
                    if (String.Contains(Find)) lbFindRes.Items.Add(String);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lbLeft.Items.Clear();
            lbRight.Items.Clear();

            lbLeft.BeginUpdate();

            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in Strings)
            {
                string Str = s.Trim();

                if (Str == String.Empty) continue;
                if (rbSelAll.Checked) lbLeft.Items.Add(Str);
                if (rbSelDgt.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) lbLeft.Items.Add(Str);
                }
                if (rbSelMail.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) lbLeft.Items.Add(Str);
                }
            }

            lbLeft.EndUpdate();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSortLftRght_Click(object sender, EventArgs e)
        {
            comboSort(lbRight, cbSelSortRight.SelectedIndex);
        }

        private void btnSortLft_Click(object sender, EventArgs e)
        {
            comboSort(lbLeft, cbSelSortLeft.SelectedIndex);
        }

        private void comboSort(ListBox lbx, int metod)
        {
            string[] sortlist = lbx.Items.OfType<string>().ToArray();
            if (sortlist.Length < 2) return;
            switch (metod)
            {
                case 0:
                    Array.Sort(sortlist);
                    break;
                case 1:
                    Array.Sort(sortlist, new Comparison<string>((x, y) => y.CompareTo(x)));
                    break;
                case 2:
                    Array.Sort(sortlist, (x, y) => x.Length.CompareTo(y.Length));
                    break;
                case 3:
                    Array.Sort(sortlist, (x, y) => y.Length.CompareTo(x.Length));
                    break;
                default:
                    break;
            }
            lbx.BeginUpdate();
            lbx.Items.Clear();
            lbx.Items.AddRange(sortlist);
            lbx.EndUpdate();
        }

        private void BtnSendLeftAll_Click(object sender, EventArgs e)
        {
            lbLeft.BeginUpdate();
            lbLeft.Items.AddRange(lbRight.Items);
            lbRight.Items.Clear();
            lbLeft.EndUpdate();
        }

        private void BtnSendRightAll_Click(object sender, EventArgs e)
        {
            lbRight.BeginUpdate();
            lbRight.Items.AddRange(lbLeft.Items);
            lbLeft.Items.Clear();
            lbRight.EndUpdate();
        }

        private void BtnSendLeft_Click(object sender, EventArgs e)
        {
            lbLeft.BeginUpdate();

            foreach (object Item in lbRight.SelectedItems)
            {
                lbLeft.Items.Add(Item);
            }
            lbLeft.EndUpdate();
            DeleteSelectedStrings(lbRight);
        }

        private void BtnSendRight_Click(object sender, EventArgs e)
        {
            lbRight.BeginUpdate();

            foreach (object Item in lbLeft.SelectedItems)
            {
                lbRight.Items.Add(Item);
            }
            lbRight.EndUpdate();
            DeleteSelectedStrings(lbLeft);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteSelectedStrings(lbLeft);
            DeleteSelectedStrings(lbRight);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void btnClearRgt_Click(object sender, EventArgs e)
        {
            lbRight.Items.Clear();
        }

        private void btnClearLft_Click(object sender, EventArgs e)
        {
            lbLeft.Items.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbLeft.Items.Clear();
            lbRight.Items.Clear();
            richTextBox1.Text = "";
            tbFindField.Text = "";
            lbFindRes.Items.Clear();
            cbRd1.Checked = true;
            cbRd2.Checked = false;
            rbSelAll.Checked = true;
        }
    }
}
