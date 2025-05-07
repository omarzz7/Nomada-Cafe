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
    public partial class PantallaProductosNomadaCafe : Form
    {
        private OrderManager _orderManager = new OrderManager();
        private OrderItem _currentItem = new OrderItem();

        public PantallaProductosNomadaCafe()
        {
            InitializeComponent();

        }

        private void PantallaProductosNomadaCafe_Load(object sender, EventArgs e)
        {

        }

        private void btnduneada_Click(object sender, EventArgs e)
        {
            var item = new OrderItem
            {
                ProductName = "Duneada",
                BasePrice = 50m
            };
            PantallaTamaños form3 = new PantallaTamaños(_orderManager, _currentItem);

            form3.Show();
            this.Hide();
        }

        private void btnnevada_Click(object sender, EventArgs e)
        {
            var item = new OrderItem
            {
                ProductName = "Nevada",
                BasePrice = 50m
            };
            PantallaTamaños form3 = new PantallaTamaños(_orderManager, _currentItem);

            form3.Show();
            this.Hide();

        }

        private void btnfrosteada_Click(object sender, EventArgs e)
        {
            var item = new OrderItem
            {
                ProductName = "Frosteada",
                BasePrice = 50m
            };
            PantallaTamaños form3 = new PantallaTamaños(_orderManager, _currentItem);

            form3.Show();
            this.Hide();
        }

        private void btnsundae_Click(object sender, EventArgs e)
        {
            var item = new OrderItem
            {
                ProductName = "Sundae",
                BasePrice = 40m
            };
            PantallaToppingsNomadaCafe form4 = new PantallaToppingsNomadaCafe(_orderManager, _currentItem);

            form4.Show();
            this.Hide();
        }

        private void btncapuccino_Click(object sender, EventArgs e)
        {
            var item = new OrderItem
            {
                ProductName = "Capuccino",
                BasePrice = 35m
            };
            PantallaTamaños form3 = new PantallaTamaños(_orderManager, _currentItem);

            form3.Show();
            this.Hide();
        }

        private void btnlatte_Click(object sender, EventArgs e)
        {
            var item = new OrderItem
            {
                ProductName = "Latte",
                BasePrice = 35m
            };
            PantallaTamaños form3 = new PantallaTamaños(_orderManager, _currentItem);

            form3.Show();
            this.Hide();
        }

        private void btnamericano_Click(object sender, EventArgs e)
        {
            var item = new OrderItem
            {
                ProductName = "Americano",
                BasePrice = 35m
            };
            PantallaTamaños form3 = new PantallaTamaños(_orderManager, _currentItem);

            form3.Show();
            this.Hide();
        }

        private void btnagua_Click(object sender, EventArgs e)
        {
            var item = new OrderItem
            {
                ProductName = "Agua",
                BasePrice = 15m
            };
            PantallaDesicion form5 = new PantallaDesicion(_orderManager, _currentItem);

            form5.Show();
            this.Hide();
        }

        private void btncancelar1_Click(object sender, EventArgs e)
        {
            PantallaInicio form1 = new PantallaInicio();

            form1.Show();
            this.Hide();
        }
    }
}
