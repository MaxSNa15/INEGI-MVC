namespace INEGI.src.views
{
    partial class FrmVivienda
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
            lblTitulo = new Label();
            btnClose = new Button();
            clbMunicipio = new CheckedListBox();
            btnCon = new Button();
            btnCan = new Button();
            txtNomLoc = new TextBox();
            label2 = new Label();
            grbLocalidad = new GroupBox();
            btnGuaLoc = new Button();
            grbMun = new GroupBox();
            grbVivi = new GroupBox();
            btnGuaViv = new Button();
            clbLocalidad = new CheckedListBox();
            lblLocalidad = new Label();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            txtDire = new TextBox();
            lblDirr = new Label();
            btnLocalidad = new Button();
            btnVivienda = new Button();
            btnSkip = new Button();
            grbLocalidad.SuspendLayout();
            grbMun.SuspendLayout();
            grbVivi.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(329, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(323, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Viviendas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnClose.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(873, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "CERRAR";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // clbMunicipio
            // 
            clbMunicipio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clbMunicipio.FormattingEnabled = true;
            clbMunicipio.Location = new Point(6, 32);
            clbMunicipio.Name = "clbMunicipio";
            clbMunicipio.Size = new Size(319, 158);
            clbMunicipio.TabIndex = 2;
            // 
            // btnCon
            // 
            btnCon.BackColor = Color.FromArgb(192, 255, 192);
            btnCon.FlatAppearance.BorderSize = 0;
            btnCon.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCon.ForeColor = Color.Black;
            btnCon.Location = new Point(331, 164);
            btnCon.Name = "btnCon";
            btnCon.Size = new Size(135, 34);
            btnCon.TabIndex = 4;
            btnCon.Text = "CONTINUAR";
            btnCon.UseVisualStyleBackColor = false;
            btnCon.Visible = false;
            // 
            // btnCan
            // 
            btnCan.BackColor = Color.FromArgb(255, 128, 128);
            btnCan.FlatAppearance.BorderSize = 0;
            btnCan.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCan.ForeColor = Color.Black;
            btnCan.Location = new Point(331, 131);
            btnCan.Name = "btnCan";
            btnCan.Size = new Size(100, 27);
            btnCan.TabIndex = 5;
            btnCan.Text = "CANCELAR";
            btnCan.UseVisualStyleBackColor = false;
            btnCan.Visible = false;
            // 
            // txtNomLoc
            // 
            txtNomLoc.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomLoc.Location = new Point(45, 59);
            txtNomLoc.Name = "txtNomLoc";
            txtNomLoc.Size = new Size(409, 31);
            txtNomLoc.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // grbLocalidad
            // 
            grbLocalidad.Controls.Add(btnGuaLoc);
            grbLocalidad.Controls.Add(txtNomLoc);
            grbLocalidad.Controls.Add(label2);
            grbLocalidad.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            grbLocalidad.Location = new Point(6, 204);
            grbLocalidad.Name = "grbLocalidad";
            grbLocalidad.Size = new Size(460, 158);
            grbLocalidad.TabIndex = 9;
            grbLocalidad.TabStop = false;
            grbLocalidad.Text = "Localidad";
            grbLocalidad.Visible = false;
            // 
            // btnGuaLoc
            // 
            btnGuaLoc.BackColor = Color.FromArgb(128, 255, 128);
            btnGuaLoc.FlatAppearance.BorderSize = 0;
            btnGuaLoc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuaLoc.ForeColor = Color.Black;
            btnGuaLoc.Location = new Point(293, 119);
            btnGuaLoc.Name = "btnGuaLoc";
            btnGuaLoc.Size = new Size(161, 33);
            btnGuaLoc.TabIndex = 10;
            btnGuaLoc.Text = "GUARDAR";
            btnGuaLoc.UseVisualStyleBackColor = false;
            // 
            // grbMun
            // 
            grbMun.Controls.Add(clbMunicipio);
            grbMun.Controls.Add(grbLocalidad);
            grbMun.Controls.Add(btnCon);
            grbMun.Controls.Add(btnCan);
            grbMun.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            grbMun.Location = new Point(12, 80);
            grbMun.Name = "grbMun";
            grbMun.Size = new Size(472, 369);
            grbMun.TabIndex = 10;
            grbMun.TabStop = false;
            grbMun.Text = "Municipio";
            // 
            // grbVivi
            // 
            grbVivi.Controls.Add(btnGuaViv);
            grbVivi.Controls.Add(clbLocalidad);
            grbVivi.Controls.Add(lblLocalidad);
            grbVivi.Controls.Add(cmbTipo);
            grbVivi.Controls.Add(lblTipo);
            grbVivi.Controls.Add(txtDire);
            grbVivi.Controls.Add(lblDirr);
            grbVivi.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            grbVivi.Location = new Point(490, 80);
            grbVivi.Name = "grbVivi";
            grbVivi.Size = new Size(458, 369);
            grbVivi.TabIndex = 11;
            grbVivi.TabStop = false;
            grbVivi.Text = "Viviendas";
            // 
            // btnGuaViv
            // 
            btnGuaViv.BackColor = Color.FromArgb(128, 255, 128);
            btnGuaViv.FlatAppearance.BorderSize = 0;
            btnGuaViv.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuaViv.ForeColor = Color.Black;
            btnGuaViv.Location = new Point(291, 330);
            btnGuaViv.Name = "btnGuaViv";
            btnGuaViv.Size = new Size(161, 33);
            btnGuaViv.TabIndex = 11;
            btnGuaViv.Text = "GUARDAR";
            btnGuaViv.UseVisualStyleBackColor = false;
            btnGuaViv.Visible = false;
            // 
            // clbLocalidad
            // 
            clbLocalidad.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            clbLocalidad.FormattingEnabled = true;
            clbLocalidad.Location = new Point(25, 172);
            clbLocalidad.Name = "clbLocalidad";
            clbLocalidad.Size = new Size(427, 109);
            clbLocalidad.TabIndex = 14;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocalidad.Location = new Point(6, 151);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(91, 21);
            lblLocalidad.TabIndex = 13;
            lblLocalidad.Text = "Localidad:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(25, 116);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(427, 32);
            cmbTipo.TabIndex = 12;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(6, 92);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(46, 21);
            lblTipo.TabIndex = 11;
            lblTipo.Text = "Tipo:";
            // 
            // txtDire
            // 
            txtDire.Location = new Point(25, 56);
            txtDire.Name = "txtDire";
            txtDire.Size = new Size(427, 33);
            txtDire.TabIndex = 10;
            // 
            // lblDirr
            // 
            lblDirr.AutoSize = true;
            lblDirr.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDirr.Location = new Point(6, 32);
            lblDirr.Name = "lblDirr";
            lblDirr.Size = new Size(87, 21);
            lblDirr.TabIndex = 9;
            lblDirr.Text = "Direccion:";
            // 
            // btnLocalidad
            // 
            btnLocalidad.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLocalidad.Location = new Point(359, 478);
            btnLocalidad.Name = "btnLocalidad";
            btnLocalidad.Size = new Size(125, 35);
            btnLocalidad.TabIndex = 12;
            btnLocalidad.Text = "LOCALIDAD";
            btnLocalidad.UseVisualStyleBackColor = true;
            // 
            // btnVivienda
            // 
            btnVivienda.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVivienda.Location = new Point(490, 478);
            btnVivienda.Name = "btnVivienda";
            btnVivienda.Size = new Size(125, 35);
            btnVivienda.TabIndex = 13;
            btnVivienda.Text = "VIVIENDA";
            btnVivienda.UseVisualStyleBackColor = true;
            // 
            // btnSkip
            // 
            btnSkip.BackColor = Color.FromArgb(64, 0, 0);
            btnSkip.FlatAppearance.BorderSize = 0;
            btnSkip.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSkip.ForeColor = Color.White;
            btnSkip.Location = new Point(421, 519);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(125, 35);
            btnSkip.TabIndex = 14;
            btnSkip.Text = "CANCELAR";
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Visible = false;
            // 
            // FrmVivienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 610);
            Controls.Add(btnSkip);
            Controls.Add(btnVivienda);
            Controls.Add(btnLocalidad);
            Controls.Add(grbVivi);
            Controls.Add(grbMun);
            Controls.Add(btnClose);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(150, 150);
            Name = "FrmVivienda";
            Text = "Vivienda";
            grbLocalidad.ResumeLayout(false);
            grbLocalidad.PerformLayout();
            grbMun.ResumeLayout(false);
            grbVivi.ResumeLayout(false);
            grbVivi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        public Button btnClose;
        public CheckedListBox clbMunicipio;
        public Button btnCon;
        public Button btnCan;
        public TextBox txtNomLoc;
        private Label label2;
        public GroupBox grbLocalidad;
        public Button btnGuaLoc;
        public GroupBox grbMun;
        private Label lblTipo;
        private Label lblDirr;
        public ComboBox cmbTipo;
        public TextBox txtDire;
        public CheckedListBox clbLocalidad;
        private Label lblLocalidad;
        public GroupBox grbVivi;
        public Button btnGuaViv;
        public Button btnLocalidad;
        public Button btnVivienda;
        public Button btnSkip;
    }
}