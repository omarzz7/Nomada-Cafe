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
    public partial class PantallaTamaños : Form
    {
        private OrderManager _orderManager = new OrderManager();
        private OrderItem _currentItem = new OrderItem();

        public PantallaTamaños(OrderManager orderManager, OrderItem currentItem)
        {
            InitializeComponent();
            _orderManager = orderManager;
            _currentItem = currentItem;
        }

        private void PantallaTamaños_Load(object sender, EventArgs e)
        {
          
        }

        private void btncancelar1_Click(object sender, EventArgs e)
        {
            PantallaInicio form1 = new PantallaInicio();

            form1.Show();
            this.Hide();
        }

        private void btnatras1_Click(object sender, EventArgs e)
        {
            PantallaProductosNomadaCafe form2 = new PantallaProductosNomadaCafe();

            form2.Show();
            this.Hide();
        }

        private void btnduneada_Click(object sender, EventArgs e)
        {
            _currentItem.Size = "Chico";
            _currentItem.BasePrice += 0; // Sin costo adicional para "Chico"
            
            PantallaToppingsNomadaCafe form4 = new PantallaToppingsNomadaCafe(_orderManager, _currentItem);

            form4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _currentItem.Size = "Mediano";
            _currentItem.BasePrice += 10; // Costo adicional para "Mediano"

            PantallaToppingsNomadaCafe form4 = new PantallaToppingsNomadaCafe(_orderManager, _currentItem);

            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _currentItem.Size = "Grande";
            _currentItem.BasePrice += 20; // Costo adicional para "Grande"
            
            PantallaToppingsNomadaCafe form4 = new PantallaToppingsNomadaCafe(_orderManager, _currentItem);

            form4.Show();
            this.Hide();
        }
    }
}
