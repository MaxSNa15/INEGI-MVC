using INEGI.src.controllers;

namespace INEGI.src.views
{
    public partial class FrmUsuario : Form
    {
        private ControllerUser ctrlUser;

        public FrmUsuario()
        {
            InitializeComponent();
            // Instancia del controlador
            ctrlUser = new ControllerUser(this);
        }
    }
}
