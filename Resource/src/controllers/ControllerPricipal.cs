using INEGI.src.databases;
using INEGI.src.models;
using INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerPricipal
    {
        private QueryUser qyUser;
        private ModelUser mdUser;
        private FrmPrincipal vwPrincipal;


        public ControllerPricipal(QueryUser qyUser ,ModelUser mdUser, FrmPrincipal vwPrincipal)
        {
            this.qyUser = qyUser;
            this.mdUser = mdUser;
            this.vwPrincipal = vwPrincipal;
            // Eventos
            this.vwPrincipal.Load += new EventHandler(LoadForm);
            this.vwPrincipal.pcbClose.Click += new EventHandler(Close);
            this.vwPrincipal.btnVivi.Click += new EventHandler(OpenVivienda);
            this.vwPrincipal.btnHab.Click += new EventHandler(OpenHabitante);
            this.vwPrincipal.btnAct.Click += new EventHandler(OpenActividad);
            this.vwPrincipal.btnUsu.Click += new EventHandler(OpenUsuario);
            this.vwPrincipal.btnDash.Click += new EventHandler(OpenDashboard);
            this.vwPrincipal.btnOut.Click += new EventHandler(Logout);
        }

        private void LoadForm(object? sender, EventArgs e)
        {
            
            vwPrincipal.lblFirst.Text = qyUser.GetFullName(mdUser.nickname!)[0];
            vwPrincipal.lblLast.Text = qyUser.GetFullName(mdUser.nickname!)[1];
        }

        #region Menu Izquierdo
        // METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void OpenForm<MyForm>()where MyForm :Form,new() // METODO GENERICO, con condiciones de que sea un formulario y que tenga un constructor vacio
        {
            Form formulario; // Variable de tipo formulario
            formulario = vwPrincipal.pnlForms.Controls.OfType<MyForm>().FirstOrDefault()!; // Busca en el panel si existe un formulario del tipo MyForm, si no existe crea una nueva instancia
            if(formulario == null) // si el formulario no existe
            {
                formulario = new MyForm // Crea una instancia del formulario
                {
                    TopLevel = false, // Indica que el formulario no es de nivel superior
                    FormBorderStyle = FormBorderStyle.None, // Indica que el formulario no tiene borde
                    Dock = DockStyle.Fill // Indica que el formulario se ajusta al tamaño del panel
                }; 
                vwPrincipal.pnlForms.Controls.Add(formulario); // Agrega el formulario al panel
                vwPrincipal.pnlForms.Tag = formulario; // Asigna el formulario al panel
                formulario.Show(); // Muestra el formulario
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms); // Evento para cerrar el formulario
            }
            else
            {
                formulario.BringToFront(); // Si el formulario existe lo trae al frente
            }
        }

        private void OpenVivienda(object? sender, EventArgs e)
        {
            OpenForm<FrmVivienda>();
            vwPrincipal.btnVivi.BackColor = Color.FromArgb(12,61,92);
        }

        private void OpenHabitante(object? sender, EventArgs e)
        {
            OpenForm<FrmHabitante>();
            vwPrincipal.btnHab.BackColor = Color.FromArgb(12,61,92);
        }

        private void OpenActividad(object? sender, EventArgs e)
        {
            OpenForm<FrmActividad>();
            vwPrincipal.btnAct.BackColor = Color.FromArgb(12,61,92);
        }

        private void OpenUsuario(object? sender, EventArgs e)
        {
            OpenForm<FrmUsuario>();
            vwPrincipal.btnUsu.BackColor = Color.FromArgb(12,61,92);
        }

        private void OpenDashboard(object? sender, EventArgs e)
        {
            OpenForm<FrmDash>();
            vwPrincipal.btnDash.BackColor = Color.FromArgb(12,61,92);
        }

        private void CloseForms(object? sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms["FrmVivienda"] == null)
            {
                vwPrincipal.btnVivi.BackColor = Color.FromArgb(4,41,68);
            }
            if(Application.OpenForms["FrmHabitante"] == null)
            {
                vwPrincipal.btnHab.BackColor = Color.FromArgb(4,41,68);
            }
            if(Application.OpenForms["FrmActividad"] == null)
            {
                vwPrincipal.btnAct.BackColor = Color.FromArgb(4,41,68);
            }
            if(Application.OpenForms["FrmUsuario"] == null)
            {
                vwPrincipal.btnUsu.BackColor = Color.FromArgb(4,41,68);
            }
            if(Application.OpenForms["FrmDash"] == null)
            {
                vwPrincipal.btnDash.BackColor = Color.FromArgb(4,41,68);
            }
        }
        #endregion

        private void Logout(object? sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vwPrincipal.Close();
            }
        }

        private void Close(object? sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void RunForm()
        {
            vwPrincipal.ShowDialog();
        }
    }
}