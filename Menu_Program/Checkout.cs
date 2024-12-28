using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Menu_Program
{
    public partial class Checkout : Form
    {
        Form f = null;
        public Checkout(Form f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            DisplayOrder();
            AssignButtonClick();
            this.BackColor = Color.FromArgb(253, 255, 182);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }
        private void DisplayOrder()
        {
            ResetDisplayOrder();
            int totalPrice = 0;

            for(int i = 0;i < DSA.currentOrder.Count;i++)
            {
                Product product = new Product(
                    DSA.currentOrder[i].name,
                    DSA.currentOrder[i].price, 
                    DSA.currentOrder[i].count, 
                    DSA.currentOrder[i].image);
                product.Location = new Point(0, 125*i);
                this.Controls.Add(product);
                totalPrice += (DSA.currentOrder[i].price * DSA.currentOrder[i].count);
            }
            lblTotalPrice.Text = "Total Price: PHP " + Convert.ToString(totalPrice);
            lblTotalPrice.Location = new Point(698, (125 * DSA.currentOrder.Count) + 10);


        }
        private void ResetDisplayOrder()
        {
            foreach (Product product in Controls.OfType<Product>())
            {
                this.Controls.Remove(product);
            }
        }
        private void AssignButtonClick()
        {
            foreach (Product product in Controls.OfType<Product>())
            {
                product.ButtonClick += new EventHandler(Product_ButtonClick);
            }
        }

        protected void Product_ButtonClick(object sender, EventArgs e)
        {
            DisplayOrder();
            AssignButtonClick();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(DSA.currentOrder.Count > 0) {
                DSA.orders.Enqueue(new CustomerOrder(DSA.currentOrder));
                DSA.todayLogs.Push(new CustomerOrder(DSA.currentOrder));
                DSA.overallLogs.Add(new CustomerOrder(DSA.currentOrder));
                MessageBox.Show("Order Added!");
                DSA.currentOrder.Clear();
                DisplayOrder();
                AssignButtonClick();
                btnBack.PerformClick();
            }
            else
            {
                MessageBox.Show("Add an Order First!");
                btnBack.PerformClick();
            }
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

    
    }
    
}
