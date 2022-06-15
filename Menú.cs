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
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Taller v1 = new Taller();
            v1.Show();

     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentaAutos v2 = new VentaAutos();
            v2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentaSeguros v3 = new VentaSeguros();
            v3.Show();
        }
    }
}
