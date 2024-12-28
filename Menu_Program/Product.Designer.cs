namespace Menu_Program
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Impact", 12F);
            this.btnPlus.Location = new System.Drawing.Point(768, 35);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 32);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lblCount.Location = new System.Drawing.Point(743, 43);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 21);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "0";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Impact", 12F);
            this.btnMinus.Location = new System.Drawing.Point(704, 35);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(33, 32);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.Location = new System.Drawing.Point(698, 81);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(99, 21);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "Total Price: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(274, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(108, 21);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "ProductPrice";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(274, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 21);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "ProductName";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(96, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(158, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(982, 125);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
