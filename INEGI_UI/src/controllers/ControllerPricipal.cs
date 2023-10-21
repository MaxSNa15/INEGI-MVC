using INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerPricipal
    {
        private FrmPrincipal vwPrincipal;

        public ControllerPricipal(FrmPrincipal vwPrincipal)
        {
            this.vwPrincipal = vwPrincipal;
            // Eventos
            this.vwPrincipal.pcbClose.Click += new EventHandler(Close);
            this.vwPrincipal.btnVivi.Click += new EventHandler(OpenVivienda);
        }

        // METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void OpenForm<MyForm>()where MyForm :Form,new() // METODO GENERICO, con condiciones de que sea un formulario y que tenga un constructor vacio
        {
            Form formulario; // Variable de tipo formulario
            formulario = vwPrincipal.pnlForms.Controls.OfType<MyForm>().FirstOrDefault(); // Busca en el panel si existe un formulario del tipo MyForm, si no existe crea una nueva instancia
            // si el formulario no existe
            if(formulario == null)
            {
                formulario = new MyForm // Crea una instancia del formulario
                {
                    TopLevel = false // Indica que el formulario no es de nivel superior
                }; 
                vwPrincipal.pnlForms.Controls.Add(formulario); // Agrega el formulario al panel
                vwPrincipal.pnlForms.Tag = formulario; // Asigna el formulario al panel
                formulario.Show(); // Muestra el formulario
            }
            else
            {
                formulario.BringToFront(); // Si el formulario existe lo trae al frente
            }
        }

        private void OpenVivienda(object? sender, EventArgs e)
        {
            MessageBox.Show("Vivienda");
            OpenForm<FrmVivienda>();
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