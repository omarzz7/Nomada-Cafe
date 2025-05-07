using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomdad_Cafe
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void btnPantallaInicio_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar1_Click(object sender, EventArgs e)
        {
            PantallaProductosNomadaCafe form2 = new PantallaProductosNomadaCafe();

            form2.Show();
            this.Hide();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
