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
    public partial class Taller : Form
    {
        List<Servicio_Taller> listServicoTaller;
        public Taller()
        {
            InitializeComponent();
            listServicoTaller = new List<Servicio_Taller>();

            Caracteres();

        }

        public void Caracteres()
        {
            lViewT1.View = View.Details;
            lViewT1.GridLines = true;
            lViewT1.Columns.Add("Nombre Asesor ",100);
            lViewT1.Columns.Add("Código",50);
            lViewT1.Columns.Add("Diagnotico",200);


            lViewT2.View = View.Details;
            lViewT2.GridLines = true;
            lViewT2.Columns.Add("Nombre Cliente ",100);
            lViewT2.Columns.Add("Monto",50);

            lViewT3.View = View.Details;
            lViewT3.GridLines = true;
            lViewT3.Columns.Add("Modelo",50);
            lViewT3.Columns.Add("Color",50);
            lViewT3.Columns.Add("Placa",50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NomAse = txtNomAsesor.Text.Trim();
            double Codigo = Convert.ToDouble(txtCodigo.Text.Trim());
            string Diagnostico = txtDiagnostico.Text.Trim();
            string NomCliente = txtNomCliente.Text.Trim();
            string Monto = txtMonto.Text.Trim();
            string Modelo = txtModelo.Text.Trim();
            string Color = txtColor.Text.Trim();
            string Placa = txtPlaca.Text.Trim();


            ListViewItem list1 = new ListViewItem();
            listServicoTaller.Add(new Servicio_Taller(NomAse, Codigo, Diagnostico,NomCliente,Monto, Modelo,Color,Placa));
            list1.Text = NomAse;
            list1.SubItems.Add(Convert.ToString(Codigo));
            list1.SubItems.Add(Diagnostico);
            lViewT1.Items.Add(list1);

            txtNomAsesor.Clear();
            txtCodigo.Clear();
            txtDiagnostico.Clear();

            ListViewItem list2 = new ListViewItem();
            listServicoTaller.Add(new Servicio_Taller(NomAse, Codigo, Diagnostico, NomCliente, Monto, Modelo, Color, Placa));
            list2.Text = NomCliente;
            list2.SubItems.Add(Monto);
            lViewT2.Items.Add(list2);

            txtNomCliente.Clear();
            txtMonto.Clear();

            ListViewItem list3 = new ListViewItem();
            listServicoTaller.Add(new Servicio_Taller(NomAse, Codigo, Diagnostico, NomCliente, Monto, Modelo, Color, Placa));
            list3.Text = Modelo;
            list3.SubItems.Add(Color);
            list3.SubItems.Add(Placa);
            lViewT3.Items.Add(list3);

            txtModelo.Clear();
            txtColor.Clear();
            txtPlaca.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Buscar = Convert.ToDouble(txtCodigo.Text.Trim());
            List<Servicio_Taller> listbusqueda = listServicoTaller.FindAll(x => x.CodigoTaller == Buscar);

            foreach( var item in listServicoTaller)
            {
                if(listbusqueda.Exists(x=>x.CodigoTaller == item.CodigoTaller))
                {
                    ListViewItem list1 = new ListViewItem();
                    lViewT1.Items.Clear();
                    list1.Text = item.NomAsesor;
                    list1.SubItems.Add (Convert.ToString(item.CodigoTaller));
                    list1.SubItems.Add(item.Diagnostico);
                    lViewT1.Items.Add(list1);

                    ListViewItem list2 = new ListViewItem();
                    lViewT2.Items.Clear();
                    list2.Text = item.NomCliente;
                    list2.SubItems.Add(item.Monto);
                    lViewT2.Items.Add(list2);

                    ListViewItem list3 = new ListViewItem();
                    lViewT3.Items.Clear();
                    list3.Text = item.Modelo;
                    list3.SubItems.Add(item.Color);
                    list3.SubItems.Add(item.Placa);
                    lViewT3.Items.Add(list3);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú sp =new Menú();
            sp.Show();
        }
    }
}
