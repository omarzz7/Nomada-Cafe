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
    public partial class PantallaToppingsNomadaCafe : Form
    {
        private int cantidadCanela = 0;
        private int cantidadSplenda = 0;
        private int cantidadMascabado = 0;
        private int cantidadAzucar = 0;
        private int cantidadStevia = 0;
        private int cantidadShot = 0;

        private Timer timer;
         
        private OrderManager _orderManager = new OrderManager();
        private OrderItem _currentItem = new OrderItem();

        public PantallaToppingsNomadaCafe(OrderManager orderManager, OrderItem currentItem)
        {
            InitializeComponent();

            _orderManager = orderManager;
            _currentItem = currentItem;

            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            this.Hide();

            PantallaInicio form1 = new PantallaInicio();

            form1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar2_Click(object sender, EventArgs e)
        {
            PantallaInicio form1 = new PantallaInicio();

            form1.Show();
            this.Hide();
        }

        private void btnterminar1_Click(object sender, EventArgs e)
        {
            PantallaFinalNomadaCafe form6 = new PantallaFinalNomadaCafe();

            form6.Show();

            timer.Start();

            this.Hide();
        }

        private void btnatras1_Click(object sender, EventArgs e)
        {
            PantallaTamaños form3 = new PantallaTamaños(_orderManager, _currentItem);

            form3.Show();
            this.Hide();
        }

        private void btnlisto1_Click(object sender, EventArgs e)
        {
            if (cantidadCanela > 0)
                _currentItem.Extras.Add("Extra: Canela");
            if (cantidadSplenda > 0)
                _currentItem.Extras.Add("Extra: Esplenda");
            if (cantidadMascabado > 0)
                _currentItem.Extras.Add("Extra: Mascabado");
            if (cantidadAzucar > 0)
                _currentItem.Extras.Add("Extra: Azúcar");
            if (cantidadStevia > 0)
                _currentItem.Extras.Add("Extra: Svetia");
            if (cantidadShot > 0)
            {
                _currentItem.Extras.Add("Extra: Shot de Espresso +10");
                _currentItem.ExtrasPrice += 10; // Agrega el costo extra solo si hay espresso
            }

            // Agregar el producto al pedido
            _orderManager.AddItem(_currentItem);


            PantallaDesicion form5 = new PantallaDesicion(_orderManager, _currentItem);
            form5.Show();
            this.Hide();

           
        }

        private void botonredondo3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmenoscanela_Click(object sender, EventArgs e)
        {
            cantidadCanela = 0; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadcanelatoppings.Text = cantidadCanela.ToString();
        }

        private void btnmascanela_Click(object sender, EventArgs e)
        {
            cantidadCanela = 1; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadcanelatoppings.Text = cantidadCanela.ToString();
        }

        private void btnmenossplenda_Click(object sender, EventArgs e)
        {
            cantidadSplenda = 0; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadsplendatoppings.Text = cantidadSplenda.ToString();
        }

        private void btnmassplenda_Click(object sender, EventArgs e)
        {
            cantidadSplenda = 1; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadsplendatoppings.Text = cantidadSplenda.ToString();
        }

        private void btnmenosmascabado_Click(object sender, EventArgs e)
        {
            cantidadMascabado = 0; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadmascabadotoppings.Text = cantidadMascabado.ToString();
        }

        private void btnmasmascabado_Click(object sender, EventArgs e)
        {
            cantidadMascabado = 1; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadmascabadotoppings.Text = cantidadMascabado.ToString();
        }

        private void btnmenosazucar_Click(object sender, EventArgs e)
        {
            cantidadAzucar = 0; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadazucartoppings.Text = cantidadAzucar.ToString();
        }

        private void btnmasazucar_Click(object sender, EventArgs e)
        {
            cantidadAzucar = 1; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadazucartoppings.Text = cantidadAzucar.ToString();
        }

        private void btnmenosstevia_Click(object sender, EventArgs e)
        {
            cantidadStevia = 0; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadsteviatoppings.Text = cantidadStevia.ToString();
        }

        private void btnmasstevia_Click(object sender, EventArgs e)
        {
            cantidadStevia = 1; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadsteviatoppings.Text = cantidadStevia.ToString();
        }

        private void btnmenosshot_Click(object sender, EventArgs e)
        {
            cantidadShot = 0; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadshottoppings.Text = cantidadShot.ToString();
        }

        private void btnmasshot_Click(object sender, EventArgs e)
        {
            cantidadShot = 1; // Siempre será 1 al pulsar "+", según tu lógica
            textboxcantidadshottoppings.Text = cantidadShot.ToString();
        }
    }
}
