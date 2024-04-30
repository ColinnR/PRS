namespace PRS.Forms
{
    partial class BD_RespaldoUI
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnRecuperar = new MaterialSkin.Controls.MaterialButton();
            this.button1 = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRuta = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRespaldo = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.Label();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtUser);
            this.materialCard1.Controls.Add(this.btnRecuperar);
            this.materialCard1.Controls.Add(this.materialLabel11);
            this.materialCard1.Controls.Add(this.button1);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.txtRuta);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.btnRespaldo);
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(56, 55);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.Size = new System.Drawing.Size(1273, 628);
            this.materialCard1.TabIndex = 1;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecuperar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRecuperar.Depth = 0;
            this.btnRecuperar.HighEmphasis = true;
            this.btnRecuperar.Icon = null;
            this.btnRecuperar.Location = new System.Drawing.Point(561, 372);
            this.btnRecuperar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRecuperar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRecuperar.Size = new System.Drawing.Size(104, 36);
            this.btnRecuperar.TabIndex = 7;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRecuperar.UseAccentColor = false;
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = global::PRS.Properties.Resources.link;
            this.button1.Location = new System.Drawing.Point(919, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 50);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(228, 306);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Ingrese la ruta:";
            // 
            // txtRuta
            // 
            this.txtRuta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRuta.AnimateReadOnly = false;
            this.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuta.Depth = 0;
            this.txtRuta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRuta.LeadingIcon = null;
            this.txtRuta.Location = new System.Drawing.Point(359, 289);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRuta.MaxLength = 50;
            this.txtRuta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRuta.Multiline = false;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(555, 50);
            this.txtRuta.TabIndex = 4;
            this.txtRuta.Text = "";
            this.txtRuta.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(328, 220);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(518, 41);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Recuperación de la base de datos:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(321, 53);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(594, 41);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Generar respaldo de la base de datos:\r\n";
            // 
            // btnRespaldo
            // 
            this.btnRespaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRespaldo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRespaldo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRespaldo.Depth = 0;
            this.btnRespaldo.HighEmphasis = true;
            this.btnRespaldo.Icon = null;
            this.btnRespaldo.Location = new System.Drawing.Point(571, 113);
            this.btnRespaldo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRespaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRespaldo.Name = "btnRespaldo";
            this.btnRespaldo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRespaldo.Size = new System.Drawing.Size(87, 36);
            this.btnRespaldo.TabIndex = 1;
            this.btnRespaldo.Text = "Generar";
            this.btnRespaldo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRespaldo.UseAccentColor = false;
            this.btnRespaldo.UseVisualStyleBackColor = true;
            this.btnRespaldo.Click += new System.EventHandler(this.btnRespaldo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRS.Properties.Resources.LOGORsize;
            this.pictureBox1.Location = new System.Drawing.Point(521, 436);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 176);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.AutoSize = true;
            this.txtUser.Location = new System.Drawing.Point(1198, 593);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(16, 16);
            this.txtUser.TabIndex = 33;
            this.txtUser.Text = "...";
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel11.Location = new System.Drawing.Point(1117, 588);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(74, 24);
            this.materialLabel11.TabIndex = 32;
            this.materialLabel11.Text = "Usuario:";
            // 
            // BD_RespaldoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 725);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BD_RespaldoUI";
            this.Text = "BD_RespaldoUI";
            this.Load += new System.EventHandler(this.BD_RespaldoUI_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnRespaldo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtRuta;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialButton btnRecuperar;
        private System.Windows.Forms.Label txtUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
    }
}