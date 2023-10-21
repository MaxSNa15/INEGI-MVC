namespace INEGI.src.views
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pnlLogo = new Panel();
            pcbLogo = new PictureBox();
            txtNick = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txtPass = new TextBox();
            lblTitle = new Label();
            btnLogin = new Button();
            lnlSalir = new LinkLabel();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(0, 122, 204);
            pnlLogo.Controls.Add(pcbLogo);
            pnlLogo.Dock = DockStyle.Left;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 330);
            pnlLogo.TabIndex = 0;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(12, 63);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(223, 182);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // txtNick
            // 
            txtNick.BackColor = Color.FromArgb(15, 15, 15);
            txtNick.BorderStyle = BorderStyle.None;
            txtNick.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNick.ForeColor = Color.DimGray;
            txtNick.Location = new Point(326, 85);
            txtNick.Name = "txtNick";
            txtNick.PlaceholderText = "Usuario";
            txtNick.Size = new Size(407, 20);
            txtNick.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(326, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 2);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(326, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 2);
            panel2.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(15, 15, 15);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.DimGray;
            txtPass.Location = new Point(326, 139);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(407, 20);
            txtPass.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.DimGray;
            lblTitle.Location = new Point(477, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 36);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = Color.LightGray;
            btnLogin.Location = new Point(326, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(407, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lnlSalir
            // 
            lnlSalir.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            lnlSalir.AutoSize = true;
            lnlSalir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lnlSalir.LinkColor = Color.White;
            lnlSalir.Location = new Point(502, 270);
            lnlSalir.Name = "lnlSalir";
            lnlSalir.Size = new Size(53, 21);
            lnlSalir.TabIndex = 0;
            lnlSalir.TabStop = true;
            lnlSalir.Text = "SALIR";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(lnlSalir);
            Controls.Add(btnLogin);
            Controls.Add(lblTitle);
            Controls.Add(panel2);
            Controls.Add(txtPass);
            Controls.Add(panel1);
            Controls.Add(txtNick);
            Controls.Add(pnlLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLogo;
        public TextBox txtNick;
        private Panel panel1;
        private Panel panel2;
        public TextBox txtPass;
        private Label lblTitle;
        public Button btnLogin;
        public LinkLabel lnlSalir;
        private PictureBox pcbLogo;
    }
}