using INEGI.src.controllers;
using INEGI.src.databases;
using INEGI.src.models;
using Org.BouncyCastle.Bcpg.Sig;

namespace INEGI.src.views
{
    public partial class FrmHabitante : Form
    {
        private ControllerHabitante ctrlHab;
        private ModelHabitante mdHabitante;
        private QueryVivienda qyVivienda;
        private QueryHabitante qyHabitante;

        public FrmHabitante()
        {
            InitializeComponent();
            // Instancia las propiedades
            mdHabitante = new ModelHabitante();
            qyVivienda = new QueryVivienda();
            qyHabitante = new QueryHabitante();
            // Instancia del controlador
            ctrlHab = new ControllerHabitante(qyVivienda, qyHabitante, mdHabitante, this);
        }
    }
}
