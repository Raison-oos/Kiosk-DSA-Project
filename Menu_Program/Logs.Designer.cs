namespace Menu_Program
{
    partial class Logs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnTodayLogs = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.btnServe = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchPlaceholder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.White;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrders.Location = new System.Drawing.Point(12, 106);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(152, 37);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnTodayLogs
            // 
            this.btnTodayLogs.BackColor = System.Drawing.Color.White;
            this.btnTodayLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnTodayLogs.Location = new System.Drawing.Point(12, 170);
            this.btnTodayLogs.Name = "btnTodayLogs";
            this.btnTodayLogs.Size = new System.Drawing.Size(152, 44);
            this.btnTodayLogs.TabIndex = 1;
            this.btnTodayLogs.Text = "Today\'s Logs";
            this.btnTodayLogs.UseVisualStyleBackColor = false;
            this.btnTodayLogs.Click += new System.EventHandler(this.btnTodayLogs_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.White;
            this.btnLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogs.Location = new System.Drawing.Point(12, 243);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(152, 43);
            this.btnLogs.TabIndex = 2;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(188, 1);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(972, 632);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(16, 159);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 49);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalSales.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalSales.Location = new System.Drawing.Point(24, 38);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(112, 19);
            this.lblTotalSales.TabIndex = 5;
            this.lblTotalSales.Text = "label im a label";
            // 
            // btnServe
            // 
            this.btnServe.BackColor = System.Drawing.Color.White;
            this.btnServe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnServe.Location = new System.Drawing.Point(16, 97);
            this.btnServe.Name = "btnServe";
            this.btnServe.Size = new System.Drawing.Size(152, 41);
            this.btnServe.TabIndex = 6;
            this.btnServe.Text = "Serve";
            this.btnServe.UseVisualStyleBackColor = false;
            this.btnServe.Visible = false;
            this.btnServe.Click += new System.EventHandler(this.btnServe_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sort:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(15, 12);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(152, 20);
            this.txtSearchBar.TabIndex = 13;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalSales);
            this.panel1.Controls.Add(this.btnServe);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(-1, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 208);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSearchPlaceholder
            // 
            this.lblSearchPlaceholder.AutoSize = true;
            this.lblSearchPlaceholder.BackColor = System.Drawing.SystemColors.Window;
            this.lblSearchPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSearchPlaceholder.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSearchPlaceholder.Location = new System.Drawing.Point(16, 15);
            this.lblSearchPlaceholder.Name = "lblSearchPlaceholder";
            this.lblSearchPlaceholder.Size = new System.Drawing.Size(41, 13);
            this.lblSearchPlaceholder.TabIndex = 16;
            this.lblSearchPlaceholder.Text = "Search";
            this.lblSearchPlaceholder.Visible = false;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 632);
            this.Controls.Add(this.lblSearchPlaceholder);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnTodayLogs);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnTodayLogs;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Button btnServe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchPlaceholder;
    }
}