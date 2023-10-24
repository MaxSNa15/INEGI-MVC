namespace INEGI.src.views
{
    partial class FrmActividad
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
            lblDescripcion = new Label();
            txtDesc = new TextBox();
            btnAgre = new Button();
            panel1 = new Panel();
            btnActHab = new Button();
            clbAct = new CheckedListBox();
            clbVivi = new CheckedListBox();
            lblVivi = new Label();
            lblAct = new Label();
            btnCancelar = new Button();
            btnContinuar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(284, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(324, 36);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de Actividad";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(873, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "CERRAR";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(12, 67);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(104, 21);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(12, 91);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(361, 55);
            txtDesc.TabIndex = 4;
            // 
            // btnAgre
            // 
            btnAgre.BackColor = Color.FromArgb(128, 255, 128);
            btnAgre.FlatAppearance.BorderSize = 0;
            btnAgre.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgre.Location = new Point(391, 120);
            btnAgre.Name = "btnAgre";
            btnAgre.Size = new Size(123, 26);
            btnAgre.TabIndex = 5;
            btnAgre.Text = "AGREGAR";
            btnAgre.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Location = new Point(12, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 5);
            panel1.TabIndex = 19;
            // 
            // btnActHab
            // 
            btnActHab.BackColor = SystemColors.ActiveCaption;
            btnActHab.Cursor = Cursors.Hand;
            btnActHab.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnActHab.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnActHab.FlatStyle = FlatStyle.Popup;
            btnActHab.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnActHab.Location = new Point(836, 163);
            btnActHab.Name = "btnActHab";
            btnActHab.Size = new Size(101, 24);
            btnActHab.TabIndex = 23;
            btnActHab.Text = "ACTUALIZAR";
            btnActHab.UseVisualStyleBackColor = false;
            // 
            // clbAct
            // 
            clbAct.FormattingEnabled = true;
            clbAct.Location = new Point(12, 193);
            clbAct.Name = "clbAct";
            clbAct.Size = new Size(442, 184);
            clbAct.TabIndex = 24;
            // 
            // clbVivi
            // 
            clbVivi.Enabled = false;
            clbVivi.FormattingEnabled = true;
            clbVivi.Location = new Point(492, 193);
            clbVivi.Name = "clbVivi";
            clbVivi.Size = new Size(445, 184);
            clbVivi.TabIndex = 25;
            // 
            // lblVivi
            // 
            lblVivi.AutoSize = true;
            lblVivi.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVivi.Location = new Point(492, 169);
            lblVivi.Name = "lblVivi";
            lblVivi.Size = new Size(89, 21);
            lblVivi.TabIndex = 26;
            lblVivi.Text = "Viviendas:";
            // 
            // lblAct
            // 
            lblAct.AutoSize = true;
            lblAct.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAct.Location = new Point(12, 169);
            lblAct.Name = "lblAct";
            lblAct.Size = new Size(109, 21);
            lblAct.TabIndex = 27;
            lblAct.Text = "Actividades:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(317, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 36);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.FromArgb(128, 255, 128);
            btnContinuar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinuar.Location = new Point(492, 394);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(137, 36);
            btnContinuar.TabIndex = 29;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Visible = false;
            // 
            // FrmActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 610);
            Controls.Add(btnContinuar);
            Controls.Add(btnCancelar);
            Controls.Add(lblAct);
            Controls.Add(lblVivi);
            Controls.Add(clbVivi);
            Controls.Add(clbAct);
            Controls.Add(btnActHab);
            Controls.Add(panel1);
            Controls.Add(btnAgre);
            Controls.Add(txtDesc);
            Controls.Add(lblDescripcion);
            Controls.Add(btnClose);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(150, 150);
            Name = "FrmActividad";
            Text = "Actividad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        public Button btnClose;
        private Label lblDescripcion;
        private Panel panel1;
        public Button btnActHab;
        private Label lblVivi;
        private Label lblAct;
        public TextBox txtDesc;
        public Button btnAgre;
        public CheckedListBox clbAct;
        public CheckedListBox clbVivi;
        public Button btnCancelar;
        public Button btnContinuar;
    }
}