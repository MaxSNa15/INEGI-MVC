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
            pnlMenu = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnVivi = new Button();
            pnlTitulo = new Panel();
            pcbClose = new PictureBox();
            pnlPrincipal.SuspendLayout();
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
            pnlForms.Dock = DockStyle.Fill;
            pnlForms.Location = new Point(200, 40);
            pnlForms.Name = "pnlForms";
            pnlForms.Size = new Size(960, 610);
            pnlForms.TabIndex = 2;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(4, 41, 68);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Controls.Add(button1);
            pnlMenu.Controls.Add(btnVivi);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 40);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 610);
            pnlMenu.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(12, 186);
            button2.Name = "button2";
            button2.Size = new Size(182, 39);
            button2.TabIndex = 2;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 141);
            button1.Name = "button1";
            button1.Size = new Size(182, 39);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnVivi
            // 
            btnVivi.Location = new Point(12, 96);
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
            pnlMenu.ResumeLayout(false);
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbClose).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public PictureBox pcbClose;
        public Button btnVivi;
        public Button button2;
        public Button button1;
        public Panel pnlPrincipal;
        public Panel pnlTitulo;
        public Panel pnlForms;
        public Panel pnlMenu;
    }
}