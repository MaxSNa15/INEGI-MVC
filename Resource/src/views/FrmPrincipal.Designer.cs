namespace INEGI.src.views
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlPrincipal = new Panel();
            pnlForms = new Panel();
            pictureBox1 = new PictureBox();
            pnlMenu = new Panel();
            btnDash = new Button();
            btnOut = new Button();
            btnUsu = new Button();
            pnlInfo = new Panel();
            lblLast = new Label();
            lblFirst = new Label();
            pcbUser = new PictureBox();
            btnAct = new Button();
            btnHab = new Button();
            btnVivi = new Button();
            pnlTitulo = new Panel();
            pcbClose = new PictureBox();
            pnlPrincipal.SuspendLayout();
            pnlForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMenu.SuspendLayout();
            pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUser).BeginInit();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbClose).BeginInit();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.FromArgb(51, 149, 214);
            pnlPrincipal.Controls.Add(pnlForms);
            pnlPrincipal.Controls.Add(pnlMenu);
            pnlPrincipal.Controls.Add(pnlTitulo);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1160, 650);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlForms
            // 
            pnlForms.BackColor = Color.Snow;
            pnlForms.Controls.Add(pictureBox1);
            pnlForms.Dock = DockStyle.Fill;
            pnlForms.Location = new Point(200, 40);
            pnlForms.Name = "pnlForms";
            pnlForms.Size = new Size(960, 610);
            pnlForms.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(960, 610);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(4, 41, 68);
            pnlMenu.Controls.Add(btnDash);
            pnlMenu.Controls.Add(btnOut);
            pnlMenu.Controls.Add(btnUsu);
            pnlMenu.Controls.Add(pnlInfo);
            pnlMenu.Controls.Add(btnAct);
            pnlMenu.Controls.Add(btnHab);
            pnlMenu.Controls.Add(btnVivi);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 40);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 610);
            pnlMenu.TabIndex = 1;
            // 
            // btnDash
            // 
            btnDash.FlatAppearance.BorderSize = 0;
            btnDash.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 70);
            btnDash.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDash.ForeColor = Color.Gainsboro;
            btnDash.Location = new Point(12, 385);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(182, 39);
            btnDash.TabIndex = 5;
            btnDash.Text = "Dashboard";
            btnDash.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            btnOut.FlatAppearance.BorderSize = 0;
            btnOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 70);
            btnOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOut.ForeColor = Color.White;
            btnOut.Location = new Point(12, 559);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(182, 39);
            btnOut.TabIndex = 4;
            btnOut.Text = "LOG OUT";
            btnOut.UseVisualStyleBackColor = true;
            // 
            // btnUsu
            // 
            btnUsu.FlatAppearance.BorderSize = 0;
            btnUsu.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 70);
            btnUsu.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnUsu.FlatStyle = FlatStyle.Flat;
            btnUsu.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsu.ForeColor = Color.Gainsboro;
            btnUsu.Location = new Point(12, 338);
            btnUsu.Name = "btnUsu";
            btnUsu.Size = new Size(182, 39);
            btnUsu.TabIndex = 3;
            btnUsu.Text = "Usuarios";
            btnUsu.UseVisualStyleBackColor = true;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(30, 46, 67);
            pnlInfo.Controls.Add(lblLast);
            pnlInfo.Controls.Add(lblFirst);
            pnlInfo.Controls.Add(pcbUser);
            pnlInfo.Dock = DockStyle.Top;
            pnlInfo.Location = new Point(0, 0);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(200, 168);
            pnlInfo.TabIndex = 3;
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLast.ForeColor = Color.WhiteSmoke;
            lblLast.Location = new Point(24, 133);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(155, 25);
            lblLast.TabIndex = 2;
            lblLast.Text = "Administrador";
            lblLast.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirst.ForeColor = Color.WhiteSmoke;
            lblFirst.Location = new Point(24, 99);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(155, 25);
            lblFirst.TabIndex = 1;
            lblFirst.Text = "Administrador";
            lblFirst.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcbUser
            // 
            pcbUser.Image = (Image)resources.GetObject("pcbUser.Image");
            pcbUser.Location = new Point(59, 6);
            pcbUser.Name = "pcbUser";
            pcbUser.Size = new Size(80, 80);
            pcbUser.SizeMode = PictureBoxSizeMode.Zoom;
            pcbUser.TabIndex = 0;
            pcbUser.TabStop = false;
            // 
            // btnAct
            // 
            btnAct.FlatAppearance.BorderSize = 0;
            btnAct.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 70);
            btnAct.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnAct.FlatStyle = FlatStyle.Flat;
            btnAct.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAct.ForeColor = Color.Gainsboro;
            btnAct.Location = new Point(12, 291);
            btnAct.Name = "btnAct";
            btnAct.Size = new Size(182, 39);
            btnAct.TabIndex = 2;
            btnAct.Text = "Actividad Economica";
            btnAct.UseVisualStyleBackColor = true;
            // 
            // btnHab
            // 
            btnHab.FlatAppearance.BorderSize = 0;
            btnHab.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 70);
            btnHab.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnHab.FlatStyle = FlatStyle.Flat;
            btnHab.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHab.ForeColor = Color.Gainsboro;
            btnHab.Location = new Point(12, 244);
            btnHab.Name = "btnHab";
            btnHab.Size = new Size(182, 39);
            btnHab.TabIndex = 1;
            btnHab.Text = "Habitantes";
            btnHab.UseVisualStyleBackColor = true;
            // 
            // btnVivi
            // 
            btnVivi.FlatAppearance.BorderSize = 0;
            btnVivi.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 70);
            btnVivi.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnVivi.FlatStyle = FlatStyle.Flat;
            btnVivi.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVivi.ForeColor = Color.Gainsboro;
            btnVivi.Location = new Point(12, 197);
            btnVivi.Name = "btnVivi";
            btnVivi.Size = new Size(182, 39);
            btnVivi.TabIndex = 0;
            btnVivi.Text = "Viviendas";
            btnVivi.UseVisualStyleBackColor = true;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(0, 85, 143);
            pnlTitulo.Controls.Add(pcbClose);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1160, 40);
            pnlTitulo.TabIndex = 0;
            // 
            // pcbClose
            // 
            pcbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbClose.Cursor = Cursors.Hand;
            pcbClose.Image = (Image)resources.GetObject("pcbClose.Image");
            pcbClose.Location = new Point(1124, 10);
            pcbClose.Name = "pcbClose";
            pcbClose.Size = new Size(24, 24);
            pcbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pcbClose.TabIndex = 0;
            pcbClose.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 650);
            Controls.Add(pnlPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(650, 650);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            pnlPrincipal.ResumeLayout(false);
            pnlForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUser).EndInit();
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbClose).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public PictureBox pcbClose;
        public Button btnVivi;
        public Button btnAct;
        public Button btnHab;
        public Panel pnlPrincipal;
        public Panel pnlTitulo;
        public Panel pnlForms;
        public Panel pnlMenu;
        private PictureBox pictureBox1;
        private PictureBox pcbUser;
        public Panel pnlInfo;
        public Button btnUsu;
        public Button btnOut;
        public Label lblLast;
        public Label lblFirst;
        public Button btnDash;
    }
}