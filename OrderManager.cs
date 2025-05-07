using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomdad_Cafe
{
    public class OrderManager
    {
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
        public decimal Subtotal => Items.Sum(item => item.TotalPrice);
        public decimal IVA => Subtotal * 0.16m; 
        public decimal Total => Subtotal + IVA;

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void ClearOrder()
        {
            Items.Clear();
        }
    }
    public class OrderItem
    {
        public string ProductName { get; set; }
        public string Size { get; set; }
        public List<string> Extras { get; set; } = new List<string>();
        public decimal BasePrice { get; set; }
        public decimal ExtrasPrice { get; set; }
        public decimal TotalPrice => BasePrice + ExtrasPrice;
    }
}
