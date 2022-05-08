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
            // Clear Left Wings
            LW1.Text = string.Empty;
            LWOvr1.Text = string.Empty;
            LW2.Text = string.Empty;
            LWOvr2.Text = string.Empty;
            LW3.Text = string.Empty;
            LWOvr3.Text = string.Empty;
            LW4.Text = string.Empty;
            LWOvr4.Text = string.Empty;
            LW5.Text = string.Empty;
            LWOvr5.Text = string.Empty;

            // Clear Centers
            C1.Text = string.Empty;
            COvr1.Text = string.Empty;
            C2.Text = string.Empty;
            COvr2.Text = string.Empty;
            C3.Text = string.Empty;
            COvr3.Text = string.Empty;
            C4.Text = string.Empty;
            COvr4.Text = string.Empty;
            C5.Text = string.Empty;
            COvr5.Text = string.Empty;

            // Clear Right Wings
            RW1.Text = string.Empty;
            RWOvr1.Text = string.Empty;
            RW2.Text = string.Empty;
            RWOvr2.Text = string.Empty;
            RW3.Text = string.Empty;
            RWOvr3.Text = string.Empty;
            RW4.Text = string.Empty;
            RWOvr4.Text = string.Empty;
            RW5.Text = string.Empty;
            RWOvr5.Text = string.Empty;

            // Clear Left Defenceman
            LD1.Text = string.Empty;
            LDOvr1.Text = string.Empty;
            LD2.Text = string.Empty;
            LDOvr2.Text = string.Empty;
            LD3.Text = string.Empty;
            LDOvr3.Text = string.Empty;
            LD4.Text = string.Empty;
            LDOvr4.Text = string.Empty;

            // Clear Right Defenceman
            RD1.Text = string.Empty;
            RDOvr1.Text = string.Empty;
            RD2.Text = string.Empty;
            RDOvr2.Text = string.Empty;
            RD3.Text = string.Empty;
            RDOvr3.Text = string.Empty;
            RD4.Text = string.Empty;
            RDOvr4.Text = string.Empty;

            // Clear Goalies
            G1.Text = string.Empty;
            GOvr1.Text = string.Empty;
            G2.Text = string.Empty;
            GOvr2.Text = string.Empty;
            G3.Text = string.Empty;
            GOvr3.Text = string.Empty;
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
