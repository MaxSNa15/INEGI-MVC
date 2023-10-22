using INEGI.src.databases;
using INEGI.src.models;
using  INEGI.src.views;

namespace INEGI.src.controllers
{
    public class ControllerVivienda
    {
        private QueryMunicipio qyMunicipio;
        private QueryLocalidad qyLocalidad;
        private QueryVivienda qyVivienda;
        private ModelLocalidad mdLocalidad;
        private ModelVivienda mdVivienda;
        private FrmVivienda vwVivienda;
        // variables
        private int municipioID;
        private int localidadID;

        public ControllerVivienda(QueryMunicipio qyMunicipio, QueryLocalidad qyLocalidad, QueryVivienda qyVivienda, ModelLocalidad mdLocalidad, ModelVivienda mdVienda, FrmVivienda vwVivienda)
        {
            this.qyMunicipio = qyMunicipio;
            this.qyLocalidad = qyLocalidad;
            this.mdLocalidad = mdLocalidad;
            this.qyVivienda = qyVivienda;
            this.mdVivienda = mdVienda;
            this.vwVivienda = vwVivienda;
            // Eventos
            this.vwVivienda.Load += new EventHandler(LoadForm);
            this.vwVivienda.btnClose.Click += new EventHandler(Close);
            this.vwVivienda.btnLocalidad.Click += new EventHandler(LoadLocalidad);
            this.vwVivienda.btnVivienda.Click += new EventHandler(LoadVivienda);
            this.vwVivienda.btnSkip.Click += new EventHandler(Skip);
            this.vwVivienda.clbMunicipio.ItemCheck += new ItemCheckEventHandler(SelectMunicipio);
            this.vwVivienda.clbLocalidad.ItemCheck += new ItemCheckEventHandler(SelectLocalidad);
            this.vwVivienda.btnCan.Click += new EventHandler(Cancel);
            this.vwVivienda.btnCon.Click += new EventHandler(Continuar);
            this.vwVivienda.btnGuaLoc.Click += new EventHandler(GuardarLocalidad);
            this.vwVivienda.btnGuaViv.Click += new EventHandler(GuardarVivienda);
        }

        private void LoadForm(object? sender, EventArgs e)
        {
            // Oculta los grupBox
            vwVivienda.grbMun.Visible = false;
            vwVivienda.grbVivi.Visible = false;
        }

        private void LoadLocalidad(object? sender, EventArgs e)
        {
            // Carga el checkList de municipios
            if (vwVivienda.clbMunicipio.Items.Count == 0)
            {
                vwVivienda.clbMunicipio.Items.AddRange(qyMunicipio.GetNameMunicipio().ToArray());
            }
            else
            {
                vwVivienda.clbMunicipio.Items.Clear();
                vwVivienda.clbMunicipio.Items.AddRange(qyMunicipio.GetNameMunicipio().ToArray());
            }
            // Oculta los botones
            vwVivienda.btnLocalidad.Visible = false;
            vwVivienda.btnVivienda.Visible = false;
            // Muestra el boton de Cancelar
            vwVivienda.btnSkip.Visible = true;
            // Muestra el grupo de municipios
            vwVivienda.grbMun.Visible = true;
        }

        private void LoadVivienda(object? sender, EventArgs e)
        {
            // Carga el checkList de localidades
            if(vwVivienda.clbLocalidad.Items.Count == 0)
            {
                vwVivienda.clbLocalidad.Items.AddRange(qyLocalidad.GetNameLocalidad().ToArray());
            }
            else
            {
                vwVivienda.clbLocalidad.Items.Clear();
                vwVivienda.clbLocalidad.Items.AddRange(qyLocalidad.GetNameLocalidad().ToArray());
            }

            if(vwVivienda.cmbTipo.Items.Count == 0)
            {
                vwVivienda.cmbTipo.DataSource = Enum.GetValues(typeof(ModelVivienda.TipoVivienda));
            }
            else
            {
                vwVivienda.cmbTipo.DataSource = null; // Primero, establece el DataSource a null
                vwVivienda.cmbTipo.DataSource = Enum.GetValues(typeof(ModelVivienda.TipoVivienda));
            }

            // Oculta los botones
            vwVivienda.btnLocalidad.Visible = false;
            vwVivienda.btnVivienda.Visible = false;
            // Muestra el boton de Cancelar
            vwVivienda.btnSkip.Visible = true;
            // Muestra el grupo de municipios
            vwVivienda.grbVivi.Visible = true;
        }

