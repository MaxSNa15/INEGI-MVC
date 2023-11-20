using INEGI.src.controllers;
using INEGI.src.databases;
using INEGI.src.models;

namespace INEGI.src.views
{
    public partial class FrmActividad : Form
    {
        private ModelActividad mdActividad;
        private QueryActividad qyActividad;
        private QueryVivienda qyVivienda;
        private ControllerActividad ctrlAct;

        public FrmActividad()
        {
            InitializeComponent();
            // Instancia
            mdActividad = new ModelActividad();
            qyActividad = new QueryActividad();
            qyVivienda = new QueryVivienda();
            // Instancia del controlador
            ctrlAct = new ControllerActividad(mdActividad, qyActividad, qyVivienda, this);
        }
    }
}
