using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using capaNegocio;

namespace RellenandoComboboxDinamicamente
{
    public partial class VentanaComobobox : Form
    {
        // Lista global de equipos de futbol: (Global: existe a todo nivel del código o clase en este caso).

        List<EquipoFutbol> listaDeEquiposDeFutbol = new List<EquipoFutbol>();

        public VentanaComobobox()
        {
            InitializeComponent();
        }

        private void btnCargaValores_Click(object sender, EventArgs e)
        {
            // Limpiamos los items del combobox y de la lista

            cmbEquipos.Items.Clear(); // ---> Limpiamos el combobox

            listaDeEquiposDeFutbol.Clear(); // ---> Limpiamos la lista dado que emulamos la carga desde la BD

            // Seleccionamos el modo de combobox para que el usuario no pueda escribir en el

            cmbEquipos.DropDownStyle = ComboBoxStyle.DropDownList;

            //  Emulamos la carga desde la base de datos creando objetos EquipoFutbol (3)

            EquipoFutbol equipoNuevo1 = new EquipoFutbol();
            equipoNuevo1.Nombre = "Colo-Colo";
            equipoNuevo1.Pais = "Chile";
            equipoNuevo1.CantCopas = 0;

            listaDeEquiposDeFutbol.Add(equipoNuevo1); // Añadimos el objeto a la lista.

            EquipoFutbol equipoNuevo2 = new EquipoFutbol();
            equipoNuevo2.Nombre = "U. De Chile";
            equipoNuevo2.Pais = "Chile";
            equipoNuevo2.CantCopas = 20000;

            listaDeEquiposDeFutbol.Add(equipoNuevo2); // Añadimos el objeto a la lista.

            EquipoFutbol equipoNuevo3 = new EquipoFutbol();
            equipoNuevo3.Nombre = "Everton";
            equipoNuevo3.Pais = "Chile";
            equipoNuevo3.CantCopas = 3;

            listaDeEquiposDeFutbol.Add(equipoNuevo3); // Añadimos el objeto a la lista.

            // recorremos la lista de equipos y lo cargamos al combobox Por cada objeto EquipoFutbol en la listaDeEquiposDeFutbol

            foreach (EquipoFutbol equipo in listaDeEquiposDeFutbol)
            {
                // Agregmos el items en el combobox con algún campo que lo identifique.

                cmbEquipos.Items.Add(equipo.Nombre);
            }
        }

        private void btnbLimpiarItems_Click(object sender, EventArgs e)
        {
            // Limpiamos los items del combobox con el metodo clear

            cmbEquipos.Items.Clear();
        }

        private void btnMostrarItems_Click(object sender, EventArgs e)
        {
            // atrapamos el indice seleccionado

            int indice = cmbEquipos.SelectedIndex;

            txtVistaValorSeleccionado.Text = cmbEquipos.Text;
        }

        private void cmbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento ocurre cuando el usuario cambia la propiedad del indice de selección de combobox
            // Cuando cambiamos de items.

            txtVistaValorSeleccionado.Text = cmbEquipos.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Establecemos la propiedad Text del textbox en "" para dejar limpio.

            txtVistaValorSeleccionado.Text = "";
        }

        private void btnCargaBD_Click(object sender, EventArgs e)
        {
            string error;

            // Limpiamos los items del combobox

            cmbEquipos.Items.Clear();


            // Seleccionamos el modo de combobox para que el usuario no pueda escribir en el

            cmbEquipos.DropDownStyle = ComboBoxStyle.DropDownList;

            // Creamos un objeto de capa negocio correspondiente a la entidad EquipoFutbol

            NEGEquipoFutbol negEquipoFutbol = new NEGEquipoFutbol();

            // Se consume el metodo listarLosEquiposDeFutbol para cargar el list de equipos desde la BD
            // Pasando como parametro de salida nuestra variable error en caso de alguna excepción
            // en las capas negocio o persistencia.

            this.listaDeEquiposDeFutbol = negEquipoFutbol.listarLosEquiposDeFutbol(out error);

            // Si hay algún error, lo mostramos en pantalla, de lo contrario recorremos la lista y cargamos los valores al cmb

            if (String.IsNullOrEmpty(error) == false)
            {
                this.listaDeEquiposDeFutbol = null;
                MessageBox.Show(error);
            }
            else
            {
                foreach (EquipoFutbol equipo in listaDeEquiposDeFutbol)
                {
                    // Agregmos el items en el combobox con algún campo que lo identifique.

                    cmbEquipos.Items.Add(equipo.Nombre);
                }
            }
        }
    }
}
