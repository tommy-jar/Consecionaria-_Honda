
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
    public partial class Form1 : Form
    {
        List<Consecionaria> listConsecionaria; 
        public Form1()
        {
            InitializeComponent();
            listConsecionaria = new List<Consecionaria>();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            double CodUsuario =Convert.ToDouble(txtUsuario.Text.Trim());
            double CodContraseña = Convert.ToDouble(txtContraseña.Text.Trim());

            ListViewItem ListPrincipal = new ListViewItem();

            if (CodUsuario == 123 && CodContraseña == 123)
            {
                listConsecionaria.Add(new Consecionaria(CodContraseña, CodUsuario));
                txtUsuario.Clear();
                txtContraseña.Clear();
                ListPrincipal.Text = Convert.ToString(CodUsuario);
                ListPrincipal.SubItems.Add(Convert.ToString(CodContraseña));
               

                this.Hide();
                Menú v2 = new Menú();
                v2.Show();

            }
            else
                MessageBox.Show("El usuario o la contraseña es incorrecto \n EL USUARIO ES 123");
            
        }
    }
}
