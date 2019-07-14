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

namespace Compuscan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtInputFile.Items.Clear();
            txtOutPutFile.Items.Clear();

            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                txtFileName.Text = openFileDialog1.FileName;

                System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberDecimalSeparator = ".";
                System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
                
                StreamReader file = new StreamReader(openFileDialog1.FileName);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    Calculator x = new Calculator(line);
                    txtInputFile.Items.Add(line);
                    txtOutPutFile.Items.Add(x.getTotal());
                }

                file.Close();
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtInputFile.Items.Clear();
            txtOutPutFile.Items.Clear();
            txtFileName.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = new string[txtOutPutFile.Items.Count];
                for (int i = 0; i < txtOutPutFile.Items.Count; i++)
                {
                    lines[i] = txtOutPutFile.Items[i].ToString();
                }
                File.WriteAllLines(saveFileDialog1.FileName, lines);
                MessageBox.Show("Successfully saved");
            }
                
        }
    }
}
