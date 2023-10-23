using INEGI.src.databases;
using INEGI.src.models;
using  INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerActividad
    {
        private ModelActividad mdActividad;
        private QueryActividad qyActividad;
        private QueryVivienda qyVivienda;
        private FrmActividad vwActividad;

        public ControllerActividad(ModelActividad mdActividad, QueryActividad qyActividad, QueryVivienda qyVivienda,FrmActividad vwActividad)
        {
            this.mdActividad = mdActividad;
            this.qyActividad = qyActividad;
            this.qyVivienda = qyVivienda;
            this.vwActividad = vwActividad;
            // Eventos
            this.vwActividad.btnClose.Click += new EventHandler(Close);
            this.vwActividad.Load += new EventHandler(Load);
            this.vwActividad.btnAgre.Click += new EventHandler(AddActividad);
            this.vwActividad.btnActHab.Click += new EventHandler(AddActHab);
        }

        private void Actualizar()
        {
            if (vwActividad.clbAct.Items.Count == 0)
            {
                vwActividad.clbAct.Items.AddRange(qyActividad.GetNameActividad().ToArray());
            }
            else
            {
                vwActividad.clbAct.Items.Clear();
                vwActividad.clbAct.Items.AddRange(qyActividad.GetNameActividad().ToArray());
            }

            if (vwActividad.clbVivi.Items.Count == 0)
            {
                vwActividad.clbVivi.Items.AddRange(qyVivienda.GetNameVivienda().ToArray());
            }
            else
            {
                vwActividad.clbVivi.Items.Clear();
                vwActividad.clbVivi.Items.AddRange(qyVivienda.GetNameVivienda().ToArray());
            }
        
        }

        private void AddActHab(object? sender, EventArgs e)
        {
            Actualizar();
        }

        private void Load(object? sender, EventArgs e)
        {
            Actualizar();
        }

        private void AddActividad(object? sender, EventArgs e)
        {
            if(vwActividad.txtDesc.Text == "")
            {
                MessageBox.Show("No se puede dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Hacer registro en la base de datos actividad
                mdActividad.descripcion = vwActividad.txtDesc.Text;
                if(qyActividad.Ingresar(mdActividad))
                {
                    MessageBox.Show("Se ha registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vwActividad.txtDesc.Text = "";
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Close(object? sender, EventArgs e)
        {
            vwActividad.Close();
        }
    }
}