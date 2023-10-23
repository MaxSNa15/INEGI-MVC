namespace INEGI.src.views
{
    partial class FrmHabitante
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
            clbViviendo = new CheckedListBox();
            lblNombre = new Label();
            lblNac = new Label();
            lblGenero = new Label();
            cmbGenero = new ComboBox();
            txtNombre = new TextBox();
            lblVivienda = new Label();
            dtpNac = new DateTimePicker();
            panel1 = new Panel();
            dgvHabitante = new DataGridView();
            btnAgr = new Button();
            btnActu = new Button();
            lblViviInfo = new Label();
            btnCan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHabitante).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(301, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(325, 36);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de habitante";
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
            btnClose.TabIndex = 3;
            btnClose.Text = "CERRAR";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // clbViviendo
            // 
            clbViviendo.FormattingEnabled = true;
            clbViviendo.Location = new Point(301, 125);
            clbViviendo.Name = "clbViviendo";
            clbViviendo.Size = new Size(636, 148);
            clbViviendo.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 21);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // lblNac
            // 
            lblNac.AutoSize = true;
            lblNac.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNac.Location = new Point(12, 153);
            lblNac.Name = "lblNac";
            lblNac.Size = new Size(183, 21);
            lblNac.TabIndex = 11;
            lblNac.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenero.Location = new Point(12, 224);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(73, 21);
            lblGenero.TabIndex = 12;
            lblGenero.Text = "Genero:";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(12, 248);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(212, 23);
            cmbGenero.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(212, 23);
            txtNombre.TabIndex = 15;
            // 
            // lblVivienda
            // 
            lblVivienda.AutoSize = true;
            lblVivienda.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVivienda.Location = new Point(301, 84);
            lblVivienda.Name = "lblVivienda";
            lblVivienda.Size = new Size(89, 21);
            lblVivienda.TabIndex = 16;
            lblVivienda.Text = "Viviendas:";
            // 
            // dtpNac
            // 
            dtpNac.Format = DateTimePickerFormat.Short;
            dtpNac.Location = new Point(12, 177);
            dtpNac.Name = "dtpNac";
            dtpNac.Size = new Size(212, 23);
            dtpNac.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Location = new Point(12, 336);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 5);
            panel1.TabIndex = 18;
            // 
            // dgvHabitante
            // 
            dgvHabitante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabitante.Location = new Point(12, 347);
            dgvHabitante.Name = "dgvHabitante";
            dgvHabitante.RowTemplate.Height = 25;
            dgvHabitante.Size = new Size(925, 177);
            dgvHabitante.TabIndex = 19;
            // 
            // btnAgr
            // 
            btnAgr.BackColor = Color.FromArgb(128, 255, 128);
            btnAgr.Cursor = Cursors.Hand;
            btnAgr.FlatAppearance.BorderSize = 0;
            btnAgr.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgr.Location = new Point(12, 301);
            btnAgr.Name = "btnAgr";
            btnAgr.Size = new Size(144, 29);
            btnAgr.TabIndex = 20;
            btnAgr.Text = "AGREGAR";
            btnAgr.UseVisualStyleBackColor = false;
            // 
            // btnActu
            // 
            btnActu.BackColor = SystemColors.ActiveCaption;
            btnActu.Cursor = Cursors.Hand;
            btnActu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnActu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnActu.FlatStyle = FlatStyle.Popup;
            btnActu.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnActu.Location = new Point(766, 24);
            btnActu.Name = "btnActu";
            btnActu.Size = new Size(101, 24);
            btnActu.TabIndex = 21;
            btnActu.Text = "ACTUALIZAR";
            btnActu.UseVisualStyleBackColor = false;
            // 
            // lblViviInfo
            // 
            lblViviInfo.AutoSize = true;
            lblViviInfo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblViviInfo.Location = new Point(497, 105);
            lblViviInfo.Name = "lblViviInfo";
            lblViviInfo.Size = new Size(289, 17);
            lblViviInfo.TabIndex = 23;
            lblViviInfo.Text = "(Direccion|||Tipo|||Localidad|||Municipio)";
            // 
            // btnCan
            // 
            btnCan.BackColor = Color.Red;
            btnCan.Cursor = Cursors.Hand;
            btnCan.FlatAppearance.BorderSize = 0;
            btnCan.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCan.ForeColor = Color.White;
            btnCan.Location = new Point(838, 90);
            btnCan.Name = "btnCan";
            btnCan.Size = new Size(99, 29);
            btnCan.TabIndex = 24;
            btnCan.Text = "CANCELAR";
            btnCan.UseVisualStyleBackColor = false;
            btnCan.Visible = false;
            // 
            // FrmHabitante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 610);
            Controls.Add(btnCan);
            Controls.Add(lblViviInfo);
            Controls.Add(btnActu);
            Controls.Add(btnAgr);
            Controls.Add(dgvHabitante);
            Controls.Add(panel1);
            Controls.Add(dtpNac);
            Controls.Add(lblVivienda);
            Controls.Add(txtNombre);
            Controls.Add(cmbGenero);
            Controls.Add(lblGenero);
            Controls.Add(lblNac);
            Controls.Add(lblNombre);
            Controls.Add(clbViviendo);
            Controls.Add(btnClose);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(150, 150);
            Name = "FrmHabitante";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvHabitante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        public Button btnClose;
        private Label lblNombre;
        private Label lblNac;
        private Label lblGenero;
        private Label lblVivienda;
        private Panel panel1;
        public TextBox txtNombre;
        public DateTimePicker dtpNac;
        public CheckedListBox clbViviendo;
        public ComboBox cmbGenero;
        public Button btnActu;
        public DataGridView dgvHabitante;
        public Button btnAgr;
        private Label lblViviInfo;
        public Button btnCan;
    }
}