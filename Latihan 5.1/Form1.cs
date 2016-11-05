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
namespace Latihan_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            copyCtrlcToolStripMenuItem.Enabled = false;
            cutCtrlxToolStripMenuItem.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult warna = colorDialog1.ShowDialog();

            if (warna == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
                button1.Visible = false;
                label1.Visible = false;
                treeView1.Visible = false;
            }
        }



        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
            Form2 a = new Form2();
            a.MdiParent = this;
            a.Show();
            a.WindowState = FormWindowState.Maximized;
            a.BringToFront();
            richTextBox1.Visible = true;
        }



        private void deleteDelToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Form1 a = new Form1();
            a.Show();
        }

        private void openToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*)";
            saveFileDialog1.DefaultExt = "rtf";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(richTextBox1.Text);
                    sw.Close();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void exitToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_SelectionChanged_2(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                cutCtrlxToolStripMenuItem.Enabled = false;
                copyCtrlcToolStripMenuItem.Enabled = false;
            }
            else
            {
                cutCtrlxToolStripMenuItem.Enabled = true;
                copyCtrlcToolStripMenuItem.Enabled = true;
            }
        }

        private void editorToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            treeView1.Visible = true;
            Form2 a = new Form2();
            a.MdiParent = this;
            a.Show();
            a.WindowState = FormWindowState.Maximized;
            a.BringToFront();
            richTextBox1.Visible = true;
        }

        private void menuStrip1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (copyCtrlcToolStripMenuItem.Enabled == true)
            {
                copyCtrlcToolStripMenuItem.Enabled = false;
                cutCtrlxToolStripMenuItem.Enabled = false;

            }
        }

        private void cutCtrlxToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyCtrlcToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText, TextDataFormat.UnicodeText);
            richTextBox1.Copy();
        }

        private void pasteCtrlvToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();

            }
        }

        private void treeView1_NodeMouseClick_2(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Background color")
            {
                button1.Visible = true;
                label1.Visible = true;

            }
            else
            {
                button1.Visible = false;
                label1.Visible = false;
            }

        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {
            if (copyCtrlcToolStripMenuItem.Enabled == true)
            {
                copyCtrlcToolStripMenuItem.Enabled = false;
                cutCtrlxToolStripMenuItem.Enabled = false;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
