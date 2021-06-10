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
using ClassBL;

namespace TP4
{
    public partial class FCommande : MetroFramework.Forms.MetroForm
    {
        public LigneCommande lcSelected;
        public Client clSelected;
        public Commande cmdSelected;
        public Produit prSelected;
        public FCommande()
        {
            InitializeComponent();
        }

        private void FCommande_Load(object sender, EventArgs e)
        {
            Affiche_Ligne_Commande();
            Pan_LigC.Visible = false;
        }

        private void Nouv_Cde_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Txt_NumCde.Text))
            {
                MessageBox.Show("Numero commande invalid");
            }
            else if (string.IsNullOrEmpty(Date_Cde.Value.Date.ToString()))
            {
                MessageBox.Show("Date commande invalid");
            }
            else
            {
                int numCmd = int.Parse(Txt_NumCde.Text);
                DateTime dteCmd = Date_Cde.Value.Date;
                Commande commande = CommandeADO.Recherche_Commande_Num_Cde(numCmd);
                if (commande != null)
                {
                    cmdSelected = commande;
                    Pan_LigC.Visible = true;
                    Txt_NumCde.Text = commande.Num_Cde.ToString();
                    Date_Cde.Value = commande.Date_Cde;
                    Client client = ClientADO.Recherche_cin(commande.CIN_Cl);
                    if(client != null)
                    {
                        setClientFields(client);
                        clSelected = client;
                    }


                } else
                {
                    if (string.IsNullOrEmpty(Txt_Cin.Text))
                    {
                        MessageBox.Show("CIN client invalid");
                    }
                    else
                    {
                        int cin = int.Parse(Txt_Cin.Text);
                        Client cl = ClientADO.Recherche_cin(cin);
                        if (cl != null)
                        {
                            setClientFields(cl);
                            clSelected = cl;
                            Commande cmd = new Commande
                            {
                                Num_Cde = numCmd,
                                Date_Cde = dteCmd,
                                CIN_Cl = cin,
                            };
                            CommandeADO.Inserer(cmd);
                            Pan_LigC.Visible = true;
                            cmdSelected = cmd;
                            MessageBox.Show("Commande inserer");

                        }
                        else
                        {
                            MessageBox.Show("Client introuvable");
                        }

                    }
                }
                

            }
        }

        private void Vider_Cde_Click(object sender, EventArgs e)
        {
            Txt_NumCde.Clear();
            Date_Cde.ResetText();
            cmdSelected = null;
        }

        private void Txt_NumCde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (!string.IsNullOrEmpty(Txt_NumCde.Text))
                {
                    int numCmd = int.Parse(Txt_NumCde.Text);
                    Commande cmd = CommandeADO.Recherche_Commande_Num_Cde(numCmd);
                    if (cmd != null)
                    {
                        cmdSelected = cmd;
                        Client cl = ClientADO.Recherche_cin(cmd.CIN_Cl);
                        if (cl != null)
                        {
                            clSelected = cl;
                            setClientFields(cl);
                        }
                        else
                        {
                            MessageBox.Show("Client introuvable");
                        }
                    }
                    else
                    {
                        Nouv_Cde_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Entrer numero de commande");
                }
            }
        }

        private void setClientFields(Client cl)
        {
            Txt_Cin.Text = cl.CIN_Cl.ToString();
            Txt_Nom.Text = cl.Nom_Cl;
            Txt_Pren.Text = cl.Pren_Cl;
            Txt_Vil.Text = cl.Ville_Cl;
            Txt_Tel.Text = cl.Tel_Cl;
        }

        private void Vider_Clt_Click(object sender, EventArgs e)
        {
            Txt_Cin.Clear();
            Txt_Nom.Clear();
            Txt_Pren.Clear();
            Txt_Vil.Clear();
            Txt_Tel.Clear();
            clSelected = null;
        }

        private void Affiche_Ligne_Commande()
        {
            Txt_TotCde.Clear();
            Dg_Prod.Rows.Clear();
            List<LigneCommande> ligneCmd = LigneCommandeADO.Liste_LigneCommande();
            if (ligneCmd != null)
            {
                long totalCmds = 0;
                foreach (LigneCommande lc in ligneCmd)
                {
                    Produit pd = ProduitADO.Recherche_Ref(lc.RefProd);
                    Commande cmd = CommandeADO.Recherche_Commande_Num_Cde(lc.NumCde);
                    // Ref ligcmd | design | prix | quantité | total
                    long totalCmd = pd.PrixV_Prod * lc.Qte;
                    totalCmds += totalCmd;
                    Dg_Prod.Rows.Add(cmd.Num_Cde, pd.Desig_Prod, pd.PrixV_Prod, lc.Qte, totalCmd);
                }
                Txt_TotCde.Text = totalCmds.ToString();
            }
        }

        private void Nouv_Lig_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_NumCde.Text))
            {
                Commande cmd = CommandeADO.Recherche_Commande_Num_Cde(int.Parse(Txt_NumCde.Text));
                if (cmd != null)
                {
                    if (!string.IsNullOrEmpty(Txt_Qte.Text))
                    {
                        FListe_Prod fc = new FListe_Prod();
                        fc.ShowDialog();
                        if (FListe_Prod.produit != null)
                        {
                            prSelected = FListe_Prod.produit;
                            if (prSelected != null)
                            {
                                LigneCommande lc = new LigneCommande
                                {
                                    NumCde = cmd.Num_Cde,
                                    RefProd = prSelected.Ref_Prod,
                                    Qte = int.Parse(Txt_Qte.Text)
                                };
                                LigneCommandeADO.Inserer(lc);
                                Affiche_Ligne_Commande();
                                Vider_Clt_Click(sender, e);
                                Vider_Cde_Click(sender, e);
                                lcSelected = null;
                                prSelected = null;
                                cmdSelected = null;
                                clSelected = null;
                                MessageBox.Show("Ligne Commande inserer");
                            }
                            else
                            {
                                MessageBox.Show("Sélectionner un produit");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sélectionner un produit");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserer une qunatité");
                    }
                }
                else
                {
                    MessageBox.Show("Inserer une commande");
                }
            }
            else
            {
                MessageBox.Show("Inserer une commande");
            }

        }

        private void Nouv_Clt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Cin.Text))
            {
                Client cl = ClientADO.Recherche_cin(int.Parse(Txt_Cin.Text));
                if (cl != null)
                {
                    setClientFields(cl);
                    clSelected = cl;
                }
                else
                {
                    Client client = new Client
                    {
                        CIN_Cl = int.Parse(Txt_Cin.Text),
                        Nom_Cl = Txt_Nom.Text,
                        Pren_Cl = Txt_Pren.Text,
                        Ville_Cl = Txt_Vil.Text,
                        Tel_Cl = Txt_Tel.Text
                    };
                    ClientADO.Inserer(client);
                    clSelected = client;
                    MessageBox.Show("Client ajouté avec succès");
                }
            }
        }

        private void Dg_Prod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int refe = int.Parse(Dg_Prod.Rows[index].Cells[0].Value.ToString());
            String desig = Dg_Prod.Rows[index].Cells[1].Value.ToString();
            int prix = int.Parse(Dg_Prod.Rows[index].Cells[2].Value.ToString());
            int qte = int.Parse(Dg_Prod.Rows[index].Cells[3].Value.ToString());
            int total = int.Parse(Dg_Prod.Rows[index].Cells[4].Value.ToString());
            LigneCommande lc = LigneCommandeADO.LigneCommande(refe);
            if (lc != null)
            {
                lcSelected = lc;
                Txt_Qte.Text = lc.Qte.ToString();
                Commande cmd = CommandeADO.Recherche_Commande_Num_Cde(lc.NumCde);
                if (cmd != null)
                {
                    cmdSelected = cmd;
                    Txt_NumCde.Text = cmd.Num_Cde.ToString();
                    Date_Cde.Text = cmd.Date_Cde.ToString();
                    Client client = ClientADO.Recherche_cin(cmd.CIN_Cl);
                    if (client != null)
                    {
                        setClientFields(client);
                        clSelected = client;
                    }
                }
                Produit pr = ProduitADO.Recherche_Ref(lc.RefProd);
                if (pr != null)
                {
                    prSelected = pr;
                }
            }
        }

        private void Supp_Lig_Click(object sender, EventArgs e)
        {
            if (lcSelected != null)
            {
                DialogResult dialogResult = MessageBox.Show("Vous été sur de supprimer la ligne commande?", "Supprimer ligne commande", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    LigneCommandeADO.Supprimer(lcSelected.NumCde);
                    
                    lcSelected = null;
                    clSelected = null;
                    cmdSelected = null;
                    prSelected = null;
                    Affiche_Ligne_Commande();
                    MessageBox.Show("Ligne commande supprimer avec succès!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                MessageBox.Show("Sélectionner une ligne commande!");
            }
        }

        private void Modif_Lig_Click(object sender, EventArgs e)
        {
            if (lcSelected != null)
            {
                if (prSelected != null)
                {
                    lcSelected.RefProd = prSelected.Ref_Prod;
                }
                if (cmdSelected != null)
                {
                    lcSelected.NumCde = cmdSelected.Num_Cde;
                }
                if (!string.IsNullOrEmpty(Txt_Qte.Text))
                {
                    lcSelected.Qte = int.Parse(Txt_Qte.Text);
                }
                LigneCommandeADO.Modifier(lcSelected);
                Affiche_Ligne_Commande();
                MessageBox.Show("Ligne commande modifié avec succès!");
            }
            else
            {
                MessageBox.Show("Sélectionner une ligne commande!");
            }
        }
    }
}
