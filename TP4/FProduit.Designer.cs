
namespace TP4
{
    partial class FProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProduit));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Ref = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Desig = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Cmb_Categ = new MetroFramework.Controls.MetroComboBox();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_ClientDataSet = new TP4.Bd_ClientDataSet();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Prix = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Qte = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Enregistrer = new MetroFramework.Controls.MetroButton();
            this.produitTableAdapter = new TP4.Bd_ClientDataSetTableAdapters.ProduitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ClientDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(71, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Référence";
            // 
            // Txt_Ref
            // 
            // 
            // 
            // 
            this.Txt_Ref.CustomButton.Image = null;
            this.Txt_Ref.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.Txt_Ref.CustomButton.Name = "";
            this.Txt_Ref.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Ref.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Ref.CustomButton.TabIndex = 1;
            this.Txt_Ref.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Ref.CustomButton.UseSelectable = true;
            this.Txt_Ref.CustomButton.Visible = false;
            this.Txt_Ref.Lines = new string[0];
            this.Txt_Ref.Location = new System.Drawing.Point(163, 86);
            this.Txt_Ref.MaxLength = 32767;
            this.Txt_Ref.Name = "Txt_Ref";
            this.Txt_Ref.PasswordChar = '\0';
            this.Txt_Ref.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Ref.SelectedText = "";
            this.Txt_Ref.SelectionLength = 0;
            this.Txt_Ref.SelectionStart = 0;
            this.Txt_Ref.ShortcutsEnabled = true;
            this.Txt_Ref.Size = new System.Drawing.Size(121, 23);
            this.Txt_Ref.TabIndex = 1;
            this.Txt_Ref.UseSelectable = true;
            this.Txt_Ref.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Ref.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Desig
            // 
            // 
            // 
            // 
            this.Txt_Desig.CustomButton.Image = null;
            this.Txt_Desig.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.Txt_Desig.CustomButton.Name = "";
            this.Txt_Desig.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Desig.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Desig.CustomButton.TabIndex = 1;
            this.Txt_Desig.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Desig.CustomButton.UseSelectable = true;
            this.Txt_Desig.CustomButton.Visible = false;
            this.Txt_Desig.Lines = new string[0];
            this.Txt_Desig.Location = new System.Drawing.Point(163, 124);
            this.Txt_Desig.MaxLength = 32767;
            this.Txt_Desig.Name = "Txt_Desig";
            this.Txt_Desig.PasswordChar = '\0';
            this.Txt_Desig.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Desig.SelectedText = "";
            this.Txt_Desig.SelectionLength = 0;
            this.Txt_Desig.SelectionStart = 0;
            this.Txt_Desig.ShortcutsEnabled = true;
            this.Txt_Desig.Size = new System.Drawing.Size(121, 23);
            this.Txt_Desig.TabIndex = 3;
            this.Txt_Desig.UseSelectable = true;
            this.Txt_Desig.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Desig.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(71, 165);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Catégorie";
            // 
            // Cmb_Categ
            // 
            this.Cmb_Categ.DataSource = this.produitBindingSource;
            this.Cmb_Categ.DisplayMember = "Categ_Prod";
            this.Cmb_Categ.FormattingEnabled = true;
            this.Cmb_Categ.ItemHeight = 23;
            this.Cmb_Categ.Location = new System.Drawing.Point(163, 162);
            this.Cmb_Categ.Name = "Cmb_Categ";
            this.Cmb_Categ.Size = new System.Drawing.Size(121, 29);
            this.Cmb_Categ.TabIndex = 5;
            this.Cmb_Categ.UseSelectable = true;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.bd_ClientDataSet;
            // 
            // bd_ClientDataSet
            // 
            this.bd_ClientDataSet.DataSetName = "Bd_ClientDataSet";
            this.bd_ClientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(61, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Désignation";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(52, 206);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Prix de Vente";
            // 
            // Txt_Prix
            // 
            // 
            // 
            // 
            this.Txt_Prix.CustomButton.Image = null;
            this.Txt_Prix.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.Txt_Prix.CustomButton.Name = "";
            this.Txt_Prix.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Prix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Prix.CustomButton.TabIndex = 1;
            this.Txt_Prix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Prix.CustomButton.UseSelectable = true;
            this.Txt_Prix.CustomButton.Visible = false;
            this.Txt_Prix.Lines = new string[0];
            this.Txt_Prix.Location = new System.Drawing.Point(163, 206);
            this.Txt_Prix.MaxLength = 32767;
            this.Txt_Prix.Name = "Txt_Prix";
            this.Txt_Prix.PasswordChar = '\0';
            this.Txt_Prix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Prix.SelectedText = "";
            this.Txt_Prix.SelectionLength = 0;
            this.Txt_Prix.SelectionStart = 0;
            this.Txt_Prix.ShortcutsEnabled = true;
            this.Txt_Prix.Size = new System.Drawing.Size(120, 23);
            this.Txt_Prix.TabIndex = 8;
            this.Txt_Prix.UseSelectable = true;
            this.Txt_Prix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Prix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(54, 244);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Qté en Stock";
            // 
            // Txt_Qte
            // 
            // 
            // 
            // 
            this.Txt_Qte.CustomButton.Image = null;
            this.Txt_Qte.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.Txt_Qte.CustomButton.Name = "";
            this.Txt_Qte.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Qte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Qte.CustomButton.TabIndex = 1;
            this.Txt_Qte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Qte.CustomButton.UseSelectable = true;
            this.Txt_Qte.CustomButton.Visible = false;
            this.Txt_Qte.Lines = new string[0];
            this.Txt_Qte.Location = new System.Drawing.Point(163, 244);
            this.Txt_Qte.MaxLength = 32767;
            this.Txt_Qte.Name = "Txt_Qte";
            this.Txt_Qte.PasswordChar = '\0';
            this.Txt_Qte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Qte.SelectedText = "";
            this.Txt_Qte.SelectionLength = 0;
            this.Txt_Qte.SelectionStart = 0;
            this.Txt_Qte.ShortcutsEnabled = true;
            this.Txt_Qte.Size = new System.Drawing.Size(121, 23);
            this.Txt_Qte.TabIndex = 10;
            this.Txt_Qte.UseSelectable = true;
            this.Txt_Qte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Qte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Enregistrer.BackgroundImage")));
            this.Btn_Enregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Enregistrer.Location = new System.Drawing.Point(163, 283);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(120, 34);
            this.Btn_Enregistrer.TabIndex = 11;
            this.Btn_Enregistrer.Text = "      Enregistrer";
            this.Btn_Enregistrer.UseSelectable = true;
            this.Btn_Enregistrer.Click += new System.EventHandler(this.Btn_Enregistrer_Click);
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // FProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(340, 347);
            this.Controls.Add(this.Btn_Enregistrer);
            this.Controls.Add(this.Txt_Qte);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.Txt_Prix);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Cmb_Categ);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Txt_Desig);
            this.Controls.Add(this.Txt_Ref);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FProduit";
            this.Text = "Ajout Nouveau Produit";
            this.Load += new System.EventHandler(this.FProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ClientDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Txt_Ref;
        private MetroFramework.Controls.MetroTextBox Txt_Desig;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox Cmb_Categ;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox Txt_Prix;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox Txt_Qte;
        private MetroFramework.Controls.MetroButton Btn_Enregistrer;
        private Bd_ClientDataSet bd_ClientDataSet;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private Bd_ClientDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
    }
}