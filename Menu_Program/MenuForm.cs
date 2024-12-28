using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Menu_Program
{
    public partial class MenuForm : Form
    {

        private bool RiceMeals = false;
        private bool PastaMeals = false;
        private bool Burger = false;
        private bool Drinks = false;
        private bool Others = false;

        private int[] counts = new int[25];

        private Form checkout = null;
        private Form logs = null;

        public MenuForm()
        {
            InitializeComponent();
        }
        private void InitiateMenus()
        {
            //Rice Meals
            DSA.menus[0] = new Menu("Grilled Teriyaki Chicken", 120, "Rice meals", Properties.Resources.Rice_1);
            DSA.menus[1] = new Menu("Beef Bulbgogi Bowl", 100, "Rice meals", Properties.Resources.Rice_2);
            DSA.menus[2] = new Menu("Pork Adobo with Garlic Fried Rice", 110, "Rice meals", Properties.Resources.Rice_3);
            DSA.menus[3] = new Menu("Crispy Honey Garlic Fish", 100, "Rice meals", Properties.Resources.Rice_4);
            DSA.menus[4] = new Menu("Shrimp Curry Rice", 130, "Rice meals", Properties.Resources.Rice_5);
            //Pasta Meals
            DSA.menus[5] = new Menu("Classic Carbonara", 100, "Pasta meals", Properties.Resources.Pasta_1);
            DSA.menus[6] = new Menu("Pesto Chicken Linguini", 120, "Pasta meals", Properties.Resources.Pasta_2);
            DSA.menus[7] = new Menu("Shrimp Alfredo", 120, "Pasta meals", Properties.Resources.Pasta_3);
            DSA.menus[8] = new Menu("Spicy Arrabbiata Pasta", 100, "Pasta meals", Properties.Resources.Pasta_4);
            DSA.menus[9] = new Menu("Seafood Marinara", 130, "Pasta meals", Properties.Resources.Pasta_5);
            //Burgers
            DSA.menus[10] = new Menu("Classic Cheeseburger", 60, "Burgers", Properties.Resources.Burger_1);
            DSA.menus[11] = new Menu("BBQ Bacon Burger", 80, "Burgers", Properties.Resources.Burger_2);
            DSA.menus[12] = new Menu("Mushroom Swiss Burger", 60, "Burgers", Properties.Resources.Burger_3);
            DSA.menus[13] = new Menu("Spicy Chicken Burger", 100, "Burgers", Properties.Resources.Burger_4);
            DSA.menus[14] = new Menu("Vegan Bean Burger", 50, "Burgers", Properties.Resources.Burger_5);
            //Drinks
            DSA.menus[15] = new Menu("Tropical Sunset Punch", 30, "Drinks", Properties.Resources.Drinks_1);
            DSA.menus[16] = new Menu("Berry Citrus Fizz", 30, "Drinks", Properties.Resources.Drinks_2);
            DSA.menus[17] = new Menu("Lime Ginger Sparkler", 30, "Drinks", Properties.Resources.Drinks_3);
            DSA.menus[18] = new Menu("Peach Ice Green Tea", 30, "Drinks", Properties.Resources.Drinks_4);
            DSA.menus[19] = new Menu("Iced Tea", 30, "Drinks", Properties.Resources.Drinks_5);
            //Others
            DSA.menus[20] = new Menu("Rice", 15, "Others", Properties.Resources.Others_1);
            DSA.menus[21] = new Menu("Coleslaw", 10, "Others", Properties.Resources.Others_2);
            DSA.menus[22] = new Menu("Graham Bar", 35, "Others", Properties.Resources.Others_3);
            DSA.menus[23] = new Menu("Vanila Ice Cream", 30, "Others", Properties.Resources.Others_4);
            DSA.menus[24] = new Menu("Chocolate Ice Cream", 30, "Others", Properties.Resources.Others_5);
        }
        private void DisplayMenu(int start)
        {
            Label[] Description = new Label[5];
            Description[0] = lblDescription1;
            Description[1] = lblDescription2;
            Description[2] = lblDescription3;
            Description[3] = lblDescription4;
            Description[4] = lblDescription5;

            Label[] Price = new Label[5];
            Price[0] = lblPrice1;
            Price[1] = lblPrice2;
            Price[2] = lblPrice3;
            Price[3] = lblPrice4;
            Price[4] = lblPrice5;

            PictureBox[] Pictures = new PictureBox[5];
            Pictures[0] = pictureBox1;
            Pictures[1] = pictureBox2;
            Pictures[2] = pictureBox3;
            Pictures[3] = pictureBox4;
            Pictures[4] = pictureBox5;

            Label[] labels = new Label[5];
            labels[0] = lblCount1;
            labels[1] = lblCount2;
            labels[2] = lblCount3;
            labels[3] = lblCount4;
            labels[4] = lblCount5;


            for (int i = 0; i < 5; i++)
            {
                Description[i].Text = DSA.menus[start + i].name;
                Price[i].Text = "PHP " + DSA.menus[start + i].price.ToString();
                Pictures[i].Image = DSA.menus[start + i].image;

                if (DSA.currentOrder.Any(x => x.name == DSA.menus[start + i].name))
                {
                    int index = DSA.currentOrder.FindIndex(x => x.name == DSA.menus[start + i].name);
                    labels[i].Text = DSA.currentOrder[index].count.ToString();
                }
                else
                {
                    labels[i].Text = "0";
                }
            }

        }
        private void AddOrder(int n, bool add)
        {
            Label[] labels = new Label[5];
            labels[0] = lblCount1;
            labels[1] = lblCount2;
            labels[2] = lblCount3;
            labels[3] = lblCount4;
            labels[4] = lblCount5;

            int index;
            if (RiceMeals)
            {
                //edit order count
                if (DSA.currentOrder.Any(x => x.name == DSA.menus[n].name))
                {
                    index = DSA.currentOrder.FindIndex(x => x.name == DSA.menus[n].name);
                    if (add)
                    {
                        DSA.currentOrder[index].count++;
                        labels[n].Text = DSA.currentOrder[index].count.ToString();
                    }
                    else if (DSA.currentOrder[index].count != 1)
                    {
                        DSA.currentOrder[index].count--;
                        labels[n].Text = DSA.currentOrder[index].count.ToString();
                    }
                    else
                    {
                        DSA.currentOrder.RemoveAt(index);
                        labels[n].Text = "0";
                    }
                }
                //add new order
                else if (add)
                {
                    DSA.currentOrder.Add(new Order(
                        DSA.menus[n].name,
                        DSA.menus[n].price,
                        DSA.menus[n].category,
                        1,
                        DSA.menus[n].image));
                    index = DSA.currentOrder.Count;
                    labels[n].Text = DSA.currentOrder[index - 1].count.ToString();
                }
            }
            else if (PastaMeals)
            {
                //edit order count
                if (DSA.currentOrder.Any(x => x.name == DSA.menus[n + 5].name))
                {
                    index = DSA.currentOrder.FindIndex(x => x.name == DSA.menus[n + 5].name);
                    if (add)
                    {
                        DSA.currentOrder[index].count++;
                        labels[n].Text = DSA.currentOrder[index].count.ToString();
                    }
                    else if (DSA.currentOrder[index].count != 1)
                    {
                        DSA.currentOrder[index].count--;
                        labels[n].Text = DSA.currentOrder[index].count.ToString();
                    }
                    else
                    {
                        DSA.currentOrder.RemoveAt(index);
                        labels[n].Text = "0";
                    }
                }
                //add new order
                else if (add)
                {
                    DSA.currentOrder.Add(new Order(
                        DSA.menus[n + 5].name,
                        DSA.menus[n + 5].price,
                        DSA.menus[n + 5].category,
                        1,
                        DSA.menus[n + 5].image));
                    index = DSA.currentOrder.Count;
                    labels[n].Text = DSA.currentOrder[index - 1].count.ToString();
                }

            }
            else if (Burger)
            {
                //edit order count
                if (DSA.currentOrder.Any(x => x.name == DSA.menus[n + 10].name))
                {
                    index = DSA.currentOrder.FindIndex(x => x.name == DSA.menus[n + 10].name);
                    if (add)
                    {
                        DSA.currentOrder[index].count++;
                        labels[n].Text = DSA.currentOrder[index].count.ToString();
                    }
                    else if (DSA.currentOrder[index].count != 1)
                    {
                        DSA.currentOrder[index].count--;
                        labels[n].Text = DSA.currentOrder[index].count.ToString();
                    }
                    else
                    {
                        DSA.currentOrder.RemoveAt(index);
                        labels[n].Text = "0";
                    }
                }
                //add new order
                else if (add)
                {
                    DSA.currentOrder.Add(new Order(
                        DSA.menus[n + 10].name,
                        DSA.menus[n + 10].price,
                        DSA.menus[n + 10].category,
                        1,
                        DSA.menus[n + 10].image));
                    index = DSA.currentOrder.Count;
                    labels[n].Text = DSA.currentOrder[index - 1].count.ToString();
                }
            }
            else if (Drinks)
            {
                //edit order count
                if (DSA.currentOrder.Any(x => x.name == DSA.menus[n + 15].name))
                {
                    index = DSA.currentOrder.FindIndex(x => x.name == DSA.menus[n + 15].name);
                    if (add)
                    {
                        DSA.currentOrder[index].count++;
                        labels[n].Text = DSA.currentOrder[index].count.ToString();
                    }
                    else if (DSA.currentOrder[index].count != 1)
                    {
                        DSA.currentOrder[index].count--;
                        labels[n].Text = DSA.currentOrder[index].count.ToString();
                    }
                    else
                    {
                        DSA.currentOrder.RemoveAt(index);
                        labels[n].Text = "0";
                    }
                }
                //add new order
                else if (add)
                {
                    DSA.currentOrder.Add(new Order(
                        DSA.menus[n + 15].name,
                        DSA.menus[n + 15].price,
                        DSA.menus[n + 15].category,
                        1,
                        DSA.menus[n + 15].image));
                    index = DSA.currentOrder.Count;
                    labels[n].Text = DSA.currentOrder[index - 1].count.ToString();
                }
            }
            else if (Others)
            {
                //edit order count
                if (DSA.currentOrder.Any(x => x.name == DSA.menus[n + 20].name))
                {
                    index = DSA.currentOrder.FindIndex(x => x.name == DSA.menus[n + 20].name);
                    if (add)
                    {
                        DSA.currentOrder[index].count++;
                        labels[n].Text = DSA.currentOrder[index].count.ToString();
                    }
                    else if (DSA.currentOrder[index].count != 1)
                    {
                        DSA.currentOrder[index].count--;
                        labels[n].Text = DSA.currentOrder[index].count.ToString();
                    }
                    else
                    {
                        DSA.currentOrder.RemoveAt(index);
                        labels[n].Text = "0";
                    }
                }
                //add new order
                else if (add)
                {
                    DSA.currentOrder.Add(new Order(
                        DSA.menus[n + 20].name,
                        DSA.menus[n + 20].price,
                        DSA.menus[n + 20].category,
                        1,
                        DSA.menus[n + 20].image));
                    index = DSA.currentOrder.Count;
                    labels[n].Text = DSA.currentOrder[index - 1].count.ToString();
                }
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitiateMenus();
            DisplayMenu(0);
            RiceMeals = true;

            this.BackColor = Color.FromArgb(34, 34, 59);

  



        }


        //Rice Meals
        private void btnCategory1_Click(object sender, EventArgs e)
        {
            RiceMeals = true;
            PastaMeals = false;
            Burger = false;
            Drinks = false;
            Others = false;
            DisplayMenu(0);

        }

        //Pasta Meals
        private void btnCategory2_Click(object sender, EventArgs e)
        {
            PastaMeals = true;
            RiceMeals = false;
            Burger = false;
            Drinks = false;
            Others = false;
            DisplayMenu(5);
        }

        //Burgers
        private void btnCategory3_Click(object sender, EventArgs e)
        {
            Burger = true;
            PastaMeals = false;
            RiceMeals = false;
            Drinks = false;
            Others = false;
            DisplayMenu(10);
        }

        //Drinks
        private void btnCategory4_Click(object sender, EventArgs e)
        {
            Drinks = true;
            PastaMeals = false;
            RiceMeals = false;
            Burger = false;
            Others = false;
            DisplayMenu(15);
        }

        //Others
        private void btnCategory5_Click(object sender, EventArgs e)
        {
            Others = true;
            PastaMeals = false;
            RiceMeals = false;
            Burger = false;
            Drinks = false;
            DisplayMenu(20);
        }

        //Add Order
        private void btnPlus1_Click(object sender, EventArgs e)
        {
            AddOrder(0, true);
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            AddOrder(1, true);

        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            AddOrder(2, true);

        }

        private void btnPlus4_Click(object sender, EventArgs e)
        {
            AddOrder(3, true);

        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            AddOrder(4, true);
        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            AddOrder(0, false);
        }

        private void btnMinus2_Click(object sender, EventArgs e)
        {
            AddOrder(1, false);
        }

        private void btnMinus3_Click(object sender, EventArgs e)
        {
            AddOrder(2, false);
        }

        private void btnMinus4_Click(object sender, EventArgs e)
        {
            AddOrder(3, false);
        }

        private void btnMinus5_Click(object sender, EventArgs e)
        {
            AddOrder(4, false);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkout = new Checkout(this);
            checkout.Show();
        }

        private void MenuForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
                InitiateMenus();
            DisplayMenu(0);
            RiceMeals = true;
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            this.Hide();
            logs = new Logs(this);
            logs.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        // Design For Panels, Buttons, Background, Fonts, etc...
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20; // Example radius
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, panel1.Height - radius, radius, radius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Set graphics options for smoother drawing
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Color rgbColor = Color.FromArgb(238, 207, 217);
                using (Brush rgbBrush = new SolidBrush(rgbColor))
                {
                    // Fill the path with the RGB color
                    e.Graphics.FillPath(rgbBrush, path);
                }
                e.Graphics.DrawPath(Pens.Transparent, path); // Optional border
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20; // Example radius
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(panel2.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(panel2.Width - radius, panel1.Height - radius, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, panel2.Height - radius, radius, radius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Set graphics options for smoother drawing
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Color rgbColor = Color.FromArgb(230, 210, 223);
                using (Brush rgbBrush = new SolidBrush(rgbColor))
                {
                    // Fill the path with the RGB color
                    e.Graphics.FillPath(rgbBrush, path);
                }
                e.Graphics.DrawPath(Pens.Transparent, path); // Optional border
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20; // Example radius
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(panel3.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(panel3.Width - radius, panel1.Height - radius, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, panel3.Height - radius, radius, radius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Set graphics options for smoother drawing
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Color rgbColor = Color.FromArgb(223, 213, 228);
                using (Brush rgbBrush = new SolidBrush(rgbColor))
                {
                    // Fill the path with the RGB color
                    e.Graphics.FillPath(rgbBrush, path);
                }
                e.Graphics.DrawPath(Pens.Transparent, path); // Optional border
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20; // Example radius
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(panel4.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(panel4.Width - radius, panel1.Height - radius, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, panel4.Height - radius, radius, radius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Set graphics options for smoother drawing
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Color rgbColor = Color.FromArgb(230, 210, 223);
                using (Brush rgbBrush = new SolidBrush(rgbColor))
                {
                    // Fill the path with the RGB color
                    e.Graphics.FillPath(rgbBrush, path);
                }
                e.Graphics.DrawPath(Pens.Transparent, path); // Optional border
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20; // Example radius
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(panel5.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(panel5.Width - radius, panel1.Height - radius, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, panel5.Height - radius, radius, radius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Set graphics options for smoother drawing
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Color rgbColor = Color.FromArgb(216, 216, 233);
                using (Brush rgbBrush = new SolidBrush(rgbColor))
                {
                    // Fill the path with the RGB color
                    e.Graphics.FillPath(rgbBrush, path);
                }
                e.Graphics.DrawPath(Pens.Transparent, path); // Optional border
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20; // Example radius
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(panel6.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(panel6.Width - radius, panel1.Height - radius, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, panel6.Height - radius, radius, radius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Set graphics options for smoother drawing
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Color rgbColor = Color.FromArgb(253, 255, 182);
                using (Brush rgbBrush = new SolidBrush(rgbColor))
                {
                    // Fill the path with the RGB color
                    e.Graphics.FillPath(rgbBrush, path);
                }
                e.Graphics.DrawPath(Pens.Transparent, path); // Optional border
            }
        }
    }
}
