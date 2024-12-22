using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Program
{
    public partial class Product : UserControl
    {
        public Product(string name = "name", int price = 0, int count = 0, Image image = null)
        {
            InitializeComponent();
            lblName.Text = name;
            lblPrice.Text = "PHP " + price.ToString();
            lblCount.Text = count.ToString();
            lblTotalPrice.Text = "PHP " + (price * count).ToString();
            pictureBox.Image = image;
        }
        private void ModifyOrder(bool add)
        {
            int index = DSA.currentOrder.FindIndex(x => x.name == lblName.Text);
            if (add)
            {
                DSA.currentOrder[index].count++;
                lblCount.Text = DSA.currentOrder[index].count.ToString();
                lblPrice.Text = "PHP " + DSA.currentOrder[index].price.ToString();
                lblTotalPrice.Text = "PHP " + (DSA.currentOrder[index].price * DSA.currentOrder[index].count).ToString();
            }
            else if (DSA.currentOrder[index].count != 1)
            {
                DSA.currentOrder[index].count--;
                lblCount.Text = DSA.currentOrder[index].count.ToString();
                lblPrice.Text = "PHP " + DSA.currentOrder[index].price.ToString();
                lblTotalPrice.Text = "PHP " + (DSA.currentOrder[index].price * DSA.currentOrder[index].count).ToString();
            }
            else
            {
                DSA.currentOrder.RemoveAt(index);
                lblCount.Text = "0";
                this.Dispose(); 
            }
        }
        //event handler
        public event EventHandler ButtonClick;
        protected void btnPlus_Click(object sender, EventArgs e)
        {
            ModifyOrder(true);
            //bubble the event up to the parent
            ButtonClick?.Invoke(this, e);
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            ModifyOrder(false);
            //bubble the event up to the parent
            ButtonClick?.Invoke(this, e);
        }

    }
}
