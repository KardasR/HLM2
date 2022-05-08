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
        public EvenStrength(bool newteam)
        {
            InitializeComponent();
        }

        private void PPbtn_Click(object sender, EventArgs e)
        {
            // First off, save the id's of the players
            PowerPlay powerPlay = new PowerPlay();
            powerPlay.Show();
        }

        private void PKbtn_Click(object sender, EventArgs e)
        {
            PenaltyKill penaltyKill = new PenaltyKill();
            penaltyKill.Show();
        }

        private void FoTbtn_Click(object sender, EventArgs e)
        {
            FoT fot = new FoT();
            fot.Show();
        }

        private void SOEAbtn_Click(object sender, EventArgs e)
        {
            SOEA soea = new SOEA();
            soea.Show();
        }

        private void AHLbtn_Click(object sender, EventArgs e)
        {
            AHLTeam ahlTeam = new AHLTeam();
            ahlTeam.Show();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {

        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
