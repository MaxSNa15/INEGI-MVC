using  INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerVivienda
    {
        private FrmVivienda vwVivienda;

        public ControllerVivienda(FrmVivienda vwVivienda)
        {
            this.vwVivienda = vwVivienda;
            // Eventos
            this.vwVivienda.btnClose.Click += new EventHandler(Close);
        }

        private void Close(object? sender, EventArgs e)
        {
            vwVivienda.Close();
        }
    }
}