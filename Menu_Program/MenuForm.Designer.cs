using System.Drawing;

namespace Menu_Program
{
    partial class MenuForm
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
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnMinus1 = new System.Windows.Forms.Button();
            this.btnPlus1 = new System.Windows.Forms.Button();
            this.lblPrice5 = new System.Windows.Forms.Label();
            this.lblPrice4 = new System.Windows.Forms.Label();
            this.lblPrice3 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblDescription5 = new System.Windows.Forms.Label();
            this.lblDescription4 = new System.Windows.Forms.Label();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.btnCategory4 = new System.Windows.Forms.Button();
            this.btnCategory5 = new System.Windows.Forms.Button();
            this.btnCategory1 = new System.Windows.Forms.Button();
            this.btnCategory2 = new System.Windows.Forms.Button();
            this.btnCategory3 = new System.Windows.Forms.Button();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.btnMinus2 = new System.Windows.Forms.Button();
            this.btnPlus2 = new System.Windows.Forms.Button();
            this.lblCount3 = new System.Windows.Forms.Label();
            this.btnMinus3 = new System.Windows.Forms.Button();
            this.btnPlus3 = new System.Windows.Forms.Button();
            this.lblCount5 = new System.Windows.Forms.Label();
            this.btnMinus5 = new System.Windows.Forms.Button();
            this.btnPlus5 = new System.Windows.Forms.Button();
            this.lblCount4 = new System.Windows.Forms.Label();
            this.btnMinus4 = new System.Windows.Forms.Button();
            this.btnPlus4 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogs = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.White;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckout.Location = new System.Drawing.Point(140, 559);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(759, 44);
            this.btnCheckout.TabIndex = 45;
            this.btnCheckout.Text = "CheckOut";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnMinus1
            // 
            this.btnMinus1.BackColor = System.Drawing.Color.White;
            this.btnMinus1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus1.Location = new System.Drawing.Point(86, 179);
            this.btnMinus1.Name = "btnMinus1";
            this.btnMinus1.Size = new System.Drawing.Size(45, 41);
            this.btnMinus1.TabIndex = 44;
            this.btnMinus1.Text = "-";
            this.btnMinus1.UseVisualStyleBackColor = false;
            this.btnMinus1.Click += new System.EventHandler(this.btnMinus1_Click);
            // 
            // btnPlus1
            // 
            this.btnPlus1.BackColor = System.Drawing.Color.White;
            this.btnPlus1.Font = new System.Drawing.Font("Impact", 12F);
            this.btnPlus1.Location = new System.Drawing.Point(171, 179);
            this.btnPlus1.Name = "btnPlus1";
            this.btnPlus1.Size = new System.Drawing.Size(46, 41);
            this.btnPlus1.TabIndex = 43;
            this.btnPlus1.Text = "+";
            this.btnPlus1.UseVisualStyleBackColor = false;
            this.btnPlus1.Click += new System.EventHandler(this.btnPlus1_Click);
            // 
            // lblPrice5
            // 
            this.lblPrice5.AutoSize = true;
            this.lblPrice5.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice5.Location = new System.Drawing.Point(16, 188);
            this.lblPrice5.Name = "lblPrice5";
            this.lblPrice5.Size = new System.Drawing.Size(50, 19);
            this.lblPrice5.TabIndex = 42;
            this.lblPrice5.Text = "label5";
            // 
            // lblPrice4
            // 
            this.lblPrice4.AutoSize = true;
            this.lblPrice4.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice4.Location = new System.Drawing.Point(13, 183);
            this.lblPrice4.Name = "lblPrice4";
            this.lblPrice4.Size = new System.Drawing.Size(50, 19);
            this.lblPrice4.TabIndex = 41;
            this.lblPrice4.Text = "label4";
            // 
            // lblPrice3
            // 
            this.lblPrice3.AutoSize = true;
            this.lblPrice3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice3.Location = new System.Drawing.Point(13, 194);
            this.lblPrice3.Name = "lblPrice3";
            this.lblPrice3.Size = new System.Drawing.Size(50, 19);
            this.lblPrice3.TabIndex = 40;
            this.lblPrice3.Text = "label3";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Location = new System.Drawing.Point(16, 193);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(50, 19);
            this.lblPrice2.TabIndex = 39;
            this.lblPrice2.Text = "label2";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice1.Location = new System.Drawing.Point(13, 190);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(50, 19);
            this.lblPrice1.TabIndex = 38;
            this.lblPrice1.Text = "label1";
            // 
            // lblDescription5
            // 
            this.lblDescription5.AutoSize = true;
            this.lblDescription5.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription5.Location = new System.Drawing.Point(32, 144);
            this.lblDescription5.Name = "lblDescription5";
            this.lblDescription5.Size = new System.Drawing.Size(57, 21);
            this.lblDescription5.TabIndex = 37;
            this.lblDescription5.Text = "label5";
            // 
            // lblDescription4
            // 
            this.lblDescription4.AutoSize = true;
            this.lblDescription4.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription4.Location = new System.Drawing.Point(30, 144);
            this.lblDescription4.Name = "lblDescription4";
            this.lblDescription4.Size = new System.Drawing.Size(51, 19);
            this.lblDescription4.TabIndex = 35;
            this.lblDescription4.Text = "label4";
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription3.Location = new System.Drawing.Point(19, 145);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(40, 16);
            this.lblDescription3.TabIndex = 33;
            this.lblDescription3.Text = "label3";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription2.Location = new System.Drawing.Point(16, 140);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(57, 21);
            this.lblDescription2.TabIndex = 31;
            this.lblDescription2.Text = "label2";
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.Location = new System.Drawing.Point(13, 140);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(57, 21);
            this.lblDescription1.TabIndex = 29;
            this.lblDescription1.Text = "label1";
            // 
            // btnCategory4
            // 
            this.btnCategory4.BackColor = System.Drawing.Color.White;
            this.btnCategory4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.btnCategory4.Location = new System.Drawing.Point(23, 359);
            this.btnCategory4.Name = "btnCategory4";
            this.btnCategory4.Size = new System.Drawing.Size(93, 70);
            this.btnCategory4.TabIndex = 26;
            this.btnCategory4.Text = "Drinks";
            this.btnCategory4.UseVisualStyleBackColor = false;
            this.btnCategory4.Click += new System.EventHandler(this.btnCategory4_Click);
            // 
            // btnCategory5
            // 
            this.btnCategory5.BackColor = System.Drawing.Color.White;
            this.btnCategory5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.btnCategory5.Location = new System.Drawing.Point(23, 451);
            this.btnCategory5.Name = "btnCategory5";
            this.btnCategory5.Size = new System.Drawing.Size(93, 71);
            this.btnCategory5.TabIndex = 27;
            this.btnCategory5.Text = "Others";
            this.btnCategory5.UseVisualStyleBackColor = false;
            this.btnCategory5.Click += new System.EventHandler(this.btnCategory5_Click);
            // 
            // btnCategory1
            // 
            this.btnCategory1.BackColor = System.Drawing.Color.White;
            this.btnCategory1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.btnCategory1.Location = new System.Drawing.Point(23, 28);
            this.btnCategory1.Name = "btnCategory1";
            this.btnCategory1.Size = new System.Drawing.Size(93, 70);
            this.btnCategory1.TabIndex = 23;
            this.btnCategory1.Text = "Rice Meals";
            this.btnCategory1.UseVisualStyleBackColor = false;
            this.btnCategory1.Click += new System.EventHandler(this.btnCategory1_Click);
            // 
            // btnCategory2
            // 
            this.btnCategory2.BackColor = System.Drawing.Color.White;
            this.btnCategory2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.btnCategory2.Location = new System.Drawing.Point(23, 146);
            this.btnCategory2.Name = "btnCategory2";
            this.btnCategory2.Size = new System.Drawing.Size(93, 68);
            this.btnCategory2.TabIndex = 24;
            this.btnCategory2.Text = "Pasta Meals";
            this.btnCategory2.UseVisualStyleBackColor = false;
            this.btnCategory2.Click += new System.EventHandler(this.btnCategory2_Click);
            // 
            // btnCategory3
            // 
            this.btnCategory3.BackColor = System.Drawing.Color.White;
            this.btnCategory3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.btnCategory3.Location = new System.Drawing.Point(23, 259);
            this.btnCategory3.Name = "btnCategory3";
            this.btnCategory3.Size = new System.Drawing.Size(93, 69);
            this.btnCategory3.TabIndex = 25;
            this.btnCategory3.Text = "Burgers";
            this.btnCategory3.UseVisualStyleBackColor = false;
            this.btnCategory3.Click += new System.EventHandler(this.btnCategory3_Click);
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount1.Location = new System.Drawing.Point(137, 183);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(29, 31);
            this.lblCount1.TabIndex = 46;
            this.lblCount1.Text = "0";
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount2.Location = new System.Drawing.Point(140, 188);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(29, 31);
            this.lblCount2.TabIndex = 49;
            this.lblCount2.Text = "0";
            // 
            // btnMinus2
            // 
            this.btnMinus2.BackColor = System.Drawing.Color.White;
            this.btnMinus2.Font = new System.Drawing.Font("Impact", 12F);
            this.btnMinus2.Location = new System.Drawing.Point(88, 185);
            this.btnMinus2.Name = "btnMinus2";
            this.btnMinus2.Size = new System.Drawing.Size(45, 40);
            this.btnMinus2.TabIndex = 48;
            this.btnMinus2.Text = "-";
            this.btnMinus2.UseVisualStyleBackColor = false;
            this.btnMinus2.Click += new System.EventHandler(this.btnMinus2_Click);
            // 
            // btnPlus2
            // 
            this.btnPlus2.BackColor = System.Drawing.Color.White;
            this.btnPlus2.Font = new System.Drawing.Font("Impact", 12F);
            this.btnPlus2.Location = new System.Drawing.Point(175, 183);
            this.btnPlus2.Name = "btnPlus2";
            this.btnPlus2.Size = new System.Drawing.Size(45, 40);
            this.btnPlus2.TabIndex = 47;
            this.btnPlus2.Text = "+";
            this.btnPlus2.UseVisualStyleBackColor = false;
            this.btnPlus2.Click += new System.EventHandler(this.btnPlus2_Click);
            // 
            // lblCount3
            // 
            this.lblCount3.AutoSize = true;
            this.lblCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount3.Location = new System.Drawing.Point(138, 192);
            this.lblCount3.Name = "lblCount3";
            this.lblCount3.Size = new System.Drawing.Size(29, 31);
            this.lblCount3.TabIndex = 52;
            this.lblCount3.Text = "0";
            // 
            // btnMinus3
            // 
            this.btnMinus3.BackColor = System.Drawing.Color.White;
            this.btnMinus3.Font = new System.Drawing.Font("Impact", 12F);
            this.btnMinus3.Location = new System.Drawing.Point(87, 188);
            this.btnMinus3.Name = "btnMinus3";
            this.btnMinus3.Size = new System.Drawing.Size(45, 40);
            this.btnMinus3.TabIndex = 51;
            this.btnMinus3.Text = "-";
            this.btnMinus3.UseVisualStyleBackColor = false;
            this.btnMinus3.Click += new System.EventHandler(this.btnMinus3_Click);
            // 
            // btnPlus3
            // 
            this.btnPlus3.BackColor = System.Drawing.Color.White;
            this.btnPlus3.Font = new System.Drawing.Font("Impact", 12F);
            this.btnPlus3.Location = new System.Drawing.Point(173, 187);
            this.btnPlus3.Name = "btnPlus3";
            this.btnPlus3.Size = new System.Drawing.Size(45, 41);
            this.btnPlus3.TabIndex = 50;
            this.btnPlus3.Text = "+";
            this.btnPlus3.UseVisualStyleBackColor = false;
            this.btnPlus3.Click += new System.EventHandler(this.btnPlus3_Click);
            // 
            // lblCount5
            // 
            this.lblCount5.AutoSize = true;
            this.lblCount5.BackColor = System.Drawing.Color.Transparent;
            this.lblCount5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount5.Location = new System.Drawing.Point(140, 181);
            this.lblCount5.Name = "lblCount5";
            this.lblCount5.Size = new System.Drawing.Size(29, 31);
            this.lblCount5.TabIndex = 55;
            this.lblCount5.Text = "0";
            // 
            // btnMinus5
            // 
            this.btnMinus5.BackColor = System.Drawing.Color.White;
            this.btnMinus5.Font = new System.Drawing.Font("Impact", 12F);
            this.btnMinus5.Location = new System.Drawing.Point(88, 178);
            this.btnMinus5.Name = "btnMinus5";
            this.btnMinus5.Size = new System.Drawing.Size(45, 37);
            this.btnMinus5.TabIndex = 54;
            this.btnMinus5.Text = "-";
            this.btnMinus5.UseVisualStyleBackColor = false;
            this.btnMinus5.Click += new System.EventHandler(this.btnMinus5_Click);
            // 
            // btnPlus5
            // 
            this.btnPlus5.BackColor = System.Drawing.Color.White;
            this.btnPlus5.Font = new System.Drawing.Font("Impact", 12F);
            this.btnPlus5.Location = new System.Drawing.Point(175, 178);
            this.btnPlus5.Name = "btnPlus5";
            this.btnPlus5.Size = new System.Drawing.Size(45, 37);
            this.btnPlus5.TabIndex = 53;
            this.btnPlus5.Text = "+";
            this.btnPlus5.UseVisualStyleBackColor = false;
            this.btnPlus5.Click += new System.EventHandler(this.btnPlus5_Click);
            // 
            // lblCount4
            // 
            this.lblCount4.AutoSize = true;
            this.lblCount4.BackColor = System.Drawing.Color.Transparent;
            this.lblCount4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount4.Location = new System.Drawing.Point(136, 171);
            this.lblCount4.Name = "lblCount4";
            this.lblCount4.Size = new System.Drawing.Size(0, 31);
            this.lblCount4.TabIndex = 58;
            // 
            // btnMinus4
            // 
            this.btnMinus4.BackColor = System.Drawing.Color.White;
            this.btnMinus4.Font = new System.Drawing.Font("Impact", 12F);
            this.btnMinus4.Location = new System.Drawing.Point(86, 167);
            this.btnMinus4.Name = "btnMinus4";
            this.btnMinus4.Size = new System.Drawing.Size(45, 39);
            this.btnMinus4.TabIndex = 57;
            this.btnMinus4.Text = "-";
            this.btnMinus4.UseVisualStyleBackColor = false;
            this.btnMinus4.Click += new System.EventHandler(this.btnMinus4_Click);
            // 
            // btnPlus4
            // 
            this.btnPlus4.BackColor = System.Drawing.Color.White;
            this.btnPlus4.Font = new System.Drawing.Font("Impact", 12F);
            this.btnPlus4.Location = new System.Drawing.Point(171, 167);
            this.btnPlus4.Name = "btnPlus4";
            this.btnPlus4.Size = new System.Drawing.Size(46, 39);
            this.btnPlus4.TabIndex = 56;
            this.btnPlus4.Text = "+";
            this.btnPlus4.UseVisualStyleBackColor = false;
            this.btnPlus4.Click += new System.EventHandler(this.btnPlus4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(19, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(201, 112);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(16, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(201, 112);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(20, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(931, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 22);
            this.btnExit.TabIndex = 60;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblDescription3);
            this.panel1.Controls.Add(this.lblPrice1);
            this.panel1.Controls.Add(this.btnPlus1);
            this.panel1.Controls.Add(this.btnMinus1);
            this.panel1.Controls.Add(this.lblCount1);
            this.panel1.Location = new System.Drawing.Point(140, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 238);
            this.panel1.TabIndex = 61;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(16, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblPrice2);
            this.panel2.Controls.Add(this.lblDescription2);
            this.panel2.Controls.Add(this.btnPlus2);
            this.panel2.Controls.Add(this.btnMinus2);
            this.panel2.Controls.Add(this.lblCount2);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(403, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 238);
            this.panel2.TabIndex = 62;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblDescription1);
            this.panel3.Controls.Add(this.lblPrice3);
            this.panel3.Controls.Add(this.btnPlus3);
            this.panel3.Controls.Add(this.btnMinus3);
            this.panel3.Controls.Add(this.lblCount3);
            this.panel3.Location = new System.Drawing.Point(662, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 238);
            this.panel3.TabIndex = 63;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.btnPlus4);
            this.panel4.Controls.Add(this.lblDescription4);
            this.panel4.Controls.Add(this.lblPrice4);
            this.panel4.Controls.Add(this.btnMinus4);
            this.panel4.Controls.Add(this.lblCount4);
            this.panel4.Location = new System.Drawing.Point(140, 294);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 238);
            this.panel4.TabIndex = 64;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.btnPlus5);
            this.panel5.Controls.Add(this.lblDescription5);
            this.panel5.Controls.Add(this.lblPrice5);
            this.panel5.Controls.Add(this.btnMinus5);
            this.panel5.Controls.Add(this.lblCount5);
            this.panel5.Location = new System.Drawing.Point(403, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 238);
            this.panel5.TabIndex = 65;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.White;
            this.btnLogs.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnLogs.FlatAppearance.BorderSize = 4;
            this.btnLogs.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogs.Location = new System.Drawing.Point(23, 550);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(93, 53);
            this.btnLogs.TabIndex = 59;
            this.btnLogs.Text = "Order Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(128, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(841, 632);
            this.panel6.TabIndex = 66;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 632);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCategory4);
            this.Controls.Add(this.btnCategory5);
            this.Controls.Add(this.btnCategory1);
            this.Controls.Add(this.btnCategory2);
            this.Controls.Add(this.btnCategory3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.MenuForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnMinus1;
        private System.Windows.Forms.Button btnPlus1;
        private System.Windows.Forms.Label lblPrice5;
        private System.Windows.Forms.Label lblPrice4;
        private System.Windows.Forms.Label lblPrice3;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblDescription5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblDescription4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblDescription3;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCategory4;
        private System.Windows.Forms.Button btnCategory5;
        private System.Windows.Forms.Button btnCategory1;
        private System.Windows.Forms.Button btnCategory2;
        private System.Windows.Forms.Button btnCategory3;
        private System.Windows.Forms.Label lblCount1;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Button btnMinus2;
        private System.Windows.Forms.Button btnPlus2;
        private System.Windows.Forms.Label lblCount3;
        private System.Windows.Forms.Button btnMinus3;
        private System.Windows.Forms.Button btnPlus3;
        private System.Windows.Forms.Label lblCount5;
        private System.Windows.Forms.Button btnMinus5;
        private System.Windows.Forms.Button btnPlus5;
        private System.Windows.Forms.Label lblCount4;
        private System.Windows.Forms.Button btnMinus4;
        private System.Windows.Forms.Button btnPlus4;
        private System.Windows.Forms.Button btnExit;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Panel panel6;
    }
}