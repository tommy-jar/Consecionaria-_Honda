using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consecionaria__Honda
{
    public partial class VentaAutos : Form
    {
        List<Venta_Autos> listaVentaAutos;
        public ListView copia = new ListView();

        public void copiarLista(ListView orig, ListView copy)
        {
            copy.Items.Clear();

            foreach (ListViewItem item in orig.Items)
            {
                copy.Items.Add((ListViewItem)item.Clone());
            }
        }

        public VentaAutos()
        {
            InitializeComponent();
            listaVentaAutos = new List<Venta_Autos>();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in database.Items)
            {
                if (item.Text == txtCodigo.Text)
                {
                    MessageBox.Show("CODIGO YA INGRESADO", "ERROR");
                    return;
                }
            }
            string dni = txtDNI.Text;
            string codigo = txtCodigo.Text;
            String matricula = txtMatrícula.Text;
            string modelo = TxtModelo.Text;
            int npuertas = Int32.Parse(Convert.ToString(numeroPuertas.Value));
            String color = TxtColor.Text;
            double precio = double.Parse(TxtPrecio.Text);

            ListViewItem lista = new ListViewItem(txtCodigo.Text);
            listaVentaAutos.Add(new Venta_Autos(dni, codigo, matricula, modelo, npuertas, color, precio));

            lista.SubItems.Add(dni);
            lista.SubItems.Add(matricula);
            lista.SubItems.Add(modelo);
            lista.SubItems.Add(color);
            lista.SubItems.Add(Convert.ToString(npuertas));
            lista.SubItems.Add(Convert.ToString(precio));

            database.Items.Add(lista);

            copiarLista(database, copia);

            txtDNI.Clear();
            txtCodigo.Clear();
            txtMatrícula.Clear();
            TxtModelo.Clear();
            TxtColor.Clear();
            numeroPuertas.Value = 0;
            TxtPrecio.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            copiarLista(copia, database);

            foreach (ListViewItem item in database.Items)
            {
                if (item.Text == txtCodigo.Text)
                {
                    database.Items.Clear();
                    database.Items.Add(item);
                    return;
                }
            }

            MessageBox.Show("NO SE ENCONTRO EL CODIGO", "ERROR");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            copiarLista(copia, database);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú sp = new Menú();
            sp.Show();
        }

        private void buttonPrecioMax_Min_Click(object sender, EventArgs e)
        {
            database.Items.Clear();
            List<Venta_Autos> listaprecio = listaVentaAutos.OrderBy(x => x.Precio).ToList();
            double maxprecio = listaprecio.Last().Precio;
            double minprecio = listaprecio[0].Precio;
            List<Venta_Autos> listabusqueda = listaVentaAutos.FindAll(x => x.Precio == maxprecio);

            foreach (var item in listabusqueda)
            {
                ListViewItem lista = new ListViewItem(txtCodigo.Text);


                lista.SubItems.Add(item.Dni);
                lista.SubItems.Add(item.Matricula);
                lista.SubItems.Add(item.Modelo);
                lista.SubItems.Add(item.Color);
                lista.SubItems.Add(Convert.ToString(item.Npuertas));
                lista.SubItems.Add(Convert.ToString(item.Precio));
                database.Items.Add(lista);

            }
            List<Venta_Autos> listabusqueda2 = listaVentaAutos.FindAll(x => x.Precio == minprecio);
            foreach (var item in listabusqueda2)
            {
                ListViewItem lista = new ListViewItem(txtCodigo.Text);


                lista.SubItems.Add(item.Dni);
                lista.SubItems.Add(item.Matricula);
                lista.SubItems.Add(item.Modelo);
                lista.SubItems.Add(item.Color);
                lista.SubItems.Add(Convert.ToString(item.Npuertas));
                lista.SubItems.Add(Convert.ToString(item.Precio));
                database.Items.Add(lista);

            }
        }
    }
}
