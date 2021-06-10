
namespace TP4
{
    partial class FListe_Prod
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
            MetroFramework.Controls.MetroLink metroLink5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListe_Prod));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Ref = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Desig = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Cmb_Categ = new MetroFramework.Controls.MetroComboBox();
            this.produitBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bdClientDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_ClientDataSet = new TP4.Bd_ClientDataSet();
            this.Dg_Prod = new MetroFramework.Controls.MetroGrid();
            this.refProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desigProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new TP4.Bd_ClientDataSetTableAdapters.ProduitTableAdapter();
            this.produitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produitBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.bd_ClientDataSet4 = new TP4.Bd_ClientDataSet4();
            this.produitTableAdapter1 = new TP4.Bd_ClientDataSet4TableAdapters.ProduitTableAdapter();
            this.tableAdapterManager = new TP4.Bd_ClientDataSet4TableAdapters.TableAdapterManager();
            this.bdClientDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            metroLink5 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClientDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ClientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ClientDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClientDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLink5
            // 
            metroLink5.Image = ((System.Drawing.Image)(resources.GetObject("metroLink5.Image")));
            metroLink5.ImageSize = 50;
            metroLink5.Location = new System.Drawing.Point(906, 66);
            metroLink5.Name = "metroLink5";
            metroLink5.Size = new System.Drawing.Size(75, 73);
            metroLink5.TabIndex = 14;
            metroLink5.UseSelectable = true;
            metroLink5.Click += new System.EventHandler(this.metroLink5_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(56, 94);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Référence";
            // 
            // Txt_Ref
            // 
            // 
            // 
            // 
            this.Txt_Ref.CustomButton.Image = null;
            this.Txt_Ref.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.Txt_Ref.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Ref.CustomButton.Name = "";
            this.Txt_Ref.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Ref.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Ref.CustomButton.TabIndex = 1;
            this.Txt_Ref.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Ref.CustomButton.UseSelectable = true;
            this.Txt_Ref.CustomButton.Visible = false;
            this.Txt_Ref.Lines = new string[0];
            this.Txt_Ref.Location = new System.Drawing.Point(137, 91);
            this.Txt_Ref.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Ref.MaxLength = 32767;
            this.Txt_Ref.Name = "Txt_Ref";
            this.Txt_Ref.PasswordChar = '\0';
            this.Txt_Ref.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Ref.SelectedText = "";
            this.Txt_Ref.SelectionLength = 0;
            this.Txt_Ref.SelectionStart = 0;
            this.Txt_Ref.ShortcutsEnabled = true;
            this.Txt_Ref.Size = new System.Drawing.Size(135, 28);
            this.Txt_Ref.TabIndex = 1;
            this.Txt_Ref.UseSelectable = true;
            this.Txt_Ref.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Ref.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(300, 97);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Désignation";
            // 
            // Txt_Desig
            // 
            // 
            // 
            // 
            this.Txt_Desig.CustomButton.Image = null;
            this.Txt_Desig.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.Txt_Desig.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Desig.CustomButton.Name = "";
            this.Txt_Desig.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Desig.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Desig.CustomButton.TabIndex = 1;
            this.Txt_Desig.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Desig.CustomButton.UseSelectable = true;
            this.Txt_Desig.CustomButton.Visible = false;
            this.Txt_Desig.Lines = new string[0];
            this.Txt_Desig.Location = new System.Drawing.Point(390, 91);
            this.Txt_Desig.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Desig.MaxLength = 32767;
            this.Txt_Desig.Name = "Txt_Desig";
            this.Txt_Desig.PasswordChar = '\0';
            this.Txt_Desig.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Desig.SelectedText = "";
            this.Txt_Desig.SelectionLength = 0;
            this.Txt_Desig.SelectionStart = 0;
            this.Txt_Desig.ShortcutsEnabled = true;
            this.Txt_Desig.Size = new System.Drawing.Size(146, 28);
            this.Txt_Desig.TabIndex = 3;
            this.Txt_Desig.UseSelectable = true;
            this.Txt_Desig.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Desig.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(579, 99);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Catégorie";
            // 
            // Cmb_Categ
            // 
            this.Cmb_Categ.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produitBindingSource1, "Categ_Prod", true));
            this.Cmb_Categ.DataSource = this.produitBindingSource4;
            this.Cmb_Categ.DisplayMember = "Categ_Prod";
            this.Cmb_Categ.FormattingEnabled = true;
            this.Cmb_Categ.ItemHeight = 24;
            this.Cmb_Categ.Location = new System.Drawing.Point(656, 91);
            this.Cmb_Categ.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Categ.Name = "Cmb_Categ";
            this.Cmb_Categ.Size = new System.Drawing.Size(223, 30);
            this.Cmb_Categ.TabIndex = 5;
            this.Cmb_Categ.UseSelectable = true;
            this.Cmb_Categ.ValueMember = "Categ_Prod";
            this.Cmb_Categ.SelectedIndexChanged += new System.EventHandler(this.Cmb_Categ_SelectedIndexChanged);
            // 
            // produitBindingSource3
            // 
            this.produitBindingSource3.DataMember = "Produit";
            this.produitBindingSource3.DataSource = this.bdClientDataSetBindingSource;
            // 
            // bdClientDataSetBindingSource
            // 
            this.bdClientDataSetBindingSource.DataSource = this.bd_ClientDataSet;
            this.bdClientDataSetBindingSource.Position = 0;
            // 
            // bd_ClientDataSet
            // 
            this.bd_ClientDataSet.DataSetName = "Bd_ClientDataSet";
            this.bd_ClientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dg_Prod
            // 
            this.Dg_Prod.AllowUserToResizeRows = false;
            this.Dg_Prod.AutoGenerateColumns = false;
            this.Dg_Prod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Prod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg_Prod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dg_Prod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Prod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dg_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Prod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refProdDataGridViewTextBoxColumn,
            this.desigProdDataGridViewTextBoxColumn,
            this.categProdDataGridViewTextBoxColumn,
            this.prixVProdDataGridViewTextBoxColumn,
            this.qteStockDataGridViewTextBoxColumn});
            this.Dg_Prod.DataSource = this.produitBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_Prod.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dg_Prod.EnableHeadersVisualStyles = false;
            this.Dg_Prod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dg_Prod.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Prod.Location = new System.Drawing.Point(56, 221);
            this.Dg_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.Dg_Prod.Name = "Dg_Prod";
            this.Dg_Prod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Prod.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dg_Prod.RowHeadersWidth = 51;
            this.Dg_Prod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dg_Prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_Prod.Size = new System.Drawing.Size(903, 283);
            this.Dg_Prod.Style = MetroFramework.MetroColorStyle.Orange;
            this.Dg_Prod.TabIndex = 12;
            this.Dg_Prod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Prod_CellContentClick);
            this.Dg_Prod.DoubleClick += new System.EventHandler(this.Dg_Prod_DoubleClick);
            // 
            // refProdDataGridViewTextBoxColumn
            // 
            this.refProdDataGridViewTextBoxColumn.DataPropertyName = "Ref_Prod";
            this.refProdDataGridViewTextBoxColumn.HeaderText = "Ref_Prod";
            this.refProdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.refProdDataGridViewTextBoxColumn.Name = "refProdDataGridViewTextBoxColumn";
            this.refProdDataGridViewTextBoxColumn.Width = 125;
            // 
            // desigProdDataGridViewTextBoxColumn
            // 
            this.desigProdDataGridViewTextBoxColumn.DataPropertyName = "Desig_Prod";
            this.desigProdDataGridViewTextBoxColumn.HeaderText = "Desig_Prod";
            this.desigProdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.desigProdDataGridViewTextBoxColumn.Name = "desigProdDataGridViewTextBoxColumn";
            this.desigProdDataGridViewTextBoxColumn.Width = 350;
            // 
            // categProdDataGridViewTextBoxColumn
            // 
            this.categProdDataGridViewTextBoxColumn.DataPropertyName = "Categ_Prod";
            this.categProdDataGridViewTextBoxColumn.HeaderText = "Categ_Prod";
            this.categProdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categProdDataGridViewTextBoxColumn.Name = "categProdDataGridViewTextBoxColumn";
            this.categProdDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixVProdDataGridViewTextBoxColumn
            // 
            this.prixVProdDataGridViewTextBoxColumn.DataPropertyName = "PrixV_Prod";
            this.prixVProdDataGridViewTextBoxColumn.HeaderText = "PrixV_Prod";
            this.prixVProdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixVProdDataGridViewTextBoxColumn.Name = "prixVProdDataGridViewTextBoxColumn";
            this.prixVProdDataGridViewTextBoxColumn.Width = 125;
            // 
            // qteStockDataGridViewTextBoxColumn
            // 
            this.qteStockDataGridViewTextBoxColumn.DataPropertyName = "Qte_Stock";
            this.qteStockDataGridViewTextBoxColumn.HeaderText = "Qte_Stock";
            this.qteStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qteStockDataGridViewTextBoxColumn.Name = "qteStockDataGridViewTextBoxColumn";
            this.qteStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.bd_ClientDataSet;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // produitBindingSource1
            // 
            this.produitBindingSource1.DataMember = "Produit";
            this.produitBindingSource1.DataSource = this.bd_ClientDataSet;
            // 
            // produitBindingSource2
            // 
            this.produitBindingSource2.DataMember = "Produit";
            this.produitBindingSource2.DataSource = this.bd_ClientDataSet;
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 50;
            this.metroLink1.Location = new System.Drawing.Point(57, 141);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(80, 73);
            this.metroLink1.TabIndex = 13;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.Image = ((System.Drawing.Image)(resources.GetObject("metroLink2.Image")));
            this.metroLink2.ImageSize = 50;
            this.metroLink2.Location = new System.Drawing.Point(143, 141);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(80, 73);
            this.metroLink2.TabIndex = 13;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLink3
            // 
            this.metroLink3.Image = ((System.Drawing.Image)(resources.GetObject("metroLink3.Image")));
            this.metroLink3.ImageSize = 50;
            this.metroLink3.Location = new System.Drawing.Point(238, 141);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(80, 73);
            this.metroLink3.TabIndex = 13;
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // metroLink4
            // 
            this.metroLink4.Image = ((System.Drawing.Image)(resources.GetObject("metroLink4.Image")));
            this.metroLink4.ImageSize = 50;
            this.metroLink4.Location = new System.Drawing.Point(334, 141);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(80, 73);
            this.metroLink4.TabIndex = 13;
            this.metroLink4.UseSelectable = true;
            this.metroLink4.Click += new System.EventHandler(this.metroLink5_Click);
            // 
            // bd_ClientDataSet4
            // 
            this.bd_ClientDataSet4.DataSetName = "Bd_ClientDataSet4";
            this.bd_ClientDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitTableAdapter1
            // 
            this.produitTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TP4.Bd_ClientDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdClientDataSet4BindingSource
            // 
            this.bdClientDataSet4BindingSource.DataSource = this.bd_ClientDataSet4;
            this.bdClientDataSet4BindingSource.Position = 0;
            // 
            // produitBindingSource4
            // 
            this.produitBindingSource4.DataMember = "Produit";
            this.produitBindingSource4.DataSource = this.bdClientDataSet4BindingSource;
            // 
            // FListe_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 554);
            this.Controls.Add(metroLink5);
            this.Controls.Add(this.metroLink4);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.Dg_Prod);
            this.Controls.Add(this.Cmb_Categ);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Txt_Desig);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Txt_Ref);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FListe_Prod";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Liste des Produits";
            this.Load += new System.EventHandler(this.FListe_Prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClientDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ClientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ClientDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClientDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Txt_Ref;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox Txt_Desig;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox Cmb_Categ;
        private MetroFramework.Controls.MetroGrid Dg_Prod;
        private Bd_ClientDataSet bd_ClientDataSet;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private Bd_ClientDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.BindingSource produitBindingSource2;
        private System.Windows.Forms.BindingSource produitBindingSource1;
        private System.Windows.Forms.BindingSource bdClientDataSetBindingSource;
        private System.Windows.Forms.BindingSource produitBindingSource3;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink metroLink4;
        private System.Windows.Forms.DataGridViewTextBoxColumn refProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desigProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteStockDataGridViewTextBoxColumn;
        private Bd_ClientDataSet4 bd_ClientDataSet4;
        private Bd_ClientDataSet4TableAdapters.ProduitTableAdapter produitTableAdapter1;
        private Bd_ClientDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource produitBindingSource4;
        private System.Windows.Forms.BindingSource bdClientDataSet4BindingSource;
    }
}