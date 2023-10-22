using  INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerActividad
    {
        private FrmActividad vwActividad;

        public ControllerActividad(FrmActividad vwActividad)
        {
            this.vwActividad = vwActividad;
            // Eventos
            this.vwActividad.btnClose.Click += new EventHandler(Close);
        }

        private void Close(object? sender, EventArgs e)
        {
            vwActividad.Close();
        }
    }
}