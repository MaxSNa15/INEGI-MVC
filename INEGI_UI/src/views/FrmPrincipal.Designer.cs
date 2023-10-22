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
            btnAct = new Button();
            btnHab = new Button();
            btnVivi = new Button();
            pnlTitulo = new Panel();
            pcbClose = new PictureBox();
            pnlPrincipal.SuspendLayout();
            pnlForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMenu.SuspendLayout();
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
            pnlMenu.Controls.Add(btnAct);
            pnlMenu.Controls.Add(btnHab);
            pnlMenu.Controls.Add(btnVivi);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 40);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 610);
            pnlMenu.TabIndex = 1;
            // 
            // btnAct
            // 
            btnAct.FlatAppearance.BorderSize = 0;
            btnAct.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 70);
            btnAct.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnAct.FlatStyle = FlatStyle.Flat;
            btnAct.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAct.ForeColor = Color.Gainsboro;
            btnAct.Location = new Point(12, 248);
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
            btnHab.Location = new Point(12, 189);
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
            btnVivi.Location = new Point(12, 131);
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
    }
}