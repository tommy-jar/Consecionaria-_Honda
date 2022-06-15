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
    public partial class VentaSeguros : Form
    {
        List<Venta_Seguros> listVentaSeguros;
        public VentaSeguros()
        {
            InitializeComponent();
            listVentaSeguros = new List<Venta_Seguros>();

            Caracteres();
        }
        public void Caracteres()
        {
            lViewSeguros.View = View.Details;
            lViewSeguros.GridLines = true;
            lViewSeguros.Columns.Add("DNI ", 50);
            lViewSeguros.Columns.Add("Nombre ", 100);
            lViewSeguros.Columns.Add("Placa", 50);
            lViewSeguros.Columns.Add("Modelo ", 100);
            lViewSeguros.Columns.Add("Año Fabricación ", 100);
            lViewSeguros.Columns.Add("Vencimiento ", 80);
            lViewSeguros.Columns.Add("Poliza ", 50);


        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string DniV = txtDNI.Text.Trim();
            string NombreV = txtNombre.Text.Trim();
            string PlacaV = txtPlaca.Text.Trim();
            string ModeloV = txtModelo.Text.Trim();
            string AfraV = txtFabricacion.Text.Trim();
            string VencimientoV = txtVencimiento.Text.Trim();
            string PolizaV = txtPoliza.Text.Trim();

            ListViewItem list1 = new ListViewItem();
            listVentaSeguros.Add(new Venta_Seguros(DniV, NombreV, PlacaV, ModeloV, AfraV, VencimientoV, PolizaV));
            list1.Text = DniV;
            list1.SubItems.Add(NombreV);
            list1.SubItems.Add(PlacaV);
            list1.SubItems.Add(ModeloV);
            list1.SubItems.Add(AfraV);
            list1.SubItems.Add(VencimientoV);
            list1.SubItems.Add(PolizaV);
            lViewSeguros.Items.Add(list1);

            txtDNI.Clear();
            txtNombre.Clear();
            txtPlaca.Clear();
            txtModelo.Clear();
            txtFabricacion.Clear();
            txtVencimiento.Clear();
            txtVencimiento.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Buscar = txtDNI.Text.Trim();
            List<Venta_Seguros> listbusqueda = listVentaSeguros.FindAll(x => x.Dni == Buscar);

            foreach (var item in listVentaSeguros)
            {

                if (listbusqueda.Exists(x => x.Dni == item.Dni))
                {

                    ListViewItem sq = new ListViewItem();
                    lViewSeguros.Items.Clear();

                    sq.Text = item.Dni;
                    sq.SubItems.Add(item.Nombre);
                    sq.SubItems.Add(item.Placa);
                    sq.SubItems.Add(item.Modelo);
                    sq.SubItems.Add(item.AFabr);
                    sq.SubItems.Add(item.AVen);
                    sq.SubItems.Add(item.Poliza);
                    lViewSeguros.Items.Add(sq);
                }

            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú sp = new Menú();
            sp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            


        }

        private void txtFabricacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lViewMenor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonMenor_Click(object sender, EventArgs e)
        {


            

        }

        private void buttonMenor_Click_1(object sender, EventArgs e)
        {
            //string AFabr = txtFabricacion.Text;
            int? aux = null;

            foreach (Venta_Seguros vs in listVentaSeguros)
            {
                foreach (var item in vs.AFabr)
                {
                    if (aux == null || aux > Convert.ToInt32(vs.AFabr))
                    {
                        aux = Convert.ToInt32(vs.AFabr);
                    }
                }
            }
            lViewMenor.Items.Add("Menor:" + aux);
        }

        private void buttonMayor_Click(object sender, EventArgs e)
        {
            //string AFabr = txtFabricacion.Text;
            int aux = 0;

            foreach (Venta_Seguros vs in listVentaSeguros)
            {
                foreach (var item in vs.AFabr)
                {
                    if (aux < Convert.ToInt32(vs.AFabr))
                    {
                        aux = Convert.ToInt32(vs.AFabr);
                    }
                }
            }
            lViewMayor.Items.Add("Mayor:" + aux);
        }
    }
}