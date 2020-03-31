using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 nForm = new AboutBox1();
            nForm.TopLevel = true;
            nForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)

            {

                using (StreamWriter sw = new StreamWriter(sfd.FileName))

                {

                    sw.Write(textBox1.Text);

                }

            }

        }

        private void bLoad_click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(dialog.FileName);
            }
          
        }


        public class FontDialog : CommonDialog
        {
            public override void Reset()
            {
                throw new NotImplementedException();
            }

            protected override bool RunDialog(IntPtr hwndOwner)
            {
                throw new NotImplementedException();
            }
        }

        private void bFonts_Click(object sender, EventArgs e)
        {
            DialogResult fontResult = fontDialog2.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                textBox1.Font = fontDialog2.Font;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                SaveFileDialog sfd = new SaveFileDialog();
               sfd.Filter = "Text Files|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)

                {

                    using (StreamWriter sw = new StreamWriter(sfd.FileName))

                    {

                        sw.Write(textBox1.Text);

                    }

                }
            }
        }


    }
}
