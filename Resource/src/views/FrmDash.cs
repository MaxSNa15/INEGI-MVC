using INEGI.src.controllers;
using INEGI.src.databases;
using INEGI.src.models;

namespace INEGI.src.views
{
    public partial class FrmDash : Form
    {
        private QueryProce qyProce;
        private ControllerDash ctrlDash;

        public FrmDash()
        {
            InitializeComponent();
            // Instancia
            qyProce = new QueryProce();
            // Instancia del controlador
            ctrlDash = new ControllerDash(qyProce, this);
        }
    }
}
