using INEGI.src.models;
using INEGI.src.databases;
using INEGI.src.controllers;

namespace INEGI.src.views
{
    public partial class FrmVivienda : Form
    {
        private ControllerVivienda ctrlViv;
        private QueryMunicipio qyMunicipio;
        private QueryLocalidad qyLocalidad;
        private QueryVivienda qyVivienda;
        private ModelLocalidad mdLocalidad;
        private ModelVivienda mdVivienda;

        public FrmVivienda()
        {
            InitializeComponent();
            // Instancia las propiedades
            qyMunicipio = new QueryMunicipio();
            qyLocalidad = new QueryLocalidad();
            mdLocalidad = new ModelLocalidad();
            qyVivienda = new QueryVivienda();
            mdVivienda = new ModelVivienda();
            // Instancia del controlador
            ctrlViv = new ControllerVivienda(qyMunicipio, qyLocalidad, qyVivienda, mdLocalidad, mdVivienda, this);
        }

    }
}
