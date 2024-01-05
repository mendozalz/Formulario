using Formulario.Datos;
using Formulario.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato= new Usuario();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void usuario_Click(object sender, EventArgs e)
        {

        }

        private void Edad_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Edad");
            grilla.DataSource = tabla;
        }

        private void Guardar()
        {
            UsuarioModel modelo = new UsuarioModel()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Usuario = txtUsuario.Text,
                Edad = int.Parse(txtEdad.Text),

            };
            dato.Guardar(modelo);
        }

        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Apellido"] = item.Apellido;
                fila["Usuario"] = item.Usuario;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtEdad.Text = "";
        }
    }
}