        private void Skip(object? sender, EventArgs e)
        {
            if(vwVivienda.grbMun.Visible)
            {
                // Oculta el grupo de municipios
                vwVivienda.grbMun.Visible = false;
                // Muestra los botones
                vwVivienda.btnLocalidad.Visible = true;
                vwVivienda.btnVivienda.Visible = true;
                // Oculta el boton de Cancelar
                vwVivienda.btnSkip.Visible = false;
            }
            else if(vwVivienda.grbVivi.Visible)
            {
                // Oculta el grupo de vivienda
                vwVivienda.grbVivi.Visible = false;
                // Muestra los botones
                vwVivienda.btnLocalidad.Visible = true;
                vwVivienda.btnVivienda.Visible = true;
                // Oculta el boton de Cancelar
                vwVivienda.btnSkip.Visible = false;
            }
            else
            {
                // Oculta el grupo de vivienda
                vwVivienda.grbVivi.Visible = false;
                // Muestra los botones
                vwVivienda.btnLocalidad.Visible = true;
                vwVivienda.btnVivienda.Visible = true;
                // Oculta el boton de Cancelar
                vwVivienda.btnSkip.Visible = false;
            }
        }

        private void SelectMunicipio(object? sender, ItemCheckEventArgs e)
        {
            // Guarda el id del municipio seleccionado
            municipioID = e.Index + 1;
            // Desabilita el boton skip
            vwVivienda.btnSkip.Enabled = false;
            //Desabilita el checklist
            vwVivienda.clbMunicipio.Enabled = false;
            // Muestra los botones
            vwVivienda.btnCan.Visible = true;
            vwVivienda.btnCon.Visible = true;
            //MessageBox.Show(municipioID.ToString());
        }

        private void SelectLocalidad(object? sender, ItemCheckEventArgs e)
        {
            // Guarda el id de la localidad seleccionada
            localidadID = e.Index + 1;
            // Desabilita el boton skip
            vwVivienda.btnSkip.Enabled = false;
            // Desabilita el checklist
            vwVivienda.clbLocalidad.Enabled = false;
            // Muestra el boton de guardar localidad
            vwVivienda.btnGuaViv.Visible = true;
        }

        private void Cancel(object? sender, EventArgs e)
        {
            // Deselecciona el municipio
            vwVivienda.clbMunicipio.SetItemChecked(municipioID - 1, false);
            // Habilita el boton skip
            vwVivienda.btnSkip.Enabled = true;
            // Habilita el checkbox
            vwVivienda.clbMunicipio.Enabled = true;
            // Oculta los botones
            vwVivienda.btnCan.Visible = false;
            vwVivienda.btnCon.Visible = false;
        }

        private void Continuar(object? sender, EventArgs e)
        {
            //MessageBox.Show(municipioID.ToString());
            // Desabilita los botones
            vwVivienda.btnCan.Enabled = false;
            vwVivienda.btnCon.Enabled = false;
            // Muestra el grupo de localidad
            vwVivienda.grbLocalidad.Visible = true;
        }

        private void GuardarLocalidad(object? sender, EventArgs e)
        {
            if(vwVivienda.txtNomLoc.Text == "")
            {
                MessageBox.Show("El campo de nombre de localidad esta vacio");
            }
            else if(qyLocalidad.NombreExiste(vwVivienda.txtNomLoc.Text))
            {
                MessageBox.Show("El nombre de localidad ya existe. Por favor, elija otro nombre.");
            }
            else
            {
                // Hacer un registro en la base de datos de la tabla localidad
                mdLocalidad.nombre = vwVivienda.txtNomLoc.Text;
                mdLocalidad.idMunicipio = municipioID;
                if(!qyLocalidad.Insertar(mdLocalidad))
                {
                    MessageBox.Show("Error al insertar los datos en la base de datos");
                }
                else
                {
                    
                    vwVivienda.txtNomLoc.Text = "";
                    vwVivienda.grbLocalidad.Visible = false;
                    // Habilita los botones
                    vwVivienda.btnCan.Enabled = true;
                    vwVivienda.btnCon.Enabled = true;
                    // mensaje de exito
                    MessageBox.Show("Datos insertados correctamente");
                }
            }
        }

        private void GuardarVivienda(object? sender, EventArgs e)
        {
            if(vwVivienda.txtDire.Text == "" || vwVivienda.cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Los campos de direccion y tipo de vivienda estan vacios");
            }
            else 
            {
                // Hacer un registro en la base de datos
                mdVivienda.direccion = vwVivienda.txtDire.Text;
                mdVivienda.tipovi = (ModelVivienda.TipoVivienda)vwVivienda.cmbTipo.SelectedIndex;
                mdVivienda.idLocalidad = localidadID;
                // MessageBox.Show(mdVivienda.tipovi.ToString());
                if(!qyVivienda.Insertar(mdVivienda))
                {
                    MessageBox.Show("Error al insertar los datos en la base de datos");
                }
                else
                {
                    vwVivienda.txtDire.Text = "";
                    vwVivienda.cmbTipo.SelectedIndex = -1;
                    // Habilita el checklist
                    vwVivienda.clbLocalidad.Enabled = true;
                    // Habilita el boton skip
                    vwVivienda.btnSkip.Enabled = true;
                    // mensaje de exito
                    MessageBox.Show("Datos insertados correctamente");
                }
            }
        }

        private void Close(object? sender, EventArgs e)
        {
            vwVivienda.Close();
        }
    }
}