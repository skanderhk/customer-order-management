
namespace TP4
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.TS_Menu = new System.Windows.Forms.ToolStrip();
            this.TS_Btn_Cl = new System.Windows.Forms.ToolStripButton();
            this.TS_Btn_Pr = new System.Windows.Forms.ToolStripButton();
            this.TS_Btn_Cd = new System.Windows.Forms.ToolStripButton();
            this.TS_Btn_Q = new System.Windows.Forms.ToolStripButton();
            this.TS_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TS_Menu
            // 
            this.TS_Menu.BackColor = System.Drawing.Color.White;
            this.TS_Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Menu.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.TS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Btn_Cl,
            this.TS_Btn_Pr,
            this.TS_Btn_Cd,
            this.TS_Btn_Q});
            this.TS_Menu.Location = new System.Drawing.Point(27, 74);
            this.TS_Menu.Name = "TS_Menu";
            this.TS_Menu.Size = new System.Drawing.Size(1029, 91);
            this.TS_Menu.TabIndex = 0;
            this.TS_Menu.Text = "toolStrip1";
            // 
            // TS_Btn_Cl
            // 
            this.TS_Btn_Cl.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Cl.Image")));
            this.TS_Btn_Cl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Cl.Name = "TS_Btn_Cl";
            this.TS_Btn_Cl.Size = new System.Drawing.Size(68, 88);
            this.TS_Btn_Cl.Text = "Clients";
            this.TS_Btn_Cl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TS_Btn_Cl.Click += new System.EventHandler(this.TS_Btn_Cl_Click);
            // 
            // TS_Btn_Pr
            // 
            this.TS_Btn_Pr.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Pr.Image")));
            this.TS_Btn_Pr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Pr.Name = "TS_Btn_Pr";
            this.TS_Btn_Pr.Size = new System.Drawing.Size(68, 88);
            this.TS_Btn_Pr.Text = "Produits";
            this.TS_Btn_Pr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TS_Btn_Pr.Click += new System.EventHandler(this.TS_Btn_Pr_Click);
            // 
            // TS_Btn_Cd
            // 
            this.TS_Btn_Cd.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Cd.Image")));
            this.TS_Btn_Cd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Cd.Name = "TS_Btn_Cd";
            this.TS_Btn_Cd.Size = new System.Drawing.Size(96, 88);
            this.TS_Btn_Cd.Text = "Commandes";
            this.TS_Btn_Cd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TS_Btn_Cd.Click += new System.EventHandler(this.TS_Btn_Cd_Click);
            // 
            // TS_Btn_Q
            // 
            this.TS_Btn_Q.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Q.Image")));
            this.TS_Btn_Q.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Q.Name = "TS_Btn_Q";
            this.TS_Btn_Q.Size = new System.Drawing.Size(68, 88);
            this.TS_Btn_Q.Text = "Quitter";
            this.TS_Btn_Q.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TS_Btn_Q.Click += new System.EventHandler(this.TS_Btn_Q_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 628);
            this.Controls.Add(this.TS_Menu);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FMenu";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Gestion des Commandes Clients";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.TS_Menu.ResumeLayout(false);
            this.TS_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_Menu;
        private System.Windows.Forms.ToolStripButton TS_Btn_Cl;
        private System.Windows.Forms.ToolStripButton TS_Btn_Pr;
        private System.Windows.Forms.ToolStripButton TS_Btn_Cd;
        private System.Windows.Forms.ToolStripButton TS_Btn_Q;
    }
}