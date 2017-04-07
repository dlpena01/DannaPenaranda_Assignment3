namespace DannaPenaranda_Assignment3
{
    partial class Form1
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
            this.elecTabControl1 = new System.Windows.Forms.TabControl();
            this.productTab = new System.Windows.Forms.TabPage();
            this.displayTextBx = new System.Windows.Forms.TextBox();
            this.productLstBx = new System.Windows.Forms.ListBox();
            this.shoppingTab = new System.Windows.Forms.TabPage();
            this.lblforDelivery = new System.Windows.Forms.Label();
            this.lblExpectDeliveryDate = new System.Windows.Forms.Label();
            this.lblforTotal = new System.Windows.Forms.Label();
            this.lblforShipping = new System.Windows.Forms.Label();
            this.lblforDiscount = new System.Windows.Forms.Label();
            this.lblforSaleTax = new System.Windows.Forms.Label();
            this.lblforSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.deliveryCmBx = new System.Windows.Forms.ComboBox();
            this.shopCartLstBx = new System.Windows.Forms.ListBox();
            this.elecTabControl1.SuspendLayout();
            this.productTab.SuspendLayout();
            this.shoppingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // elecTabControl1
            // 
            this.elecTabControl1.Controls.Add(this.productTab);
            this.elecTabControl1.Controls.Add(this.shoppingTab);
            this.elecTabControl1.Location = new System.Drawing.Point(12, 12);
            this.elecTabControl1.Name = "elecTabControl1";
            this.elecTabControl1.SelectedIndex = 0;
            this.elecTabControl1.Size = new System.Drawing.Size(546, 370);
            this.elecTabControl1.TabIndex = 0;
            // 
            // productTab
            // 
            this.productTab.Controls.Add(this.displayTextBx);
            this.productTab.Controls.Add(this.productLstBx);
            this.productTab.Location = new System.Drawing.Point(4, 22);
            this.productTab.Name = "productTab";
            this.productTab.Padding = new System.Windows.Forms.Padding(3);
            this.productTab.Size = new System.Drawing.Size(538, 344);
            this.productTab.TabIndex = 0;
            this.productTab.Text = "Select Products:";
            this.productTab.UseVisualStyleBackColor = true;
            // 
            // displayTextBx
            // 
            this.displayTextBx.AccessibleName = "";
            this.displayTextBx.BackColor = System.Drawing.Color.Gainsboro;
            this.displayTextBx.Location = new System.Drawing.Point(270, 20);
            this.displayTextBx.Multiline = true;
            this.displayTextBx.Name = "displayTextBx";
            this.displayTextBx.ReadOnly = true;
            this.displayTextBx.Size = new System.Drawing.Size(204, 69);
            this.displayTextBx.TabIndex = 1;
            // 
            // productLstBx
            // 
            this.productLstBx.FormattingEnabled = true;
            this.productLstBx.Items.AddRange(new object[] {
            "Microsoft Surface Pro",
            "Apple iPad Air",
            "Samsung Galaxy Tab 3",
            "Google Nexus 7",
            "Amazon Kindle Fire HD"});
            this.productLstBx.Location = new System.Drawing.Point(15, 20);
            this.productLstBx.Name = "productLstBx";
            this.productLstBx.Size = new System.Drawing.Size(170, 69);
            this.productLstBx.TabIndex = 0;
            this.productLstBx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productLstBx_MouseClick);
            this.productLstBx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productLstBx_MouseDoubleClick);
            // 
            // shoppingTab
            // 
            this.shoppingTab.Controls.Add(this.lblforDelivery);
            this.shoppingTab.Controls.Add(this.lblExpectDeliveryDate);
            this.shoppingTab.Controls.Add(this.lblforTotal);
            this.shoppingTab.Controls.Add(this.lblforShipping);
            this.shoppingTab.Controls.Add(this.lblforDiscount);
            this.shoppingTab.Controls.Add(this.lblforSaleTax);
            this.shoppingTab.Controls.Add(this.lblforSubtotal);
            this.shoppingTab.Controls.Add(this.lblTotal);
            this.shoppingTab.Controls.Add(this.lblShipping);
            this.shoppingTab.Controls.Add(this.lblDiscount);
            this.shoppingTab.Controls.Add(this.lblSalesTax);
            this.shoppingTab.Controls.Add(this.lblSubtotal);
            this.shoppingTab.Controls.Add(this.monthCalendar1);
            this.shoppingTab.Controls.Add(this.btnReset);
            this.shoppingTab.Controls.Add(this.btnPurchase);
            this.shoppingTab.Controls.Add(this.deliveryCmBx);
            this.shoppingTab.Controls.Add(this.shopCartLstBx);
            this.shoppingTab.Location = new System.Drawing.Point(4, 22);
            this.shoppingTab.Name = "shoppingTab";
            this.shoppingTab.Padding = new System.Windows.Forms.Padding(3);
            this.shoppingTab.Size = new System.Drawing.Size(538, 344);
            this.shoppingTab.TabIndex = 1;
            this.shoppingTab.Text = "My Shopping Cart:";
            this.shoppingTab.UseVisualStyleBackColor = true;
            // 
            // lblforDelivery
            // 
            this.lblforDelivery.AutoSize = true;
            this.lblforDelivery.Location = new System.Drawing.Point(334, 234);
            this.lblforDelivery.Name = "lblforDelivery";
            this.lblforDelivery.Size = new System.Drawing.Size(48, 13);
            this.lblforDelivery.TabIndex = 16;
            this.lblforDelivery.Text = "Delivery:";
            // 
            // lblExpectDeliveryDate
            // 
            this.lblExpectDeliveryDate.BackColor = System.Drawing.Color.Black;
            this.lblExpectDeliveryDate.ForeColor = System.Drawing.Color.Lime;
            this.lblExpectDeliveryDate.Location = new System.Drawing.Point(308, 180);
            this.lblExpectDeliveryDate.Name = "lblExpectDeliveryDate";
            this.lblExpectDeliveryDate.Size = new System.Drawing.Size(205, 29);
            this.lblExpectDeliveryDate.TabIndex = 15;
            this.lblExpectDeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblforTotal
            // 
            this.lblforTotal.AutoSize = true;
            this.lblforTotal.Location = new System.Drawing.Point(25, 294);
            this.lblforTotal.Name = "lblforTotal";
            this.lblforTotal.Size = new System.Drawing.Size(34, 13);
            this.lblforTotal.TabIndex = 14;
            this.lblforTotal.Text = "Total:";
            // 
            // lblforShipping
            // 
            this.lblforShipping.AutoSize = true;
            this.lblforShipping.Location = new System.Drawing.Point(23, 262);
            this.lblforShipping.Name = "lblforShipping";
            this.lblforShipping.Size = new System.Drawing.Size(74, 13);
            this.lblforShipping.TabIndex = 13;
            this.lblforShipping.Text = "Shipping cost:";
            // 
            // lblforDiscount
            // 
            this.lblforDiscount.AutoSize = true;
            this.lblforDiscount.Location = new System.Drawing.Point(25, 220);
            this.lblforDiscount.Name = "lblforDiscount";
            this.lblforDiscount.Size = new System.Drawing.Size(52, 13);
            this.lblforDiscount.TabIndex = 12;
            this.lblforDiscount.Text = "Discount:";
            // 
            // lblforSaleTax
            // 
            this.lblforSaleTax.AutoSize = true;
            this.lblforSaleTax.Location = new System.Drawing.Point(25, 181);
            this.lblforSaleTax.Name = "lblforSaleTax";
            this.lblforSaleTax.Size = new System.Drawing.Size(76, 13);
            this.lblforSaleTax.TabIndex = 11;
            this.lblforSaleTax.Text = "Sales tax (6%):";
            // 
            // lblforSubtotal
            // 
            this.lblforSubtotal.AutoSize = true;
            this.lblforSubtotal.Location = new System.Drawing.Point(25, 142);
            this.lblforSubtotal.Name = "lblforSubtotal";
            this.lblforSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblforSubtotal.TabIndex = 10;
            this.lblforSubtotal.Text = "Subtotal:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(147, 288);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(115, 23);
            this.lblTotal.TabIndex = 9;
            // 
            // lblShipping
            // 
            this.lblShipping.BackColor = System.Drawing.SystemColors.Control;
            this.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipping.Location = new System.Drawing.Point(147, 252);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(115, 23);
            this.lblShipping.TabIndex = 8;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(147, 210);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(115, 22);
            this.lblDiscount.TabIndex = 7;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTax.Location = new System.Drawing.Point(147, 172);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(115, 22);
            this.lblSalesTax.TabIndex = 6;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(147, 132);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(115, 23);
            this.lblSubtotal.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(299, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(337, 313);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(337, 284);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(143, 23);
            this.btnPurchase.TabIndex = 2;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // deliveryCmBx
            // 
            this.deliveryCmBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryCmBx.FormattingEnabled = true;
            this.deliveryCmBx.Items.AddRange(new object[] {
            "Two Weeks",
            "One Week",
            "Two Days",
            "Next Day"});
            this.deliveryCmBx.Location = new System.Drawing.Point(337, 250);
            this.deliveryCmBx.Name = "deliveryCmBx";
            this.deliveryCmBx.Size = new System.Drawing.Size(143, 21);
            this.deliveryCmBx.TabIndex = 1;
            // 
            // shopCartLstBx
            // 
            this.shopCartLstBx.FormattingEnabled = true;
            this.shopCartLstBx.Location = new System.Drawing.Point(19, 17);
            this.shopCartLstBx.Name = "shopCartLstBx";
            this.shopCartLstBx.Size = new System.Drawing.Size(141, 95);
            this.shopCartLstBx.TabIndex = 0;
            this.shopCartLstBx.DoubleClick += new System.EventHandler(this.shopCartLstBx_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 386);
            this.Controls.Add(this.elecTabControl1);
            this.Name = "Form1";
            this.Text = "Electronics Shop";
            this.elecTabControl1.ResumeLayout(false);
            this.productTab.ResumeLayout(false);
            this.productTab.PerformLayout();
            this.shoppingTab.ResumeLayout(false);
            this.shoppingTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl elecTabControl1;
        private System.Windows.Forms.TabPage productTab;
        private System.Windows.Forms.TabPage shoppingTab;
        private System.Windows.Forms.ListBox productLstBx;
        private System.Windows.Forms.TextBox displayTextBx;
        private System.Windows.Forms.ComboBox deliveryCmBx;
        private System.Windows.Forms.ListBox shopCartLstBx;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblforDelivery;
        private System.Windows.Forms.Label lblExpectDeliveryDate;
        private System.Windows.Forms.Label lblforTotal;
        private System.Windows.Forms.Label lblforShipping;
        private System.Windows.Forms.Label lblforDiscount;
        private System.Windows.Forms.Label lblforSaleTax;
        private System.Windows.Forms.Label lblforSubtotal;
    }
}

