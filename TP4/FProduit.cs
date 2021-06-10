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
    public partial class FProduit : MetroFramework.Forms.MetroForm
    {
        FListe_Prod form;
        public FProduit(FListe_Prod form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void FProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bd_ClientDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.bd_ClientDataSet.Produit);
            if (FListe_Prod.TypeOP.Equals('M'))
            {
                Txt_Ref.Text = FListe_Prod.produit.Ref_Prod.ToString();
                Txt_Ref.Enabled = false;
                Txt_Desig.Text = FListe_Prod.produit.Desig_Prod.ToString();
                Cmb_Categ.Text = FListe_Prod.produit.Categ_Prod.ToString();
                Txt_Prix.Text = FListe_Prod.produit.PrixV_Prod.ToString();
                Txt_Qte.Text = FListe_Prod.produit.Qte_Stock.ToString();
                
            }

        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {
            int refe = int.Parse(Txt_Ref.Text);
            String desig = Txt_Desig.Text;
            String categ = Cmb_Categ.Text;
            int prix = int.Parse(Txt_Prix.Text);
            int qte = int.Parse(Txt_Qte.Text);
            if (string.IsNullOrEmpty(refe.ToString()))
            {
                MessageBox.Show("Ref produit invalid");
            }
            else if (string.IsNullOrEmpty(desig))
            {
                MessageBox.Show("Designatation produit invalid");
            }
            else if (string.IsNullOrEmpty(categ))
            {
                MessageBox.Show("Choisir une categorie");
            }
            else if (string.IsNullOrEmpty(prix.ToString()))
            {
                MessageBox.Show("Prix produit invalid");
            }
            else if (string.IsNullOrEmpty(qte.ToString()))
            {
                MessageBox.Show("Quantité produit invalid");
            }
            else
            {
                Produit produit = new Produit
                {
                    Ref_Prod = refe,
                    Desig_Prod = desig,
                    Categ_Prod = categ,
                    PrixV_Prod = prix,
                    Qte_Stock = qte
                };
                if (FListe_Prod.TypeOP.Equals('M'))
                {
                    ProduitADO.Modifier(produit);
                } else
                {
                    ProduitADO.Inserer(produit);
                }
                this.form.loadGrid();
                this.Close();   
            }
        }
    }
}
