using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_Factura
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            lblDia.Text = DateTime.Today.Day.ToString();
            lblMes.Text = DateTime.Now.ToString("MMMM");
            lblAño.Text = DateTime.Now.Year.ToString();
        }
    }
}
