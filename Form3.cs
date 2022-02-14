using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project1csc323.feature;
using project1csc323.orderbase;
using project1csc323.productbase;
using project1csc323.users;

namespace project1csc323
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public admin storeadmin = Form1.storeadmin;
        public inventory storeinventory = Form1.storeinventory;

      
        private void btndeletehistory_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < storeadmin.costumers.Count(); i++)
            {
                if (i == lbcostumerlist.SelectedIndex)
                {
                    storeadmin.deletecostumerinfo(storeadmin.costumers[i]);
                    MessageBox.Show("costumer history deleted");
                }
            }
        }

        private void btnviewinfo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < storeadmin.costumers.Count(); i++)
            {
                if (i == lbcostumerlist.SelectedIndex)
                {
                   MessageBox.Show( storeadmin.costumers[i].printinfo());
                }
            }
        }

        private void rbticket_CheckedChanged(object sender, EventArgs e)
        {
            gbnewgenericproduct.Visible = false;
            gbaddticket.Visible = true;
           
        }

        private void rbgenericproduct_CheckedChanged(object sender, EventArgs e)
        {
            gbaddticket.Visible = false;
            gbnewgenericproduct.Visible = true;
        }

        private void btnaddgenericproduct_Click(object sender, EventArgs e)
        {
            ApplicationException infomissing = new ApplicationException("info missing!");

            if (tbbrand.Text == "")
            {
                MessageBox.Show(infomissing.Message);
            }
            else if (tbcolor.Text == "")
            {
                MessageBox.Show(infomissing.Message);
            }
            else if (tbdescription.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbgenericprodid.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbgenericprodname.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbgenericprodunitprice.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbmadein.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbweight.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbquantityinstockgeneric.Text == "") MessageBox.Show(infomissing.Message);
            else
            {
                try
                {
                    storeinventory.addproducttoinventory(new physicalproduct(tbgenericprodid.Text, tbgenericprodname.Text,
                        Int16.Parse(tbgenericprodunitprice.Text), tbcolor.Text, tbmadein.Text, Int16.Parse(tbweight.Text), tbbrand.Text, tbdescription.Text,Int16.Parse(tbquantityinstockgeneric.Text)));
                    MessageBox.Show("product added");
                   
                }
                catch (FormatException)
                {
                    MessageBox.Show("please insert an integer when an integer is required.");
                }
            }

        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            ApplicationException infomissing = new ApplicationException("info missing!");
            if (tbproductid.Text == "")
            {
                MessageBox.Show(infomissing.Message);
            }
            else if (tbproductname.Text == "")
            {
                MessageBox.Show(infomissing.Message);
            }
            else if (tbquantityinstock.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbrow.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbseat.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbshowname.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbunitprice.Text == "") MessageBox.Show(infomissing.Message);
            else if (tbeventlocation.Text == "") MessageBox.Show(infomissing.Message);
            else
            {
                try
                {
                    storeinventory.addproducttoinventory(new tickets(tbproductid.Text, tbproductname.Text, Int16.Parse(tbunitprice.Text),
                        tbrow.Text, tbseat.Text, eventdatepicker.Value, doorsopenatpicker.Value, tbeventlocation.Text, tbshowname.Text, Int16.Parse(tbquantityinstock.Text)));
                    MessageBox.Show("product added");

                }
                catch (FormatException)
                {
                    MessageBox.Show("please insert an integer when an integer is required.");
                }

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach(var costumer in storeadmin.costumers)
            {
                lbcostumerlist.Items.Add($"{costumer.userid},  {costumer.firstname} {costumer.lastname}");
            }
        }
    }
}
