using INEGI.src.databases;
using INEGI.src.models;
using INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerHabitante
    {
        private QueryVivienda qyVivienda;
        private QueryHabitante qyHabitante;
        private ModelHabitante mdHabitante;
        private FrmHabitante vwHabitante;
        // Variables
        private int idVivienda;


        public ControllerHabitante(QueryVivienda qyVivienda, QueryHabitante qyHabitante, ModelHabitante mdHabitante, FrmHabitante vwHabitante)
        {
            this.qyVivienda = qyVivienda;
            this.qyHabitante = qyHabitante;
            this.mdHabitante = mdHabitante;
            this.vwHabitante = vwHabitante;
            // Eventos
            this.vwHabitante.btnClose.Click += new EventHandler(Close);
            this.vwHabitante.Load += new EventHandler(Load);
            this.vwHabitante.clbViviendo.ItemCheck += new ItemCheckEventHandler(SelectVivienda);
            this.vwHabitante.btnCan.Click += new EventHandler(Cancel);
            this.vwHabitante.btnAgr.Click += new EventHandler(AddHabitante);
            this.vwHabitante.btnActu.Click += new EventHandler(UpdateHabitante);
        }

        private void Actualizar()
        {
            vwHabitante.dtpNac.MaxDate = DateTime.Now;

            if (vwHabitante.clbViviendo.Items.Count == 0)
            {
                vwHabitante.clbViviendo.Items.AddRange(qyVivienda.GetNameVivienda().ToArray());
            }
            else
            {
                vwHabitante.clbViviendo.Items.Clear();
                vwHabitante.clbViviendo.Items.AddRange(qyVivienda.GetNameVivienda().ToArray());
            }

            if (vwHabitante.cmbGenero.Items.Count == 0)
            {
                vwHabitante.cmbGenero.DataSource = Enum.GetValues(typeof(ModelHabitante.Genero));
            }
            else
            {   
                vwHabitante.cmbGenero.DataSource = null; // Limpia el combobox
                vwHabitante.cmbGenero.DataSource = Enum.GetValues(typeof(ModelHabitante.Genero));
            }

            vwHabitante.dgvHabitante.DataSource = qyHabitante.ListaHabitante();
        }

        private void Load(object? sender, EventArgs e)
        {
            Actualizar();
        }

        private void UpdateHabitante(object? sender, EventArgs e)
        {
            Actualizar();
        }

        private void Cancel(object? sender, EventArgs e)
        {
            // Deselecciona el clbViviendo
            vwHabitante.clbViviendo.SetItemChecked(idVivienda - 1, false);
            // Habilita el checkbox
            vwHabitante.clbViviendo.Enabled = true;
            // Oculta los botones
            vwHabitante.btnCan.Visible = false;
        }

        private void SelectVivienda(object? sender, ItemCheckEventArgs e)
        {
            // Guarda el indice de la vivienda seleccionada
            idVivienda = e.Index + 1;
            // Desactiva el checkList
            vwHabitante.clbViviendo.Enabled = false;
            // Muestra el boton de Cancelar
            vwHabitante.btnCan.Visible = true;
        }

        private void AddHabitante (object? sender, EventArgs e)
        {
            if (vwHabitante.txtNombre.Text == "")
            {
                MessageBox.Show("El campo nombre no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Hacer un registro en la base de datos de la tabla habitante
                mdHabitante.nombre = vwHabitante.txtNombre.Text;
                mdHabitante.fechaNacimiento = vwHabitante.dtpNac.Value;
                mdHabitante.genero = (ModelHabitante.Genero)vwHabitante.cmbGenero.SelectedIndex + 1;
                mdHabitante.idVivienda = idVivienda;
                if(qyHabitante.Insertar(mdHabitante))
                {
                    MessageBox.Show("Se ha registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // lIMPERA
                    vwHabitante.txtNombre.Text = "";
                    vwHabitante.dtpNac.Value = DateTime.Now;
                    vwHabitante.cmbGenero.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Close(object? sender, EventArgs e)
        {
            vwHabitante.Close();
        }
    }
}