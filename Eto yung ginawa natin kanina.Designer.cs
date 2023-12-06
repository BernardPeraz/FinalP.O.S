namespace CashierApplication
{
    partial class Form2
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
            this.Items_files = new System.Windows.Forms.DataGridView();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelTAmount = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.labelPayment = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelChng = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Items_files)).BeginInit();
            this.SuspendLayout();
            // 
            // Items_files
            // 
            this.Items_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items_files.Location = new System.Drawing.Point(26, 44);
            this.Items_files.Name = "Items_files";
            this.Items_files.Size = new System.Drawing.Size(647, 362);
            this.Items_files.TabIndex = 0;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelItem.Location = new System.Drawing.Point(23, 18);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(45, 20);
            this.labelItem.TabIndex = 1;
            this.labelItem.Text = "Item:";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelQty.Location = new System.Drawing.Point(436, 18);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(37, 20);
            this.labelQty.TabIndex = 2;
            this.labelQty.Text = "Qty:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPrice.Location = new System.Drawing.Point(555, 18);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 20);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price:";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDiscount.Location = new System.Drawing.Point(722, 56);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(104, 20);
            this.labelDiscount.TabIndex = 4;
            this.labelDiscount.Text = "Discount (%):";
            // 
            // labelTAmount
            // 
            this.labelTAmount.AutoSize = true;
            this.labelTAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTAmount.Location = new System.Drawing.Point(679, 195);
            this.labelTAmount.Name = "labelTAmount";
            this.labelTAmount.Size = new System.Drawing.Size(95, 15);
            this.labelTAmount.TabIndex = 5;
            this.labelTAmount.Text = "Total Amount:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(779, 197);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(77, 13);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "<total amount>";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(65, 20);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(235, 20);
            this.textBoxItem.TabIndex = 7;
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(475, 18);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(47, 20);
            this.textBoxQty.TabIndex = 8;
            this.textBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(599, 18);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(52, 20);
            this.textBoxPrice.TabIndex = 9;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddItem.Location = new System.Drawing.Point(26, 412);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(103, 28);
            this.buttonAddItem.TabIndex = 10;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // buttonCompute
            // 
            this.buttonCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCompute.Location = new System.Drawing.Point(725, 141);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(101, 28);
            this.buttonCompute.TabIndex = 11;
            this.buttonCompute.Text = "Compute";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.Location = new System.Drawing.Point(681, 259);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(129, 15);
            this.labelPayment.TabIndex = 12;
            this.labelPayment.Text = "Payment Received:";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(683, 362);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(60, 15);
            this.labelChange.TabIndex = 13;
            this.labelChange.Text = "Change:";
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(806, 258);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(48, 20);
            this.textBoxPayment.TabIndex = 14;
            this.textBoxPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(735, 288);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 27);
            this.buttonSubmit.TabIndex = 15;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelChng
            // 
            this.labelChng.AutoSize = true;
            this.labelChng.Location = new System.Drawing.Point(757, 364);
            this.labelChng.Name = "labelChng";
            this.labelChng.Size = new System.Drawing.Size(55, 13);
            this.labelChng.TabIndex = 16;
            this.labelChng.Text = "<change>";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxDiscount.Location = new System.Drawing.Point(735, 94);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(66, 20);
            this.textBoxDiscount.TabIndex = 17;
            this.textBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelChng);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelTAmount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.Items_files);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Items_files)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Items_files;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelChng;
        private System.Windows.Forms.TextBox textBoxDiscount;
    }
}