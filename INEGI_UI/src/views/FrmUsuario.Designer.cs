namespace INEGI.src.views
{
    partial class FrmUsuario
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
            btnActHab = new Button();
            dgvUsuarios = new DataGridView();
            txtID = new TextBox();
            lblID = new Label();
            txtNick = new TextBox();
            lblNick = new Label();
            txtPass = new TextBox();
            lblPass = new Label();
            txtFirst = new TextBox();
            lblFirst = new Label();
            txtLast = new TextBox();
            lblLast = new Label();
            btnReg = new Button();
            btnMod = new Button();
            btnBus = new Button();
            btnElim = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(303, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(298, 36);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de Usuarios";
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
            // btnActHab
            // 
            btnActHab.BackColor = SystemColors.ActiveCaption;
            btnActHab.Cursor = Cursors.Hand;
            btnActHab.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnActHab.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnActHab.FlatStyle = FlatStyle.Popup;
            btnActHab.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnActHab.Location = new Point(12, 46);
            btnActHab.Name = "btnActHab";
            btnActHab.Size = new Size(101, 24);
            btnActHab.TabIndex = 24;
            btnActHab.Text = "ACTUALIZAR";
            btnActHab.UseVisualStyleBackColor = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 76);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(680, 401);
            dgvUsuarios.TabIndex = 25;
            // 
            // txtID
            // 
            txtID.Location = new Point(700, 138);
            txtID.Name = "txtID";
            txtID.Size = new Size(212, 23);
            txtID.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(700, 114);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 21);
            lblID.TabIndex = 26;
            lblID.Text = "ID:";
            // 
            // txtNick
            // 
            txtNick.Location = new Point(700, 188);
            txtNick.Name = "txtNick";
            txtNick.Size = new Size(212, 23);
            txtNick.TabIndex = 1;
            // 
            // lblNick
            // 
            lblNick.AutoSize = true;
            lblNick.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNick.Location = new Point(700, 164);
            lblNick.Name = "lblNick";
            lblNick.Size = new Size(93, 21);
            lblNick.TabIndex = 28;
            lblNick.Text = "Nickname:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(700, 238);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(212, 23);
            txtPass.TabIndex = 2;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPass.Location = new Point(700, 214);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(107, 21);
            lblPass.TabIndex = 30;
            lblPass.Text = "Contraseña:";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(700, 288);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(212, 23);
            txtFirst.TabIndex = 3;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirst.Location = new Point(700, 264);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(77, 21);
            lblFirst.TabIndex = 32;
            lblFirst.Text = "Nombre:";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(700, 338);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(212, 23);
            txtLast.TabIndex = 4;
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLast.Location = new Point(700, 314);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(78, 21);
            lblLast.TabIndex = 34;
            lblLast.Text = "Apellido:";
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.FromArgb(128, 255, 128);
            btnReg.FlatAppearance.BorderSize = 0;
            btnReg.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnReg.Location = new Point(12, 483);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(155, 42);
            btnReg.TabIndex = 5;
            btnReg.Text = "REGISTRAR";
            btnReg.UseVisualStyleBackColor = false;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.FromArgb(192, 192, 255);
            btnMod.FlatAppearance.BorderSize = 0;
            btnMod.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMod.Location = new Point(173, 483);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(155, 42);
            btnMod.TabIndex = 6;
            btnMod.Text = "MODIFICAR";
            btnMod.UseVisualStyleBackColor = false;
            // 
            // btnBus
            // 
            btnBus.BackColor = Color.FromArgb(255, 192, 128);
            btnBus.FlatAppearance.BorderSize = 0;
            btnBus.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBus.Location = new Point(757, 367);
            btnBus.Name = "btnBus";
            btnBus.Size = new Size(155, 42);
            btnBus.TabIndex = 7;
            btnBus.Text = "BUSCAR";
            btnBus.UseVisualStyleBackColor = false;
            // 
            // btnElim
            // 
            btnElim.BackColor = Color.FromArgb(255, 128, 128);
            btnElim.FlatAppearance.BorderSize = 0;
            btnElim.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnElim.Location = new Point(334, 483);
            btnElim.Name = "btnElim";
            btnElim.Size = new Size(155, 42);
            btnElim.TabIndex = 8;
            btnElim.Text = "ELIMINAR";
            btnElim.UseVisualStyleBackColor = false;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 610);
            Controls.Add(btnElim);
            Controls.Add(btnBus);
            Controls.Add(btnMod);
            Controls.Add(btnReg);
            Controls.Add(txtLast);
            Controls.Add(lblLast);
            Controls.Add(txtFirst);
            Controls.Add(lblFirst);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(txtNick);
            Controls.Add(lblNick);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnActHab);
            Controls.Add(btnClose);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(150, 150);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        public Button btnClose;
        public Button btnActHab;
        public TextBox txtID;
        private Label lblID;
        public TextBox txtNick;
        private Label lblNick;
        public TextBox txtPass;
        private Label lblPass;
        public TextBox txtFirst;
        private Label lblFirst;
        public TextBox txtLast;
        private Label lblLast;
        public DataGridView dgvUsuarios;
        public Button btnReg;
        public Button btnMod;
        public Button btnBus;
        public Button btnElim;
    }
}