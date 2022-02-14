namespace project1csc323
{
    partial class Form3
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
            this.gbcostumercontrol = new System.Windows.Forms.GroupBox();
            this.btnviewinfo = new System.Windows.Forms.Button();
            this.btndeletehistory = new System.Windows.Forms.Button();
            this.lbcostumerlist = new System.Windows.Forms.ListBox();
            this.gbaddticket = new System.Windows.Forms.GroupBox();
            this.eventdatepicker = new System.Windows.Forms.DateTimePicker();
            this.doorsopenatpicker = new System.Windows.Forms.DateTimePicker();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.tbquantityinstock = new System.Windows.Forms.TextBox();
            this.tbeventlocation = new System.Windows.Forms.TextBox();
            this.tbshowname = new System.Windows.Forms.TextBox();
            this.tbseat = new System.Windows.Forms.TextBox();
            this.tbrow = new System.Windows.Forms.TextBox();
            this.tbunitprice = new System.Windows.Forms.TextBox();
            this.tbproductname = new System.Windows.Forms.TextBox();
            this.tbproductid = new System.Windows.Forms.TextBox();
            this.lbleventlocation = new System.Windows.Forms.Label();
            this.lbldoorsopenat = new System.Windows.Forms.Label();
            this.lbleventdate = new System.Windows.Forms.Label();
            this.lblquantityinstock = new System.Windows.Forms.Label();
            this.lblshowname = new System.Windows.Forms.Label();
            this.lblseat = new System.Windows.Forms.Label();
            this.lblrow = new System.Windows.Forms.Label();
            this.lblunitprice = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.lblproductid = new System.Windows.Forms.Label();
            this.gbnewgenericproduct = new System.Windows.Forms.GroupBox();
            this.tbquantityinstockgeneric = new System.Windows.Forms.TextBox();
            this.lblquantityinstockgeneric = new System.Windows.Forms.Label();
            this.btnaddgenericproduct = new System.Windows.Forms.Button();
            this.tbdescription = new System.Windows.Forms.TextBox();
            this.tbmadein = new System.Windows.Forms.TextBox();
            this.tbbrand = new System.Windows.Forms.TextBox();
            this.tbcolor = new System.Windows.Forms.TextBox();
            this.tbweight = new System.Windows.Forms.TextBox();
            this.tbgenericprodunitprice = new System.Windows.Forms.TextBox();
            this.tbgenericprodname = new System.Windows.Forms.TextBox();
            this.tbgenericprodid = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblcountrymadein = new System.Windows.Forms.Label();
            this.lblproductweight = new System.Windows.Forms.Label();
            this.lblproductcolor = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.lblgenericproductunitprice = new System.Windows.Forms.Label();
            this.lblgenericproductname = new System.Windows.Forms.Label();
            this.lblgenericproductid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbladditem = new System.Windows.Forms.Label();
            this.rbticket = new System.Windows.Forms.RadioButton();
            this.rbgenericproduct = new System.Windows.Forms.RadioButton();
            this.gbproductcontrol = new System.Windows.Forms.GroupBox();
            this.btnback = new System.Windows.Forms.Button();
            this.gbcostumercontrol.SuspendLayout();
            this.gbaddticket.SuspendLayout();
            this.gbnewgenericproduct.SuspendLayout();
            this.gbproductcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbcostumercontrol
            // 
            this.gbcostumercontrol.Controls.Add(this.btnviewinfo);
            this.gbcostumercontrol.Controls.Add(this.btndeletehistory);
            this.gbcostumercontrol.Controls.Add(this.lbcostumerlist);
            this.gbcostumercontrol.Location = new System.Drawing.Point(12, 46);
            this.gbcostumercontrol.Name = "gbcostumercontrol";
            this.gbcostumercontrol.Size = new System.Drawing.Size(215, 336);
            this.gbcostumercontrol.TabIndex = 0;
            this.gbcostumercontrol.TabStop = false;
            this.gbcostumercontrol.Text = "costumer control";
            // 
            // btnviewinfo
            // 
            this.btnviewinfo.Location = new System.Drawing.Point(134, 126);
            this.btnviewinfo.Name = "btnviewinfo";
            this.btnviewinfo.Size = new System.Drawing.Size(75, 23);
            this.btnviewinfo.TabIndex = 2;
            this.btnviewinfo.Text = "view info";
            this.btnviewinfo.UseVisualStyleBackColor = true;
            this.btnviewinfo.Click += new System.EventHandler(this.btnviewinfo_Click);
            // 
            // btndeletehistory
            // 
            this.btndeletehistory.Location = new System.Drawing.Point(134, 36);
            this.btndeletehistory.Name = "btndeletehistory";
            this.btndeletehistory.Size = new System.Drawing.Size(75, 48);
            this.btndeletehistory.TabIndex = 1;
            this.btndeletehistory.Text = "delete history";
            this.btndeletehistory.UseVisualStyleBackColor = true;
            this.btndeletehistory.Click += new System.EventHandler(this.btndeletehistory_Click);
            // 
            // lbcostumerlist
            // 
            this.lbcostumerlist.FormattingEnabled = true;
            this.lbcostumerlist.Location = new System.Drawing.Point(7, 20);
            this.lbcostumerlist.Name = "lbcostumerlist";
            this.lbcostumerlist.Size = new System.Drawing.Size(120, 303);
            this.lbcostumerlist.TabIndex = 0;
            // 
            // gbaddticket
            // 
            this.gbaddticket.Controls.Add(this.eventdatepicker);
            this.gbaddticket.Controls.Add(this.doorsopenatpicker);
            this.gbaddticket.Controls.Add(this.btnaddproduct);
            this.gbaddticket.Controls.Add(this.tbquantityinstock);
            this.gbaddticket.Controls.Add(this.tbeventlocation);
            this.gbaddticket.Controls.Add(this.tbshowname);
            this.gbaddticket.Controls.Add(this.tbseat);
            this.gbaddticket.Controls.Add(this.tbrow);
            this.gbaddticket.Controls.Add(this.tbunitprice);
            this.gbaddticket.Controls.Add(this.tbproductname);
            this.gbaddticket.Controls.Add(this.tbproductid);
            this.gbaddticket.Controls.Add(this.lbleventlocation);
            this.gbaddticket.Controls.Add(this.lbldoorsopenat);
            this.gbaddticket.Controls.Add(this.lbleventdate);
            this.gbaddticket.Controls.Add(this.lblquantityinstock);
            this.gbaddticket.Controls.Add(this.lblshowname);
            this.gbaddticket.Controls.Add(this.lblseat);
            this.gbaddticket.Controls.Add(this.lblrow);
            this.gbaddticket.Controls.Add(this.lblunitprice);
            this.gbaddticket.Controls.Add(this.lblproductname);
            this.gbaddticket.Controls.Add(this.lblproductid);
            this.gbaddticket.Location = new System.Drawing.Point(12, 99);
            this.gbaddticket.Name = "gbaddticket";
            this.gbaddticket.Size = new System.Drawing.Size(206, 336);
            this.gbaddticket.TabIndex = 1;
            this.gbaddticket.TabStop = false;
            this.gbaddticket.Text = "create new ticket";
            this.gbaddticket.Visible = false;
            // 
            // eventdatepicker
            // 
            this.eventdatepicker.Location = new System.Drawing.Point(78, 254);
            this.eventdatepicker.Name = "eventdatepicker";
            this.eventdatepicker.Size = new System.Drawing.Size(104, 20);
            this.eventdatepicker.TabIndex = 21;
            // 
            // doorsopenatpicker
            // 
            this.doorsopenatpicker.Location = new System.Drawing.Point(78, 228);
            this.doorsopenatpicker.Name = "doorsopenatpicker";
            this.doorsopenatpicker.Size = new System.Drawing.Size(104, 20);
            this.doorsopenatpicker.TabIndex = 10;
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Location = new System.Drawing.Point(107, 307);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(75, 23);
            this.btnaddproduct.TabIndex = 20;
            this.btnaddproduct.Text = "add product";
            this.btnaddproduct.UseVisualStyleBackColor = true;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // tbquantityinstock
            // 
            this.tbquantityinstock.Location = new System.Drawing.Point(96, 280);
            this.tbquantityinstock.Name = "tbquantityinstock";
            this.tbquantityinstock.Size = new System.Drawing.Size(89, 20);
            this.tbquantityinstock.TabIndex = 19;
            // 
            // tbeventlocation
            // 
            this.tbeventlocation.Location = new System.Drawing.Point(96, 199);
            this.tbeventlocation.Name = "tbeventlocation";
            this.tbeventlocation.Size = new System.Drawing.Size(87, 20);
            this.tbeventlocation.TabIndex = 16;
            // 
            // tbshowname
            // 
            this.tbshowname.Location = new System.Drawing.Point(96, 170);
            this.tbshowname.Name = "tbshowname";
            this.tbshowname.Size = new System.Drawing.Size(86, 20);
            this.tbshowname.TabIndex = 15;
            // 
            // tbseat
            // 
            this.tbseat.Location = new System.Drawing.Point(96, 139);
            this.tbseat.Name = "tbseat";
            this.tbseat.Size = new System.Drawing.Size(87, 20);
            this.tbseat.TabIndex = 14;
            // 
            // tbrow
            // 
            this.tbrow.Location = new System.Drawing.Point(96, 111);
            this.tbrow.Name = "tbrow";
            this.tbrow.Size = new System.Drawing.Size(87, 20);
            this.tbrow.TabIndex = 13;
            // 
            // tbunitprice
            // 
            this.tbunitprice.Location = new System.Drawing.Point(96, 80);
            this.tbunitprice.Name = "tbunitprice";
            this.tbunitprice.Size = new System.Drawing.Size(87, 20);
            this.tbunitprice.TabIndex = 12;
            // 
            // tbproductname
            // 
            this.tbproductname.Location = new System.Drawing.Point(96, 51);
            this.tbproductname.Name = "tbproductname";
            this.tbproductname.Size = new System.Drawing.Size(89, 20);
            this.tbproductname.TabIndex = 11;
            // 
            // tbproductid
            // 
            this.tbproductid.Location = new System.Drawing.Point(96, 20);
            this.tbproductid.Name = "tbproductid";
            this.tbproductid.Size = new System.Drawing.Size(87, 20);
            this.tbproductid.TabIndex = 10;
            // 
            // lbleventlocation
            // 
            this.lbleventlocation.AutoSize = true;
            this.lbleventlocation.Location = new System.Drawing.Point(7, 198);
            this.lbleventlocation.Name = "lbleventlocation";
            this.lbleventlocation.Size = new System.Drawing.Size(74, 13);
            this.lbleventlocation.TabIndex = 9;
            this.lbleventlocation.Text = "event location";
            // 
            // lbldoorsopenat
            // 
            this.lbldoorsopenat.AutoSize = true;
            this.lbldoorsopenat.Location = new System.Drawing.Point(7, 228);
            this.lbldoorsopenat.Name = "lbldoorsopenat";
            this.lbldoorsopenat.Size = new System.Drawing.Size(72, 13);
            this.lbldoorsopenat.TabIndex = 8;
            this.lbldoorsopenat.Text = "doors open at";
            // 
            // lbleventdate
            // 
            this.lbleventdate.AutoSize = true;
            this.lbleventdate.Location = new System.Drawing.Point(7, 251);
            this.lbleventdate.Name = "lbleventdate";
            this.lbleventdate.Size = new System.Drawing.Size(58, 13);
            this.lbleventdate.TabIndex = 7;
            this.lbleventdate.Text = "event date";
            // 
            // lblquantityinstock
            // 
            this.lblquantityinstock.AutoSize = true;
            this.lblquantityinstock.Location = new System.Drawing.Point(6, 287);
            this.lblquantityinstock.Name = "lblquantityinstock";
            this.lblquantityinstock.Size = new System.Drawing.Size(84, 13);
            this.lblquantityinstock.TabIndex = 6;
            this.lblquantityinstock.Text = "quantity in stock";
            // 
            // lblshowname
            // 
            this.lblshowname.AutoSize = true;
            this.lblshowname.Location = new System.Drawing.Point(7, 173);
            this.lblshowname.Name = "lblshowname";
            this.lblshowname.Size = new System.Drawing.Size(61, 13);
            this.lblshowname.TabIndex = 5;
            this.lblshowname.Text = "show name";
            // 
            // lblseat
            // 
            this.lblseat.AutoSize = true;
            this.lblseat.Location = new System.Drawing.Point(7, 139);
            this.lblseat.Name = "lblseat";
            this.lblseat.Size = new System.Drawing.Size(27, 13);
            this.lblseat.TabIndex = 4;
            this.lblseat.Text = "seat";
            // 
            // lblrow
            // 
            this.lblrow.AutoSize = true;
            this.lblrow.Location = new System.Drawing.Point(7, 111);
            this.lblrow.Name = "lblrow";
            this.lblrow.Size = new System.Drawing.Size(24, 13);
            this.lblrow.TabIndex = 3;
            this.lblrow.Text = "row";
            // 
            // lblunitprice
            // 
            this.lblunitprice.AutoSize = true;
            this.lblunitprice.Location = new System.Drawing.Point(7, 80);
            this.lblunitprice.Name = "lblunitprice";
            this.lblunitprice.Size = new System.Drawing.Size(50, 13);
            this.lblunitprice.TabIndex = 2;
            this.lblunitprice.Text = "unit price";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Location = new System.Drawing.Point(7, 51);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(72, 13);
            this.lblproductname.TabIndex = 1;
            this.lblproductname.Text = "product name";
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.Location = new System.Drawing.Point(7, 20);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(54, 13);
            this.lblproductid.TabIndex = 0;
            this.lblproductid.Text = "product id";
            // 
            // gbnewgenericproduct
            // 
            this.gbnewgenericproduct.Controls.Add(this.tbquantityinstockgeneric);
            this.gbnewgenericproduct.Controls.Add(this.lblquantityinstockgeneric);
            this.gbnewgenericproduct.Controls.Add(this.btnaddgenericproduct);
            this.gbnewgenericproduct.Controls.Add(this.tbdescription);
            this.gbnewgenericproduct.Controls.Add(this.tbmadein);
            this.gbnewgenericproduct.Controls.Add(this.tbbrand);
            this.gbnewgenericproduct.Controls.Add(this.tbcolor);
            this.gbnewgenericproduct.Controls.Add(this.tbweight);
            this.gbnewgenericproduct.Controls.Add(this.tbgenericprodunitprice);
            this.gbnewgenericproduct.Controls.Add(this.tbgenericprodname);
            this.gbnewgenericproduct.Controls.Add(this.tbgenericprodid);
            this.gbnewgenericproduct.Controls.Add(this.lbldescription);
            this.gbnewgenericproduct.Controls.Add(this.lblcountrymadein);
            this.gbnewgenericproduct.Controls.Add(this.lblproductweight);
            this.gbnewgenericproduct.Controls.Add(this.lblproductcolor);
            this.gbnewgenericproduct.Controls.Add(this.lblbrand);
            this.gbnewgenericproduct.Controls.Add(this.lblgenericproductunitprice);
            this.gbnewgenericproduct.Controls.Add(this.lblgenericproductname);
            this.gbnewgenericproduct.Controls.Add(this.lblgenericproductid);
            this.gbnewgenericproduct.Location = new System.Drawing.Point(225, 99);
            this.gbnewgenericproduct.Name = "gbnewgenericproduct";
            this.gbnewgenericproduct.Size = new System.Drawing.Size(206, 330);
            this.gbnewgenericproduct.TabIndex = 2;
            this.gbnewgenericproduct.TabStop = false;
            this.gbnewgenericproduct.Text = "create new generic product";
            this.gbnewgenericproduct.Visible = false;
            // 
            // tbquantityinstockgeneric
            // 
            this.tbquantityinstockgeneric.Location = new System.Drawing.Point(84, 260);
            this.tbquantityinstockgeneric.Name = "tbquantityinstockgeneric";
            this.tbquantityinstockgeneric.Size = new System.Drawing.Size(87, 20);
            this.tbquantityinstockgeneric.TabIndex = 39;
            // 
            // lblquantityinstockgeneric
            // 
            this.lblquantityinstockgeneric.AutoSize = true;
            this.lblquantityinstockgeneric.Location = new System.Drawing.Point(6, 263);
            this.lblquantityinstockgeneric.Name = "lblquantityinstockgeneric";
            this.lblquantityinstockgeneric.Size = new System.Drawing.Size(84, 13);
            this.lblquantityinstockgeneric.TabIndex = 38;
            this.lblquantityinstockgeneric.Text = "quantity in stock";
            // 
            // btnaddgenericproduct
            // 
            this.btnaddgenericproduct.Location = new System.Drawing.Point(95, 306);
            this.btnaddgenericproduct.Name = "btnaddgenericproduct";
            this.btnaddgenericproduct.Size = new System.Drawing.Size(75, 23);
            this.btnaddgenericproduct.TabIndex = 37;
            this.btnaddgenericproduct.Text = "add product";
            this.btnaddgenericproduct.UseVisualStyleBackColor = true;
            this.btnaddgenericproduct.Click += new System.EventHandler(this.btnaddgenericproduct_Click);
            // 
            // tbdescription
            // 
            this.tbdescription.AllowDrop = true;
            this.tbdescription.Location = new System.Drawing.Point(84, 228);
            this.tbdescription.Name = "tbdescription";
            this.tbdescription.Size = new System.Drawing.Size(87, 20);
            this.tbdescription.TabIndex = 36;
            // 
            // tbmadein
            // 
            this.tbmadein.Location = new System.Drawing.Point(84, 199);
            this.tbmadein.Name = "tbmadein";
            this.tbmadein.Size = new System.Drawing.Size(87, 20);
            this.tbmadein.TabIndex = 35;
            // 
            // tbbrand
            // 
            this.tbbrand.Location = new System.Drawing.Point(84, 170);
            this.tbbrand.Name = "tbbrand";
            this.tbbrand.Size = new System.Drawing.Size(87, 20);
            this.tbbrand.TabIndex = 34;
            // 
            // tbcolor
            // 
            this.tbcolor.Location = new System.Drawing.Point(84, 142);
            this.tbcolor.Name = "tbcolor";
            this.tbcolor.Size = new System.Drawing.Size(87, 20);
            this.tbcolor.TabIndex = 33;
            // 
            // tbweight
            // 
            this.tbweight.Location = new System.Drawing.Point(84, 111);
            this.tbweight.Name = "tbweight";
            this.tbweight.Size = new System.Drawing.Size(87, 20);
            this.tbweight.TabIndex = 32;
            // 
            // tbgenericprodunitprice
            // 
            this.tbgenericprodunitprice.Location = new System.Drawing.Point(84, 80);
            this.tbgenericprodunitprice.Name = "tbgenericprodunitprice";
            this.tbgenericprodunitprice.Size = new System.Drawing.Size(87, 20);
            this.tbgenericprodunitprice.TabIndex = 31;
            // 
            // tbgenericprodname
            // 
            this.tbgenericprodname.Location = new System.Drawing.Point(84, 51);
            this.tbgenericprodname.Name = "tbgenericprodname";
            this.tbgenericprodname.Size = new System.Drawing.Size(87, 20);
            this.tbgenericprodname.TabIndex = 30;
            // 
            // tbgenericprodid
            // 
            this.tbgenericprodid.Location = new System.Drawing.Point(84, 20);
            this.tbgenericprodid.Name = "tbgenericprodid";
            this.tbgenericprodid.Size = new System.Drawing.Size(87, 20);
            this.tbgenericprodid.TabIndex = 29;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(6, 228);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(58, 13);
            this.lbldescription.TabIndex = 28;
            this.lbldescription.Text = "description";
            // 
            // lblcountrymadein
            // 
            this.lblcountrymadein.AutoSize = true;
            this.lblcountrymadein.Location = new System.Drawing.Point(6, 198);
            this.lblcountrymadein.Name = "lblcountrymadein";
            this.lblcountrymadein.Size = new System.Drawing.Size(82, 13);
            this.lblcountrymadein.TabIndex = 27;
            this.lblcountrymadein.Text = "country made in";
            // 
            // lblproductweight
            // 
            this.lblproductweight.AutoSize = true;
            this.lblproductweight.Location = new System.Drawing.Point(6, 111);
            this.lblproductweight.Name = "lblproductweight";
            this.lblproductweight.Size = new System.Drawing.Size(77, 13);
            this.lblproductweight.TabIndex = 26;
            this.lblproductweight.Text = "product weight";
            // 
            // lblproductcolor
            // 
            this.lblproductcolor.AutoSize = true;
            this.lblproductcolor.Location = new System.Drawing.Point(6, 142);
            this.lblproductcolor.Name = "lblproductcolor";
            this.lblproductcolor.Size = new System.Drawing.Size(69, 13);
            this.lblproductcolor.TabIndex = 25;
            this.lblproductcolor.Text = "product color";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Location = new System.Drawing.Point(6, 173);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(34, 13);
            this.lblbrand.TabIndex = 24;
            this.lblbrand.Text = "brand";
            // 
            // lblgenericproductunitprice
            // 
            this.lblgenericproductunitprice.AutoSize = true;
            this.lblgenericproductunitprice.Location = new System.Drawing.Point(6, 80);
            this.lblgenericproductunitprice.Name = "lblgenericproductunitprice";
            this.lblgenericproductunitprice.Size = new System.Drawing.Size(50, 13);
            this.lblgenericproductunitprice.TabIndex = 23;
            this.lblgenericproductunitprice.Text = "unit price";
            // 
            // lblgenericproductname
            // 
            this.lblgenericproductname.AutoSize = true;
            this.lblgenericproductname.Location = new System.Drawing.Point(6, 51);
            this.lblgenericproductname.Name = "lblgenericproductname";
            this.lblgenericproductname.Size = new System.Drawing.Size(72, 13);
            this.lblgenericproductname.TabIndex = 22;
            this.lblgenericproductname.Text = "product name";
            // 
            // lblgenericproductid
            // 
            this.lblgenericproductid.AutoSize = true;
            this.lblgenericproductid.Location = new System.Drawing.Point(6, 20);
            this.lblgenericproductid.Name = "lblgenericproductid";
            this.lblgenericproductid.Size = new System.Drawing.Size(54, 13);
            this.lblgenericproductid.TabIndex = 22;
            this.lblgenericproductid.Text = "product id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin side";
            // 
            // lbladditem
            // 
            this.lbladditem.AutoSize = true;
            this.lbladditem.Location = new System.Drawing.Point(6, 20);
            this.lbladditem.Name = "lbladditem";
            this.lbladditem.Size = new System.Drawing.Size(123, 13);
            this.lbladditem.TabIndex = 38;
            this.lbladditem.Text = "add an item to inventory:";
            // 
            // rbticket
            // 
            this.rbticket.AutoSize = true;
            this.rbticket.Location = new System.Drawing.Point(9, 42);
            this.rbticket.Name = "rbticket";
            this.rbticket.Size = new System.Drawing.Size(51, 17);
            this.rbticket.TabIndex = 39;
            this.rbticket.TabStop = true;
            this.rbticket.Text = "ticket";
            this.rbticket.UseVisualStyleBackColor = true;
            this.rbticket.CheckedChanged += new System.EventHandler(this.rbticket_CheckedChanged);
            // 
            // rbgenericproduct
            // 
            this.rbgenericproduct.AutoSize = true;
            this.rbgenericproduct.Location = new System.Drawing.Point(9, 64);
            this.rbgenericproduct.Name = "rbgenericproduct";
            this.rbgenericproduct.Size = new System.Drawing.Size(96, 17);
            this.rbgenericproduct.TabIndex = 40;
            this.rbgenericproduct.TabStop = true;
            this.rbgenericproduct.Text = "genericproduct";
            this.rbgenericproduct.UseVisualStyleBackColor = true;
            this.rbgenericproduct.CheckedChanged += new System.EventHandler(this.rbgenericproduct_CheckedChanged);
            // 
            // gbproductcontrol
            // 
            this.gbproductcontrol.Controls.Add(this.gbnewgenericproduct);
            this.gbproductcontrol.Controls.Add(this.rbgenericproduct);
            this.gbproductcontrol.Controls.Add(this.gbaddticket);
            this.gbproductcontrol.Controls.Add(this.rbticket);
            this.gbproductcontrol.Controls.Add(this.lbladditem);
            this.gbproductcontrol.Location = new System.Drawing.Point(341, 49);
            this.gbproductcontrol.Name = "gbproductcontrol";
            this.gbproductcontrol.Size = new System.Drawing.Size(431, 443);
            this.gbproductcontrol.TabIndex = 41;
            this.gbproductcontrol.TabStop = false;
            this.gbproductcontrol.Text = "product control";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(19, 13);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 42;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.gbproductcontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbcostumercontrol);
            this.Name = "Form3";
            this.Text = "admin UI";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbcostumercontrol.ResumeLayout(false);
            this.gbaddticket.ResumeLayout(false);
            this.gbaddticket.PerformLayout();
            this.gbnewgenericproduct.ResumeLayout(false);
            this.gbnewgenericproduct.PerformLayout();
            this.gbproductcontrol.ResumeLayout(false);
            this.gbproductcontrol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcostumercontrol;
        private System.Windows.Forms.ListBox lbcostumerlist;
        private System.Windows.Forms.GroupBox gbaddticket;
        private System.Windows.Forms.GroupBox gbnewgenericproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrow;
        private System.Windows.Forms.Label lblunitprice;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Label lblproductid;
        private System.Windows.Forms.Label lbleventlocation;
        private System.Windows.Forms.Label lbldoorsopenat;
        private System.Windows.Forms.Label lbleventdate;
        private System.Windows.Forms.Label lblquantityinstock;
        private System.Windows.Forms.Label lblshowname;
        private System.Windows.Forms.Label lblseat;
        private System.Windows.Forms.DateTimePicker doorsopenatpicker;
        private System.Windows.Forms.Button btnviewinfo;
        private System.Windows.Forms.Button btndeletehistory;
        private System.Windows.Forms.DateTimePicker eventdatepicker;
        private System.Windows.Forms.Button btnaddproduct;
        private System.Windows.Forms.TextBox tbquantityinstock;
        private System.Windows.Forms.TextBox tbeventlocation;
        private System.Windows.Forms.TextBox tbshowname;
        private System.Windows.Forms.TextBox tbseat;
        private System.Windows.Forms.TextBox tbrow;
        private System.Windows.Forms.TextBox tbunitprice;
        private System.Windows.Forms.TextBox tbproductname;
        private System.Windows.Forms.TextBox tbproductid;
        private System.Windows.Forms.Label lblproductweight;
        private System.Windows.Forms.Label lblproductcolor;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.Label lblgenericproductunitprice;
        private System.Windows.Forms.Label lblgenericproductname;
        private System.Windows.Forms.Label lblgenericproductid;
        private System.Windows.Forms.Label lblcountrymadein;
        private System.Windows.Forms.Button btnaddgenericproduct;
        private System.Windows.Forms.TextBox tbdescription;
        private System.Windows.Forms.TextBox tbmadein;
        private System.Windows.Forms.TextBox tbbrand;
        private System.Windows.Forms.TextBox tbcolor;
        private System.Windows.Forms.TextBox tbweight;
        private System.Windows.Forms.TextBox tbgenericprodunitprice;
        private System.Windows.Forms.TextBox tbgenericprodname;
        private System.Windows.Forms.TextBox tbgenericprodid;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lbladditem;
        private System.Windows.Forms.RadioButton rbticket;
        private System.Windows.Forms.RadioButton rbgenericproduct;
        private System.Windows.Forms.GroupBox gbproductcontrol;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox tbquantityinstockgeneric;
        private System.Windows.Forms.Label lblquantityinstockgeneric;
    }
}