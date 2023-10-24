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
        // Variables
        private int idActividad;
        private int idVivienda;


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
            this.vwActividad.clbAct.ItemCheck += new ItemCheckEventHandler(SelectActivi);
            this.vwActividad.clbVivi.ItemCheck += new ItemCheckEventHandler(SelectVivi);
            this.vwActividad.btnCancelar.Click += new EventHandler(Cancelar);
            this.vwActividad.btnContinuar.Click += new EventHandler(Continuar);
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

        private void SelectActivi(object? sender, ItemCheckEventArgs e)
        {
            //Gurda el id de la actividad
            idActividad = e.Index + 1;
            //Desaviar el checkList
            vwActividad.clbAct.Enabled = false;
            // Ver el boton de cancelar
            vwActividad.btnCancelar.Visible = true;
            // Habilitar el checkList de vivienda
            vwActividad.clbVivi.Enabled = true;
        }

        private void SelectVivi(object? sender, ItemCheckEventArgs e)
        {
            // Guarda el id de la vivienda
            idVivienda = e.Index + 1;
            // Desactivar el checkList
            vwActividad.clbVivi.Enabled = false;
            // Ver el boton de continuar
            vwActividad.btnContinuar.Visible = true;
        }

        private void Cancelar(object? sender, EventArgs e)
        {
            //Deseleccionar los checkList
            vwActividad.clbAct.SetItemChecked(idActividad - 1, false);
            //Desactivar los checkList
            vwActividad.clbAct.Enabled = true;
            vwActividad.clbVivi.Enabled = false;
            // if(vwActividad.clbVivi.Items.Count != 0)
            // {
            //     vwActividad.clbVivi.SetItemChecked(idVivienda - 1, false);
            // }
            //Ocultar los botones
            vwActividad.btnContinuar.Visible = false;
            vwActividad.btnCancelar.Visible = false;
        }

        private void Continuar(object? sender, EventArgs e)
        {
            // Hacer registro en vivienda_actividad
            mdActividad.idActividad = idActividad;
            mdActividad.idVivienda = idVivienda;
            if(qyActividad.IngresarViviendaActividad(mdActividad))
            {
                MessageBox.Show("Se ha registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Deseleccionar los checkList
                vwActividad.clbVivi.SetItemChecked(idVivienda - 1, false);
                vwActividad.clbAct.SetItemChecked(idActividad - 1, false);
                //Ocultar el boton de continuar
                vwActividad.btnContinuar.Visible = false;
                //Desactivar los checkList
                vwActividad.clbVivi.Enabled = false;
                //Activar el checkList
                vwActividad.clbAct.Enabled = true;
                //Ocultar el boton de cancelar
                vwActividad.btnCancelar.Visible = false;
            }
            else
            {
                MessageBox.Show("No se ha podido registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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