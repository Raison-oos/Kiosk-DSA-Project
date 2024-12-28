using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Program
{
    public partial class Logs : Form
    {
        Form f = null;
        public Logs(Form f)
        {
            InitializeComponent();
            this.f = f;

        }
        private string orders;
        private Stack<CustomerOrder> tempStack = new Stack<CustomerOrder>();
        private HashSet<CustomerOrder> tempHashSet = new HashSet<CustomerOrder>();
        bool overallLogs, todaysLogs;

        private void btnOrders_Click(object sender, EventArgs e)
        {
            todaysLogs = false;
            overallLogs = false;
            label1.Visible = false;
            comboBox1.Visible = false;
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            orders = "";
            lblTotalSales.Visible = false;
            btnServe.Visible = true;
            lblSearchPlaceholder.Visible = false;
            txtSearchBar.Visible = false;

            dataGrid.Columns.Add("colNumber", "#");
            dataGrid.Columns.Add("colOrders", "Orders");
            ColumnUnsortable();

            //add the rows
            int i = 1;
            foreach(CustomerOrder list in DSA.orders)
            {
                foreach(Order order in list.orders)
                    orders = orders + order.name + " x" + order.count + "\n";
                dataGrid.Rows.Add(i,orders);
                orders = "";
                i++;
            }
        }
        private void btnTodayLogs_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Remove("Sort By Date");

            todaysLogs = true;
            overallLogs = false;
            
            label1.Visible = true;
            comboBox1.Visible = true;
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            orders = "";
            lblTotalSales.Text = "Total Sales: PHP ";
            lblTotalSales.Visible = true;
            btnServe.Visible = false;

            txtSearchBar.Visible = true;
            lblSearchPlaceholder.Visible = true;

            dataGrid.Columns.Add("colNumber", "#");
            dataGrid.Columns.Add("colOrders", "Orders");
            dataGrid.Columns.Add("colPrice", "Price");
            ColumnUnsortable();

            //add the rows
            int i = 1;
            int totalPrice = 0;
            int totalSales = 0;
            //tempStack = new Stack<CustomerOrder>(DSA.todayLogs);
            //foreach (CustomerOrder list in DSA.todayLogs)
            foreach (CustomerOrder list in tempStack)
            {
                foreach (Order order in list.orders)
                {
                    orders = orders + order.name + " x" + order.count + "\n";
                    totalPrice += order.price * order.count;
                    totalSales+= order.price * order.count;
                }
                if(list.timer == DateTime.Today.ToString("M-dd-yyyy"))
                        dataGrid.Rows.Add(i, orders, totalPrice);
                totalPrice = 0;
                orders = "";
                i++;
            }
            lblTotalSales.Text += totalSales.ToString();
            totalSales = 0;
        }
        
        private void btnLogs_Click(object sender, EventArgs e)
        {
            //if(!comboBox1.Items.Contains("Sort By Date"))
            //    comboBox1.Items.Add("Sort By Date");

            todaysLogs = false;
            overallLogs = true;
            label1.Visible = true;
            comboBox1.Visible = true;
            dataGrid.Columns.Clear();
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            orders = "";
            lblTotalSales.Visible = false;
            btnServe.Visible = false;

            lblSearchPlaceholder.Visible = true;
            txtSearchBar.Visible = true;

            dataGrid.Columns.Add("colNumber", "#");
            dataGrid.Columns.Add("colOrders", "Orders");
            dataGrid.Columns.Add("colCount", "Price");
            dataGrid.Columns.Add("colDate", "Date");
            ColumnUnsortable();

            //add the rows
            int i = 1;
            int totalPrice = 0;
            foreach(CustomerOrder list in tempHashSet)
            {
                foreach(Order order in list.orders)
                {
                    orders = orders + order.name + " x" + order.count + "\n";
                    totalPrice += order.price * order.count;
                }
                dataGrid.Rows.Add(i,orders, totalPrice, list.timer);
                orders = "";
                totalPrice = 0;
                i++;
            }

        }
        private void Logs_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Default");
            comboBox1.Items.Add("Sort By Price");
            //comboBox1.Items.Add("Sort By Date");
            comboBox1.Text = "Default";

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            btnOrders.PerformClick();

            this.BackColor = Color.FromArgb(34, 34, 59);

        }
        
        private void ColumnUnsortable()
        {
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void btnServe_Click(object sender, EventArgs e)
        {
            if(DSA.orders.Count > 0)
                DSA.orders.Dequeue();
            btnOrders.PerformClick();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchBar.Text == "")
            {
                lblSearchPlaceholder.Text = "Search";
            }
            else
            {
                lblSearchPlaceholder.Text = "";

            }
            tempHashSet.Clear();
            tempStack.Clear();

            if((txtSearchBar.Text == ""))
            {
                tempHashSet = new HashSet<CustomerOrder>(DSA.overallLogs);
                tempStack = new Stack<CustomerOrder>(DSA.todayLogs);
                if(todaysLogs)
                    btnTodayLogs.PerformClick();
                else if(overallLogs)
                    btnLogs.PerformClick();
            }
            else if (todaysLogs)
            {
                tempStack= Searching.Search(DSA.todayLogs, txtSearchBar.Text);
                tempHashSet = new HashSet<CustomerOrder>(DSA.overallLogs);
                btnTodayLogs.PerformClick();
            }
            else if (overallLogs)
            {
                tempHashSet = Searching.Search(DSA.overallLogs, txtSearchBar.Text);
                tempStack = new Stack<CustomerOrder>(DSA.todayLogs);
                btnLogs.PerformClick();
            }

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.BackColor = Color.FromArgb(253, 255, 182);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(34, 34, 59);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(253, 255, 182);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Default":
                    tempHashSet.Clear();
                    tempStack.Clear();
                    tempHashSet = new HashSet<CustomerOrder>(DSA.overallLogs);
                    tempStack = new Stack<CustomerOrder>(DSA.todayLogs);
                    if(todaysLogs)
                        btnTodayLogs.PerformClick();
                    else if(overallLogs)
                        btnLogs.PerformClick();
                    break;
                case "Sort By Price":
                    tempHashSet.Clear();
                    tempStack.Clear();
                    tempHashSet = Sorting.InsertionSort(DSA.overallLogs);
                    tempStack = Sorting.BubbleSort(DSA.todayLogs);
                    if(todaysLogs)
                        btnTodayLogs.PerformClick();
                    else if(overallLogs)
                        btnLogs.PerformClick();
                    break;
                //case "Sort By Date":
                //    tempHashSet.Clear();
                //    tempHashSet = Sorting.SelectionSort(DSA.overallLogs);
                //    break;

            }
        }
    }
}
