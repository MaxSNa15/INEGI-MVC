using INEGI.src.controllers;
using INEGI.src.databases;
using INEGI.src.models;

namespace INEGI.src.views
{
    public partial class FrmUsuario : Form
    {
        private ControllerUser ctrlUser;
        private ModelUser mdUser;
        private QueryUser qyUser;

        public FrmUsuario()
        {
            InitializeComponent();
            // Instancia
            mdUser = new ModelUser();
            qyUser = new QueryUser();
            // Instancia del controlador
            ctrlUser = new ControllerUser(mdUser, qyUser, this);
        }
    }
}
