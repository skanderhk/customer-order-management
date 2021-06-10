using ClassADO;
using ClassBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class FListe_Cl : MetroFramework.Forms.MetroForm
    {
        Client selectedClient = new Client();
        public FListe_Cl()
        {
            InitializeComponent();
        }

        private void FListe_Cl_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bd_ClientDataSet3.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLIENTTableAdapter1.Fill(this.bd_ClientDataSet3.CLIENT);
            Dg_Clt.DataSource = ClientADO.Liste_Client();

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            String cin = Txt_Cin.Text;
            String nom = Txt_Nom.Text;
            String prenom = Txt_Pren.Text;
            String ville = Txt_Vil.Text;
            String tel = Txt_Tel.Text;
            if (string.IsNullOrEmpty(cin))
            {
                MessageBox.Show("CIN Client invalid");
            }
            else if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Nom Client invalid");
            }
            else if (string.IsNullOrEmpty(prenom))
            {
                MessageBox.Show("Prenom Client invalid");
            }
            else if (string.IsNullOrEmpty(ville))
            {
                MessageBox.Show("Ville Client invalid");
            }
            else if (string.IsNullOrEmpty(tel))
            {
                MessageBox.Show("Téléphone Client invalid");
            }
            else
            {
                Client cl = new Client
                {
                    CIN_Cl = int.Parse(cin),
                    Nom_Cl = nom,
                    Pren_Cl = prenom,
                    Ville_Cl = ville,
                    Tel_Cl = tel
                };
                ClientADO.Modifier(cl);
                Dg_Clt.DataSource = ClientADO.Liste_Client();
                MessageBox.Show("Client et à jour");

            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Cin.Text))
            {
                Client cl = ClientADO.Recherche_cin(int.Parse(Txt_Cin.Text));
                if (cl != null)
                {
                    Txt_Nom.Text = cl.Nom_Cl;
                    Txt_Pren.Text = cl.Pren_Cl;
                    Txt_Tel.Text = cl.Tel_Cl.ToString();
                    Txt_Vil.Text = cl.Ville_Cl;
                }
                else
                    MessageBox.Show("Client inexistant");

            }
            else if (!string.IsNullOrEmpty(Txt_Nom.Text))
                Dg_Clt.DataSource = ClientADO.Recherche_NomPren(Txt_Nom.Text);
            else if (!string.IsNullOrEmpty(Txt_Pren.Text))
                Dg_Clt.DataSource = ClientADO.Recherche_NomPren(Txt_Pren.Text);
            else
                if (!string.IsNullOrEmpty(Txt_Vil.Text))
                Dg_Clt.DataSource = ClientADO.Recherche_ville(Txt_Vil.Text);

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            String cin = Txt_Cin.Text;
            String nom = Txt_Nom.Text;
            String prenom = Txt_Pren.Text;
            String ville = Txt_Vil.Text;
            String tel = Txt_Tel.Text;
            if (string.IsNullOrEmpty(cin))
            {
                MessageBox.Show("CIN Client invalid");
            }
            else if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Nom Client invalid");
            }
            else if (string.IsNullOrEmpty(prenom))
            {
                MessageBox.Show("Prenom Client invalid");
            }
            else if (string.IsNullOrEmpty(ville))
            {
                MessageBox.Show("Ville Client invalid");
            }
            else if (string.IsNullOrEmpty(tel))
            {
                MessageBox.Show("Téléphone Client invalid");
            }
            else
            {
                Client cl = new Client
                {
                    CIN_Cl = int.Parse(cin),
                    Nom_Cl = nom,
                    Pren_Cl = prenom,
                    Ville_Cl = ville,
                    Tel_Cl = tel
                };
                ClientADO.Inserer(cl);
                Dg_Clt.DataSource = ClientADO.Liste_Client();

            }
        }

        private void Dg_Clt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            String cin = Dg_Clt.Rows[index].Cells[0].Value.ToString();
            String nom = Dg_Clt.Rows[index].Cells[1].Value.ToString();
            String prenom = Dg_Clt.Rows[index].Cells[2].Value.ToString();
            String ville = Dg_Clt.Rows[index].Cells[3].Value.ToString();
            String tel = Dg_Clt.Rows[index].Cells[4].Value.ToString();
            if (!string.IsNullOrEmpty(cin))
            {
                Txt_Cin.Text = cin;
                this.selectedClient.CIN_Cl = int.Parse(cin);
            }
            if (!string.IsNullOrEmpty(nom))
            {
                Txt_Nom.Text = nom;
                this.selectedClient.Nom_Cl = nom;
            }

            if (!string.IsNullOrEmpty(prenom))
            {
                Txt_Pren.Text = prenom;
                this.selectedClient.Pren_Cl = prenom;
            }

            if (!string.IsNullOrEmpty(ville))
            {
                Txt_Vil.Text = ville;
                this.selectedClient.Ville_Cl = ville;
            }

            if (!string.IsNullOrEmpty(tel))
            {
                Txt_Tel.Text = tel;
                this.selectedClient.Tel_Cl = tel;
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Txt_Cin.Text))
            {
                int cin = int.Parse(Txt_Cin.Text);
                DialogResult dialogResult = MessageBox.Show("Vous été sur de supprimer le client " + this.selectedClient.Nom_Cl + " " + this.selectedClient.Pren_Cl, "Supprimer client" , MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ClientADO.Supprimer(cin);
                    Dg_Clt.DataSource = ClientADO.Liste_Client();
                    MessageBox.Show("Client supprimer avec succées!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            } else
            {
                MessageBox.Show("Selectionné un client");
            }

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
