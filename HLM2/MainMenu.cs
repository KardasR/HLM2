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


namespace HLM2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void LoadLinesBtn_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            using (openFileDialog1)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;

                    EvenStrength evenStrength = new EvenStrength(filePath);
                    evenStrength.Show();
                }
            }
        }

        private void NewLinesBtn_Click(object sender, EventArgs e)
        {
            EvenStrength evenStrength = new EvenStrength(string.Empty);
            evenStrength.Show();
        }
    }
}
