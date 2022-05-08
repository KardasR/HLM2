using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLM2
{
    public partial class EvenStrength : Form
    {
        public EvenStrength()
        {
            InitializeComponent();
        }

        private void PPbtn_Click(object sender, EventArgs e)
        {
            // First off, save the id's of the players
            PowerPlay powerPlay = new PowerPlay();
            powerPlay.Show();
        }
    }
}
