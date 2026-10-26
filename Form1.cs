using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPacientes
{
    public partial class Form1 : Form
    {
        // Cola de prioridad (lista enlazada ordenada por prioridad y orden de llegada).
        private ColaPacientes cola = new ColaPacientes();

        // Historial de pacientes ya atendidos (en el orden en que se atendieron).
        private List<Paciente> historial = new List<Paciente>();

        public Form1()
        {
            InitializeComponent();

            cmbPrioridad.Items.Add("P1");
            cmbPrioridad.Items.Add("P2");
            cmbPrioridad.Items.Add("P3");

            cmbPrioridad.SelectedIndex = -1;
        }


        // Muestra los pacientes pendientes en el orden en que seran atendidos.
        private void MostrarPendientes()
        {
            lstPacientes.Items.Clear();
            foreach (Paciente p in cola.ObtenerPendientes())
            {
                lstPacientes.Items.Add(p.ToString());
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show(
                    "Debe escribir el nombre del paciente.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombre.Focus();
                return;
            }

            if (cmbPrioridad.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar una prioridad: P1, P2 o P3.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbPrioridad.Focus();
                return;
            }

            string prioridad = cmbPrioridad.SelectedItem.ToString();

            cola.Encolar(nombre, prioridad);
            MostrarPendientes();

            MessageBox.Show(
                "Paciente registrado correctamente.",
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            txtNombre.Clear();
            cmbPrioridad.SelectedIndex = -1;
            txtNombre.Focus();
        }

        // Atiende al siguiente paciente: lo saca de la cola, lo guarda en el historial
        // y muestra un mensaje indicando quien fue atendido.
        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (cola.EstaVacia)
            {
                MessageBox.Show(
                    "No hay pacientes pendientes por atender.",
                    "Cola vacia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            Paciente atendido = cola.Desencolar();
            historial.Add(atendido);
            MostrarPendientes();

            MessageBox.Show(
                "Se atendio a: " + atendido.Nombre + " (" + atendido.PrioridadTexto + ")",
                "Paciente atendido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Muestra en el segundo ListBox los pacientes ya atendidos,
        // en el mismo orden en que fueron atendidos.
        private void btnVerAtendidos_Click(object sender, EventArgs e)
        {
            if (historial.Count == 0)
            {
                MessageBox.Show(
                    "Todavia no se ha atendido a ningun paciente.",
                    "Sin pacientes atendidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            lstAtendidos.Items.Clear();
            for (int i = 0; i < historial.Count; i++)
            {
                lstAtendidos.Items.Add((i + 1) + ". " + historial[i].ToString());
            }
            lstAtendidos.Visible = true;
        }
    }
}
