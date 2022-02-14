namespace project1csc323
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
            this.lblstorewelcome = new System.Windows.Forms.Label();
            this.gbproducts = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtntickets = new System.Windows.Forms.RadioButton();
            this.rbtngenericproducts = new System.Windows.Forms.RadioButton();
            this.lbproducts = new System.Windows.Forms.ListBox();
            this.gBproductinfo = new System.Windows.Forms.GroupBox();
            this.btncomtinue = new System.Windows.Forms.Button();
            this.cbquantity = new System.Windows.Forms.ComboBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.tbproductinfo = new System.Windows.Forms.TextBox();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.gbshoppingcart = new System.Windows.Forms.GroupBox();
            this.lblsortcart = new System.Windows.Forms.Label();
            this.tbgrandtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbsorting = new System.Windows.Forms.ComboBox();
            this.btnapplydiscount = new System.Windows.Forms.Button();
            this.lbldiscountcode = new System.Windows.Forms.Label();
            this.tbdiscountcode = new System.Windows.Forms.TextBox();
            this.btnremoveitem = new System.Windows.Forms.Button();
            this.btncheckout = new System.Windows.Forms.Button();
            this.gbshippinginfo = new System.Windows.Forms.GroupBox();
            this.tbshippingcost = new System.Windows.Forms.TextBox();
            this.lblshippingcost = new System.Windows.Forms.Label();
            this.lblshippingtype = new System.Windows.Forms.Label();
            this.cbshippingtype = new System.Windows.Forms.ComboBox();
            this.tbzipcode = new System.Windows.Forms.TextBox();
            this.tbcity = new System.Windows.Forms.TextBox();
            this.tbcountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsicty = new System.Windows.Forms.Label();
            this.lblcountry = new System.Windows.Forms.Label();
            this.lvshoppingcart = new System.Windows.Forms.ListView();
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnfinalizepurchase = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.gboptions = new System.Windows.Forms.GroupBox();
            this.btnviewhistory = new System.Windows.Forms.Button();
            this.gbproducts.SuspendLayout();
            this.gBproductinfo.SuspendLayout();
            this.gbshoppingcart.SuspendLayout();
            this.gbshippinginfo.SuspendLayout();
            this.gboptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblstorewelcome
            // 
            this.lblstorewelcome.AutoSize = true;
            this.lblstorewelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstorewelcome.Location = new System.Drawing.Point(258, 9);
            this.lblstorewelcome.Name = "lblstorewelcome";
            this.lblstorewelcome.Size = new System.Drawing.Size(268, 24);
            this.lblstorewelcome.TabIndex = 0;
            this.lblstorewelcome.Text = "welcome to YOUR online store";
            // 
            // gbproducts
            // 
            this.gbproducts.Controls.Add(this.label1);
            this.gbproducts.Controls.Add(this.rdbtntickets);
            this.gbproducts.Controls.Add(this.rbtngenericproducts);
            this.gbproducts.Controls.Add(this.lbproducts);
            this.gbproducts.Controls.Add(this.gBproductinfo);
            this.gbproducts.Location = new System.Drawing.Point(12, 36);
            this.gbproducts.Name = "gbproducts";
            this.gbproducts.Size = new System.Drawing.Size(462, 387);
            this.gbproducts.TabIndex = 1;
            this.gbproducts.TabStop = false;
            this.gbproducts.Text = "products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "please specify what you\'re looking for:";
            // 
            // rdbtntickets
            // 
            this.rdbtntickets.AutoSize = true;
            this.rdbtntickets.Location = new System.Drawing.Point(154, 48);
            this.rdbtntickets.Name = "rdbtntickets";
            this.rdbtntickets.Size = new System.Drawing.Size(56, 17);
            this.rdbtntickets.TabIndex = 4;
            this.rdbtntickets.TabStop = true;
            this.rdbtntickets.Text = "tickets";
            this.rdbtntickets.UseVisualStyleBackColor = true;
            this.rdbtntickets.CheckedChanged += new System.EventHandler(this.rdbtntickets_CheckedChanged);
            // 
            // rbtngenericproducts
            // 
            this.rbtngenericproducts.AutoSize = true;
            this.rbtngenericproducts.Location = new System.Drawing.Point(6, 48);
            this.rbtngenericproducts.Name = "rbtngenericproducts";
            this.rbtngenericproducts.Size = new System.Drawing.Size(104, 17);
            this.rbtngenericproducts.TabIndex = 3;
            this.rbtngenericproducts.TabStop = true;
            this.rbtngenericproducts.Text = "generic products";
            this.rbtngenericproducts.UseVisualStyleBackColor = true;
            this.rbtngenericproducts.CheckedChanged += new System.EventHandler(this.rbtngenericproducts_CheckedChanged);
            // 
            // lbproducts
            // 
            this.lbproducts.AllowDrop = true;
            this.lbproducts.FormattingEnabled = true;
            this.lbproducts.Location = new System.Drawing.Point(73, 94);
            this.lbproducts.Name = "lbproducts";
            this.lbproducts.Size = new System.Drawing.Size(120, 160);
            this.lbproducts.TabIndex = 0;
            this.lbproducts.SelectedIndexChanged += new System.EventHandler(this.lbproducts_SelectedIndexChanged);
            // 
            // gBproductinfo
            // 
            this.gBproductinfo.Controls.Add(this.btncomtinue);
            this.gBproductinfo.Controls.Add(this.cbquantity);
            this.gBproductinfo.Controls.Add(this.lblquantity);
            this.gBproductinfo.Controls.Add(this.tbproductinfo);
            this.gBproductinfo.Controls.Add(this.btnaddtocart);
            this.gBproductinfo.Location = new System.Drawing.Point(250, 106);
            this.gBproductinfo.Name = "gBproductinfo";
            this.gBproductinfo.Size = new System.Drawing.Size(200, 275);
            this.gBproductinfo.TabIndex = 2;
            this.gBproductinfo.TabStop = false;
            this.gBproductinfo.Text = "product info";
            // 
            // btncomtinue
            // 
            this.btncomtinue.Location = new System.Drawing.Point(125, 244);
            this.btncomtinue.Name = "btncomtinue";
            this.btncomtinue.Size = new System.Drawing.Size(75, 23);
            this.btncomtinue.TabIndex = 5;
            this.btncomtinue.Text = "continue";
            this.btncomtinue.UseVisualStyleBackColor = true;
            this.btncomtinue.Visible = false;
            this.btncomtinue.Click += new System.EventHandler(this.btncomtinue_Click);
            // 
            // cbquantity
            // 
            this.cbquantity.FormattingEnabled = true;
            this.cbquantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbquantity.Location = new System.Drawing.Point(10, 216);
            this.cbquantity.Name = "cbquantity";
            this.cbquantity.Size = new System.Drawing.Size(121, 21);
            this.cbquantity.TabIndex = 4;
            this.cbquantity.Visible = false;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Location = new System.Drawing.Point(7, 186);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(117, 13);
            this.lblquantity.TabIndex = 3;
            this.lblquantity.Text = "please specify quantity:";
            this.lblquantity.Visible = false;
            // 
            // tbproductinfo
            // 
            this.tbproductinfo.Location = new System.Drawing.Point(7, 33);
            this.tbproductinfo.Multiline = true;
            this.tbproductinfo.Name = "tbproductinfo";
            this.tbproductinfo.ReadOnly = true;
            this.tbproductinfo.Size = new System.Drawing.Size(187, 96);
            this.tbproductinfo.TabIndex = 1;
            this.tbproductinfo.Visible = false;
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.Location = new System.Drawing.Point(125, 145);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(75, 23);
            this.btnaddtocart.TabIndex = 0;
            this.btnaddtocart.Text = "add to cart";
            this.btnaddtocart.UseVisualStyleBackColor = true;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // gbshoppingcart
            // 
            this.gbshoppingcart.Controls.Add(this.lvshoppingcart);
            this.gbshoppingcart.Controls.Add(this.lblsortcart);
            this.gbshoppingcart.Controls.Add(this.tbgrandtotal);
            this.gbshoppingcart.Controls.Add(this.label2);
            this.gbshoppingcart.Controls.Add(this.cbsorting);
            this.gbshoppingcart.Controls.Add(this.btnapplydiscount);
            this.gbshoppingcart.Controls.Add(this.lbldiscountcode);
            this.gbshoppingcart.Controls.Add(this.tbdiscountcode);
            this.gbshoppingcart.Controls.Add(this.btnremoveitem);
            this.gbshoppingcart.Controls.Add(this.btncheckout);
            this.gbshoppingcart.Location = new System.Drawing.Point(480, 65);
            this.gbshoppingcart.Name = "gbshoppingcart";
            this.gbshoppingcart.Size = new System.Drawing.Size(308, 251);
            this.gbshoppingcart.TabIndex = 3;
            this.gbshoppingcart.TabStop = false;
            this.gbshoppingcart.Text = "shoppingcart";
            // 
            // lblsortcart
            // 
            this.lblsortcart.AutoSize = true;
            this.lblsortcart.Location = new System.Drawing.Point(108, 22);
            this.lblsortcart.Name = "lblsortcart";
            this.lblsortcart.Size = new System.Drawing.Size(59, 13);
            this.lblsortcart.TabIndex = 10;
            this.lblsortcart.Text = "sort cart in:";
            // 
            // tbgrandtotal
            // 
            this.tbgrandtotal.Location = new System.Drawing.Point(69, 205);
            this.tbgrandtotal.Name = "tbgrandtotal";
            this.tbgrandtotal.ReadOnly = true;
            this.tbgrandtotal.Size = new System.Drawing.Size(38, 20);
            this.tbgrandtotal.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "grand total";
            // 
            // cbsorting
            // 
            this.cbsorting.FormattingEnabled = true;
            this.cbsorting.Items.AddRange(new object[] {
            "low price to high price",
            "high price to low price"});
            this.cbsorting.Location = new System.Drawing.Point(172, 22);
            this.cbsorting.Name = "cbsorting";
            this.cbsorting.Size = new System.Drawing.Size(121, 21);
            this.cbsorting.TabIndex = 7;
            this.cbsorting.SelectedIndexChanged += new System.EventHandler(this.cbsorting_SelectedIndexChanged);
            // 
            // btnapplydiscount
            // 
            this.btnapplydiscount.Location = new System.Drawing.Point(225, 166);
            this.btnapplydiscount.Name = "btnapplydiscount";
            this.btnapplydiscount.Size = new System.Drawing.Size(54, 23);
            this.btnapplydiscount.TabIndex = 6;
            this.btnapplydiscount.Text = "apply discount";
            this.btnapplydiscount.UseVisualStyleBackColor = true;
            this.btnapplydiscount.Click += new System.EventHandler(this.btnapplydiscount_Click);
            // 
            // lbldiscountcode
            // 
            this.lbldiscountcode.AutoSize = true;
            this.lbldiscountcode.Location = new System.Drawing.Point(6, 175);
            this.lbldiscountcode.Name = "lbldiscountcode";
            this.lbldiscountcode.Size = new System.Drawing.Size(77, 13);
            this.lbldiscountcode.TabIndex = 5;
            this.lbldiscountcode.Text = "discount code:";
            // 
            // tbdiscountcode
            // 
            this.tbdiscountcode.Location = new System.Drawing.Point(108, 169);
            this.tbdiscountcode.Name = "tbdiscountcode";
            this.tbdiscountcode.Size = new System.Drawing.Size(100, 20);
            this.tbdiscountcode.TabIndex = 4;
            // 
            // btnremoveitem
            // 
            this.btnremoveitem.Location = new System.Drawing.Point(7, 20);
            this.btnremoveitem.Name = "btnremoveitem";
            this.btnremoveitem.Size = new System.Drawing.Size(75, 23);
            this.btnremoveitem.TabIndex = 2;
            this.btnremoveitem.Text = "remove item";
            this.btnremoveitem.UseVisualStyleBackColor = true;
            this.btnremoveitem.Click += new System.EventHandler(this.btnremoveitem_Click);
            // 
            // btncheckout
            // 
            this.btncheckout.Location = new System.Drawing.Point(227, 222);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(75, 23);
            this.btncheckout.TabIndex = 1;
            this.btncheckout.Text = "check out";
            this.btncheckout.UseVisualStyleBackColor = true;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // gbshippinginfo
            // 
            this.gbshippinginfo.Controls.Add(this.btnfinalizepurchase);
            this.gbshippinginfo.Controls.Add(this.tbshippingcost);
            this.gbshippinginfo.Controls.Add(this.lblshippingcost);
            this.gbshippinginfo.Controls.Add(this.lblshippingtype);
            this.gbshippinginfo.Controls.Add(this.cbshippingtype);
            this.gbshippinginfo.Controls.Add(this.tbzipcode);
            this.gbshippinginfo.Controls.Add(this.tbcity);
            this.gbshippinginfo.Controls.Add(this.tbcountry);
            this.gbshippinginfo.Controls.Add(this.label5);
            this.gbshippinginfo.Controls.Add(this.lblsicty);
            this.gbshippinginfo.Controls.Add(this.lblcountry);
            this.gbshippinginfo.Location = new System.Drawing.Point(489, 322);
            this.gbshippinginfo.Name = "gbshippinginfo";
            this.gbshippinginfo.Size = new System.Drawing.Size(293, 116);
            this.gbshippinginfo.TabIndex = 4;
            this.gbshippinginfo.TabStop = false;
            this.gbshippinginfo.Text = "shipping info";
            this.gbshippinginfo.Visible = false;
            // 
            // tbshippingcost
            // 
            this.tbshippingcost.Location = new System.Drawing.Point(69, 95);
            this.tbshippingcost.Name = "tbshippingcost";
            this.tbshippingcost.ReadOnly = true;
            this.tbshippingcost.Size = new System.Drawing.Size(39, 20);
            this.tbshippingcost.TabIndex = 9;
            // 
            // lblshippingcost
            // 
            this.lblshippingcost.AutoSize = true;
            this.lblshippingcost.Location = new System.Drawing.Point(-3, 100);
            this.lblshippingcost.Name = "lblshippingcost";
            this.lblshippingcost.Size = new System.Drawing.Size(72, 13);
            this.lblshippingcost.TabIndex = 8;
            this.lblshippingcost.Text = "shipping cost:";
            // 
            // lblshippingtype
            // 
            this.lblshippingtype.AutoSize = true;
            this.lblshippingtype.Location = new System.Drawing.Point(206, 20);
            this.lblshippingtype.Name = "lblshippingtype";
            this.lblshippingtype.Size = new System.Drawing.Size(72, 13);
            this.lblshippingtype.TabIndex = 7;
            this.lblshippingtype.Text = "shipping type:";
            // 
            // cbshippingtype
            // 
            this.cbshippingtype.FormattingEnabled = true;
            this.cbshippingtype.Items.AddRange(new object[] {
            "by land",
            "by plane ",
            "by sea"});
            this.cbshippingtype.Location = new System.Drawing.Point(206, 42);
            this.cbshippingtype.Name = "cbshippingtype";
            this.cbshippingtype.Size = new System.Drawing.Size(81, 21);
            this.cbshippingtype.TabIndex = 6;
            // 
            // tbzipcode
            // 
            this.tbzipcode.Location = new System.Drawing.Point(69, 69);
            this.tbzipcode.Name = "tbzipcode";
            this.tbzipcode.Size = new System.Drawing.Size(100, 20);
            this.tbzipcode.TabIndex = 5;
            // 
            // tbcity
            // 
            this.tbcity.Location = new System.Drawing.Point(69, 43);
            this.tbcity.Name = "tbcity";
            this.tbcity.Size = new System.Drawing.Size(100, 20);
            this.tbcity.TabIndex = 4;
            // 
            // tbcountry
            // 
            this.tbcountry.Location = new System.Drawing.Point(69, 20);
            this.tbcountry.Name = "tbcountry";
            this.tbcountry.Size = new System.Drawing.Size(100, 20);
            this.tbcountry.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "zip code:";
            // 
            // lblsicty
            // 
            this.lblsicty.AutoSize = true;
            this.lblsicty.Location = new System.Drawing.Point(10, 50);
            this.lblsicty.Name = "lblsicty";
            this.lblsicty.Size = new System.Drawing.Size(26, 13);
            this.lblsicty.TabIndex = 1;
            this.lblsicty.Text = "city:";
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Location = new System.Drawing.Point(10, 27);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(45, 13);
            this.lblcountry.TabIndex = 0;
            this.lblcountry.Text = "country:";
            // 
            // lvshoppingcart
            // 
            this.lvshoppingcart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemID,
            this.ItemName,
            this.UnitPrice,
            this.Quantity});
            this.lvshoppingcart.HideSelection = false;
            this.lvshoppingcart.Location = new System.Drawing.Point(9, 49);
            this.lvshoppingcart.Name = "lvshoppingcart";
            this.lvshoppingcart.Size = new System.Drawing.Size(284, 97);
            this.lvshoppingcart.TabIndex = 11;
            this.lvshoppingcart.UseCompatibleStateImageBehavior = false;
            this.lvshoppingcart.View = System.Windows.Forms.View.Details;
            // 
            // ItemID
            // 
            this.ItemID.Name = global::project1csc323.Properties.Settings.Default.ItemID;
            this.ItemID.Tag = "ItemID";
            this.ItemID.Text = "ItemID";
            this.ItemID.Width = 45;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 112;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Unit Price";
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // btnfinalizepurchase
            // 
            this.btnfinalizepurchase.Location = new System.Drawing.Point(218, 71);
            this.btnfinalizepurchase.Name = "btnfinalizepurchase";
            this.btnfinalizepurchase.Size = new System.Drawing.Size(75, 39);
            this.btnfinalizepurchase.TabIndex = 10;
            this.btnfinalizepurchase.Text = "finalize purchase";
            this.btnfinalizepurchase.UseVisualStyleBackColor = true;
            this.btnfinalizepurchase.Click += new System.EventHandler(this.btnfinalizepurchase_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(4, 17);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // gboptions
            // 
            this.gboptions.Controls.Add(this.btnviewhistory);
            this.gboptions.Controls.Add(this.btnback);
            this.gboptions.Location = new System.Drawing.Point(568, 13);
            this.gboptions.Name = "gboptions";
            this.gboptions.Size = new System.Drawing.Size(199, 46);
            this.gboptions.TabIndex = 6;
            this.gboptions.TabStop = false;
            this.gboptions.Text = "options";
            // 
            // btnviewhistory
            // 
            this.btnviewhistory.Location = new System.Drawing.Point(99, 17);
            this.btnviewhistory.Name = "btnviewhistory";
            this.btnviewhistory.Size = new System.Drawing.Size(75, 23);
            this.btnviewhistory.TabIndex = 6;
            this.btnviewhistory.Text = "view history";
            this.btnviewhistory.UseVisualStyleBackColor = true;
            this.btnviewhistory.Click += new System.EventHandler(this.btnviewhistory_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboptions);
            this.Controls.Add(this.gbshippinginfo);
            this.Controls.Add(this.gbshoppingcart);
            this.Controls.Add(this.gbproducts);
            this.Controls.Add(this.lblstorewelcome);
            this.Name = "Form2";
            this.Text = "store UI";
            this.gbproducts.ResumeLayout(false);
            this.gbproducts.PerformLayout();
            this.gBproductinfo.ResumeLayout(false);
            this.gBproductinfo.PerformLayout();
            this.gbshoppingcart.ResumeLayout(false);
            this.gbshoppingcart.PerformLayout();
            this.gbshippinginfo.ResumeLayout(false);
            this.gbshippinginfo.PerformLayout();
            this.gboptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstorewelcome;
        private System.Windows.Forms.GroupBox gbproducts;
        private System.Windows.Forms.GroupBox gBproductinfo;
        private System.Windows.Forms.GroupBox gbshoppingcart;
        private System.Windows.Forms.GroupBox gbshippinginfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtntickets;
        private System.Windows.Forms.RadioButton rbtngenericproducts;
        private System.Windows.Forms.ListBox lbproducts;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.Button btnremoveitem;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.ComboBox cbsorting;
        private System.Windows.Forms.Button btnapplydiscount;
        private System.Windows.Forms.Label lbldiscountcode;
        private System.Windows.Forms.TextBox tbdiscountcode;
        private System.Windows.Forms.TextBox tbgrandtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbproductinfo;
        private System.Windows.Forms.ComboBox cbquantity;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblsortcart;
        private System.Windows.Forms.TextBox tbshippingcost;
        private System.Windows.Forms.Label lblshippingcost;
        private System.Windows.Forms.Label lblshippingtype;
        private System.Windows.Forms.ComboBox cbshippingtype;
        private System.Windows.Forms.TextBox tbzipcode;
        private System.Windows.Forms.TextBox tbcity;
        private System.Windows.Forms.TextBox tbcountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsicty;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.Button btncomtinue;
        private System.Windows.Forms.ListView lvshoppingcart;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button btnfinalizepurchase;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.GroupBox gboptions;
        private System.Windows.Forms.Button btnviewhistory;
    }
}