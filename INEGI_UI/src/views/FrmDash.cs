using INEGI.src.controllers;
using INEGI.src.databases;
using INEGI.src.models;

namespace INEGI.src.views
{
    public partial class FrmDash : Form
    {
        private ControllerDash ctrlDash;

        public FrmDash()
        {
            InitializeComponent();
            // Instancia del controlador
            ctrlDash = new ControllerDash(this);
        }
    }
}
