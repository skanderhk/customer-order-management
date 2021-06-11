using System;
using System.Windows.Forms;
using ClassBL;
using ClassADO;

namespace TP4
{
    public partial class FListe_Prod : MetroFramework.Forms.MetroForm
    {
        private const char add = 'A'; private const char edit = 'M';
        public static Char TypeOP;
        public static Produit produit;
        public FListe_Prod()
        {
            InitializeComponent();
        }

        public void FListe_Prod_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bd_ClientDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.loadGrid();
        }

        public void loadGrid()
        {
            this.produitTableAdapter.Fill(this.bd_ClientDataSet.Produit);
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            TypeOP = add;
            FProduit fc = new FProduit(this);
            fc.Text = "Ajout Nouveau Produit";
            fc.MdiParent = this.ParentForm;
            fc.Show();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            TypeOP = edit;
            if (produit != null)
            {
                FProduit fc = new FProduit(this);
                fc.Text = "Modification de Produit";
                fc.MdiParent = this.ParentForm;
                fc.Show();
            }
            else
            {
                MessageBox.Show("Selectionné un produit!");
            }

        }

        private void Vider_Click(object sender, EventArgs e)
        {
            Txt_Ref.Clear();
            Txt_Desig.Clear();
            if (!string.IsNullOrEmpty(Cmb_Categ.Text))
            {
                Cmb_Categ.SelectedIndex = -1;
            }
            Dg_Prod.DataSource = ProduitADO.Liste_Produit();

        }

        private void Dg_Prod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int refe = int.Parse(Dg_Prod.Rows[index].Cells[0].Value.ToString());
            String desig = Dg_Prod.Rows[index].Cells[1].Value.ToString();
            String categ = Dg_Prod.Rows[index].Cells[2].Value.ToString();
            int prix = int.Parse(Dg_Prod.Rows[index].Cells[3].Value.ToString());
            int qte = int.Parse(Dg_Prod.Rows[index].Cells[4].Value.ToString());
            produit = new Produit
            {
                Ref_Prod = refe,
                Desig_Prod = desig,
                Categ_Prod = categ,
                PrixV_Prod = prix,
                Qte_Stock = qte
            };

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (produit != null)
            {
                DialogResult dialogResult = MessageBox.Show("Vous été sur de supprimer ce produit?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ProduitADO.Supprimer(produit.Ref_Prod);
                    this.produitTableAdapter.Fill(this.bd_ClientDataSet.Produit);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
            else
            {
                MessageBox.Show("Selectionné un produit!");
            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Ref.Text))
            {
                bool prdExist = ProduitADO.Existe_Produit(int.Parse(Txt_Ref.Text));
                if (prdExist != null)
                {
                    Dg_Prod.DataSource = ProduitADO.Liste_Ref(int.Parse(Txt_Ref.Text));
                }
                else
                    MessageBox.Show("Produit inexistant");

            }
            else if (!string.IsNullOrEmpty(Txt_Desig.Text))
                Dg_Prod.DataSource = ProduitADO.Liste_Desig(Txt_Desig.Text);
            else if (!string.IsNullOrEmpty(Cmb_Categ.Text))
                Dg_Prod.DataSource = ProduitADO.Liste_Categ_Prod(Cmb_Categ.Text);
            else
                Dg_Prod.DataSource = ProduitADO.Liste_Produit();
        }

        private void Cmb_Categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Cmb_Categ.Text))
            {
                Dg_Prod.DataSource = ProduitADO.Liste_Categ_Prod(Cmb_Categ.Text);
            }
            else
            {
                Dg_Prod.DataSource = ProduitADO.Liste_Produit();
            }
        }

        private void Dg_Prod_DoubleClick(object sender, EventArgs e)
        {
            int index = Dg_Prod.CurrentRow.Index;
            int refe = int.Parse(Dg_Prod.Rows[index].Cells[0].Value.ToString());
            String desig = Dg_Prod.Rows[index].Cells[1].Value.ToString();
            String categ = Dg_Prod.Rows[index].Cells[2].Value.ToString();
            int prix = int.Parse(Dg_Prod.Rows[index].Cells[3].Value.ToString());
            int qte = int.Parse(Dg_Prod.Rows[index].Cells[4].Value.ToString());
            produit = new Produit
            {
                Ref_Prod = refe,
                Desig_Prod = desig,
                Categ_Prod = categ,
                PrixV_Prod = prix,
                Qte_Stock = qte
            };
            this.Close();
        }
        private void metroLink1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Ref.Text))
            {
                bool prdExist = ProduitADO.Existe_Produit(int.Parse(Txt_Ref.Text));
                if (prdExist != null)
                {
                    Dg_Prod.DataSource = ProduitADO.Liste_Ref(int.Parse(Txt_Ref.Text));
                }
                else
                    MessageBox.Show("Produit inexistant");

            }
            else if (!string.IsNullOrEmpty(Txt_Desig.Text))
                Dg_Prod.DataSource = ProduitADO.Liste_Desig(Txt_Desig.Text);
            else if (!string.IsNullOrEmpty(Cmb_Categ.Text))
                Dg_Prod.DataSource = ProduitADO.Liste_Categ_Prod(Cmb_Categ.Text);
            else
                Dg_Prod.DataSource = ProduitADO.Liste_Produit();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            TypeOP = add;
            FProduit fc = new FProduit(this);
            fc.Text = "Ajout Nouveau Produit";
            fc.MdiParent = this.ParentForm;
            fc.Show();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            if (produit != null)
            {
                DialogResult dialogResult = MessageBox.Show("Vous été sur de supprimer ce produit?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ProduitADO.Supprimer(produit.Ref_Prod);
                    this.produitTableAdapter.Fill(this.bd_ClientDataSet.Produit);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
            else
            {
                MessageBox.Show("Selectionné un produit!");
            }
        }


        private void metroLink5_Click(object sender, EventArgs e)
        {
            TypeOP = edit;
            FProduit fc = new FProduit(this);
            fc.Text = "Modification de Produit";
            fc.MdiParent = this.ParentForm;
            fc.Show();
        }

        private void metroLink5_Click_1(object sender, EventArgs e)
        {
            Txt_Ref.Clear();
            Txt_Desig.Clear();
            if (!string.IsNullOrEmpty(Cmb_Categ.Text))
            {
                Cmb_Categ.SelectedIndex = -1;
            }
            Dg_Prod.DataSource = ProduitADO.Liste_Produit();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produitTableAdapter1.FillBy(this.bd_ClientDataSet4.Produit);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
