namespace CashierApplication
{
    partial class FrmPruchaseDiscountedItem
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
            this.iteem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelTAmount = new System.Windows.Forms.Label();
            this.TextLabelAmount = new System.Windows.Forms.Label();
            this.TextBoxItem = new System.Windows.Forms.TextBox();
            this.TextBoxQty = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.ButtonAddItem = new System.Windows.Forms.Button();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.labelPayment = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.TextBoxPayment = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.TextLabelChange = new System.Windows.Forms.Label();
            this.TextBoxDiscount = new System.Windows.Forms.TextBox();
            this.ButtonTotal = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Items_files)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Items_files
            // 
            this.Items_files.AllowUserToAddRows = false;
            this.Items_files.AllowUserToDeleteRows = false;
            this.Items_files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Items_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items_files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteem,
            this.qty,
            this.prc,
            this.dscnt,
            this.Amnt});
            this.Items_files.Location = new System.Drawing.Point(27, 46);
            this.Items_files.Name = "Items_files";
            this.Items_files.ReadOnly = true;
            this.Items_files.Size = new System.Drawing.Size(665, 362);
            this.Items_files.TabIndex = 0;
            // 
            // iteem
            // 
            this.iteem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iteem.FillWeight = 140F;
            this.iteem.HeaderText = "Item";
            this.iteem.Name = "iteem";
            this.iteem.ReadOnly = true;
            this.iteem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iteem.Width = 140;
            // 
            // qty
            // 
            this.qty.FillWeight = 30.65149F;
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // prc
            // 
            this.prc.FillWeight = 28.65149F;
            this.prc.HeaderText = "Price";
            this.prc.Name = "prc";
            this.prc.ReadOnly = true;
            // 
            // dscnt
            // 
            this.dscnt.FillWeight = 28.65149F;
            this.dscnt.HeaderText = "Discount";
            this.dscnt.Name = "dscnt";
            this.dscnt.ReadOnly = true;
            // 
            // Amnt
            // 
            this.Amnt.FillWeight = 28.65149F;
            this.Amnt.HeaderText = "TotalAmount";
            this.Amnt.Name = "Amnt";
            this.Amnt.ReadOnly = true;
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
            this.labelDiscount.Location = new System.Drawing.Point(734, 55);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(104, 20);
            this.labelDiscount.TabIndex = 4;
            this.labelDiscount.Text = "Discount (%):";
            // 
            // labelTAmount
            // 
            this.labelTAmount.AutoSize = true;
            this.labelTAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTAmount.Location = new System.Drawing.Point(735, 173);
            this.labelTAmount.Name = "labelTAmount";
            this.labelTAmount.Size = new System.Drawing.Size(95, 15);
            this.labelTAmount.TabIndex = 5;
            this.labelTAmount.Text = "Total Amount:";
            // 
            // TextLabelAmount
            // 
            this.TextLabelAmount.AutoSize = true;
            this.TextLabelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabelAmount.Location = new System.Drawing.Point(752, 205);
            this.TextLabelAmount.Name = "TextLabelAmount";
            this.TextLabelAmount.Size = new System.Drawing.Size(93, 16);
            this.TextLabelAmount.TabIndex = 6;
            this.TextLabelAmount.Text = "<total amount>";
            // 
            // TextBoxItem
            // 
            this.TextBoxItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxItem.Location = new System.Drawing.Point(65, 20);
            this.TextBoxItem.Name = "TextBoxItem";
            this.TextBoxItem.Size = new System.Drawing.Size(235, 22);
            this.TextBoxItem.TabIndex = 7;
            // 
            // TextBoxQty
            // 
            this.TextBoxQty.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxQty.Location = new System.Drawing.Point(475, 18);
            this.TextBoxQty.Name = "TextBoxQty";
            this.TextBoxQty.Size = new System.Drawing.Size(47, 22);
            this.TextBoxQty.TabIndex = 8;
            this.TextBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrice.Location = new System.Drawing.Point(599, 18);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(52, 22);
            this.TextBoxPrice.TabIndex = 9;
            this.TextBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonAddItem.Location = new System.Drawing.Point(26, 412);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(103, 28);
            this.ButtonAddItem.TabIndex = 10;
            this.ButtonAddItem.Text = "Add Item";
            this.ButtonAddItem.UseVisualStyleBackColor = false;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click_1);
            // 
            // buttonCompute
            // 
            this.buttonCompute.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCompute.Location = new System.Drawing.Point(737, 125);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(101, 28);
            this.buttonCompute.TabIndex = 11;
            this.buttonCompute.Text = "Compute";
            this.buttonCompute.UseVisualStyleBackColor = false;
            this.buttonCompute.Click += new System.EventHandler(this.ButtonCompute_Click);
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.Location = new System.Drawing.Point(726, 248);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(129, 15);
            this.labelPayment.TabIndex = 12;
            this.labelPayment.Text = "Payment Received:";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(726, 376);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(60, 15);
            this.labelChange.TabIndex = 13;
            this.labelChange.Text = "Change:";
            // 
            // TextBoxPayment
            // 
            this.TextBoxPayment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPayment.Location = new System.Drawing.Point(770, 280);
            this.TextBoxPayment.Name = "TextBoxPayment";
            this.TextBoxPayment.Size = new System.Drawing.Size(48, 22);
            this.TextBoxPayment.TabIndex = 14;
            this.TextBoxPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.LightCoral;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(755, 319);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 27);
            this.buttonSubmit.TabIndex = 15;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // TextLabelChange
            // 
            this.TextLabelChange.AutoSize = true;
            this.TextLabelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabelChange.Location = new System.Drawing.Point(790, 378);
            this.TextLabelChange.Name = "TextLabelChange";
            this.TextLabelChange.Size = new System.Drawing.Size(66, 16);
            this.TextLabelChange.TabIndex = 16;
            this.TextLabelChange.Text = "<change>";
            // 
            // TextBoxDiscount
            // 
            this.TextBoxDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxDiscount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDiscount.Location = new System.Drawing.Point(751, 88);
            this.TextBoxDiscount.Name = "TextBoxDiscount";
            this.TextBoxDiscount.Size = new System.Drawing.Size(66, 22);
            this.TextBoxDiscount.TabIndex = 17;
            this.TextBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonTotal
            // 
            this.ButtonTotal.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTotal.Location = new System.Drawing.Point(611, 414);
            this.ButtonTotal.Name = "ButtonTotal";
            this.ButtonTotal.Size = new System.Drawing.Size(81, 26);
            this.ButtonTotal.TabIndex = 19;
            this.ButtonTotal.Text = "Total";
            this.ButtonTotal.UseVisualStyleBackColor = false;
            this.ButtonTotal.Click += new System.EventHandler(this.ButtonTotal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logout,
            this.ExitApplicationToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.logoutToolStripMenuItem.Text = "↪";
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(180, 22);
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ExitApplicationToolStripMenuItem
            // 
            this.ExitApplicationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem";
            this.ExitApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitApplicationToolStripMenuItem.Text = "ExitApplication";
            this.ExitApplicationToolStripMenuItem.Click += new System.EventHandler(this.ExitApplicationToolStripMenuItem_Click);
            // 
            // FrmPruchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.ButtonTotal);
            this.Controls.Add(this.TextBoxDiscount);
            this.Controls.Add(this.TextLabelChange);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.TextBoxPayment);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.ButtonAddItem);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.TextBoxQty);
            this.Controls.Add(this.TextBoxItem);
            this.Controls.Add(this.TextLabelAmount);
            this.Controls.Add(this.labelTAmount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.Items_files);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPruchaseDiscountedItem";
            this.Text = "Purchase Discount Item";
            ((System.ComponentModel.ISupportInitialize)(this.Items_files)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label TextLabelAmount;
        private System.Windows.Forms.TextBox TextBoxItem;
        private System.Windows.Forms.TextBox TextBoxQty;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Button ButtonAddItem;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox TextBoxPayment;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label TextLabelChange;
        private System.Windows.Forms.TextBox TextBoxDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteem;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn prc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amnt;
        private System.Windows.Forms.Button ButtonTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.ToolStripMenuItem ExitApplicationToolStripMenuItem;
    }
}