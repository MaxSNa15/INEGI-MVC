using  INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerHabitante
    {
        private FrmHabitante vwHabitante;

        public ControllerHabitante(FrmHabitante vwHabitante)
        {
            this.vwHabitante = vwHabitante;
            // Eventos
            this.vwHabitante.btnClose.Click += new EventHandler(Close);
        }

        private void Close(object? sender, EventArgs e)
        {
            vwHabitante.Close();
        }
    }
}