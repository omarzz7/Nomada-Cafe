using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomdad_Cafe
{
    public partial class PantallaDesicion : Form
    {
        private Timer timer;

        private OrderManager _orderManager = new OrderManager();
        private OrderItem _currentItem = new OrderItem();

        public PantallaDesicion(OrderManager orderManager, OrderItem currentItem)
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

        private void btncancelar1_Click(object sender, EventArgs e)
        {
            PantallaInicio form1 = new PantallaInicio();

            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaProductosNomadaCafe form2 = new PantallaProductosNomadaCafe();

            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveOrderToFile();

            PantallaFinalNomadaCafe form6 = new PantallaFinalNomadaCafe();

            form6.Show();

            timer.Start();

            this.Hide();
        }

        private void PantallaDesicion_Load(object sender, EventArgs e)
        {
            dataGridViewDesicion.DataSource = _orderManager.Items.Select(item => new
            {
                Producto = item.ProductName,
                Tamaño = item.Size,
                Extras = string.Join(", ", item.Extras),
                Precio = item.TotalPrice
            }).ToList();

            textboxsubtotaldesicion.Text = _orderManager.Subtotal.ToString("$");
            textboxivadesicion.Text = _orderManager.IVA.ToString("$");
            textboxtotaldesicion.Text = _orderManager.Total.ToString("$");
        }

        private void SaveOrderToFile()
        {
            string path = "Ordenes";
            Directory.CreateDirectory(path);

            // Archivo principal con la orden completa
            string orderFileName = Path.Combine(path, $"Orden_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
            File.WriteAllText(orderFileName, GenerateOrderText());

            // Ticket simplificado
            string ticketFileName = Path.Combine(path, $"Ticket_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
            File.WriteAllText(ticketFileName, GenerateTicketText());

        }

        private string GenerateOrderText()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Fecha: {DateTime.Now}");
            sb.AppendLine("Productos:");
            foreach (var item in _orderManager.Items)
            {
                sb.AppendLine($"- {item.ProductName} ({item.Size}) - {string.Join(", ", item.Extras)}: {item.TotalPrice:C}");
            }
            sb.AppendLine($"Subtotal: {_orderManager.Subtotal:C}");
            sb.AppendLine($"IVA: {_orderManager.IVA:C}");
            sb.AppendLine($"Total: {_orderManager.Total:C}");
            return sb.ToString();
        }

        private string GenerateTicketText()
        {
            var sb = new StringBuilder();
            sb.AppendLine("CAFETERÍA XYZ");
            sb.AppendLine($"Fecha: {DateTime.Now}");
            sb.AppendLine("Productos:");
            foreach (var item in _orderManager.Items)
            {
                sb.AppendLine($"- {item.ProductName} ({item.Size}) - {string.Join(", ", item.Extras)}: {item.TotalPrice:C}");
            }
            sb.AppendLine($"Total: {_orderManager.Total:C}");
            sb.AppendLine("¡Gracias por su compra!");
            return sb.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
