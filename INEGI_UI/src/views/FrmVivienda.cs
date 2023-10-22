using INEGI.src.controllers;

namespace INEGI.src.views
{
    public partial class FrmVivienda : Form
    {
        private ControllerVivienda ctrlViv;

        public FrmVivienda()
        {
            InitializeComponent();
            // Instancia del controlador
            ctrlViv = new ControllerVivienda(this);
        }
    }
}
