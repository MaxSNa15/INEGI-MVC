using INEGI.src.databases;
using INEGI.src.models;
using INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerDash
    {
        private QueryProce qyProce;
        private FrmDash vwDash;
        // Variables
        private List<string>? vivienda;
        private List<int>? actividad;
        private List<string>? producto;
        private List<int>? cantidad;


        public ControllerDash(QueryProce qyProce, FrmDash vwDash)
        {
            this.qyProce = qyProce;
            this.vwDash = vwDash;
            // Eventos
            this.vwDash.Load += new EventHandler(Load);
            this.vwDash.btnClose.Click += new EventHandler(Close);
        }

        private void Load(object? sender, EventArgs e)
        {
            Grafiti();
            Bacterita();
        }
        

        private void Grafiti()
        {
            var result = qyProce.ActVivi();
            vivienda = result.vivienda;
            actividad = result.actividad;

            vwDash.charActVivi.Series[0].Points.DataBindXY(vivienda, actividad);
        }

        private void Bacterita()
        {
            var result = qyProce.Promedio();
            producto = result.producto;
            cantidad = result.cantidad;

            vwDash.chartHabiVivi.Series[0].Points.DataBindXY(producto, cantidad);
        }

        private void Close(object? sender, EventArgs e)
        {
            vwDash.Close();
        }
    }
}