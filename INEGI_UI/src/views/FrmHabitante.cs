using INEGI.src.controllers;

namespace INEGI.src.views
{
    public partial class FrmHabitante : Form
    {
        private ControllerHabitante ctrlHab;

        public FrmHabitante()
        {
            InitializeComponent();
            // Instancia del controlador
            ctrlHab = new ControllerHabitante(this);
        }
    }
}
