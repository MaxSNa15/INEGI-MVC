using INEGI.src.controllers;

namespace INEGI.src.views
{
    public partial class FrmActividad : Form
    {
        private ControllerActividad ctrlAct;

        public FrmActividad()
        {
            InitializeComponent();
            // Instancia del controlador
            ctrlAct = new ControllerActividad(this);
        }
    }
}
