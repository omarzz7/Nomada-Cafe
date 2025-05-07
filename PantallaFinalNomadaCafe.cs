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
    public partial class PantallaFinalNomadaCafe : Form
    {
        private Timer timer;
        public PantallaFinalNomadaCafe()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
        }

        private void PantallaFinalNomadaCafe_Load(object sender, EventArgs e)
        {

        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            this.Hide();

            PantallaInicio form1 = new PantallaInicio();

            form1.Show();
        }
    }
}
