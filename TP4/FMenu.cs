using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassADO;

namespace TP4
{
    public partial class FMenu : MetroFramework.Forms.MetroForm
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            Connexion.Ouvrir();
            //MessageBox.Show(Connexion.cn.State.ToString());
        }

        private void TS_Btn_Cl_Click(object sender, EventArgs e)
        {
            FListe_Cl fc = new FListe_Cl();
            fc.MdiParent = this;
            fc.Show();
        }

        private void TS_Btn_Pr_Click(object sender, EventArgs e)
        {
            FListe_Prod fc = new FListe_Prod();
            fc.MdiParent = this;
            fc.Show();
        }

        private void TS_Btn_Cd_Click(object sender, EventArgs e)
        {
            FCommande fc = new FCommande();
            fc.MdiParent = this;
            fc.Show();
        }

        private void TS_Btn_Q_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Vous été sur de quitter?", "Quitter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }
    }
}
