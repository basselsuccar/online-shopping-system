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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static costumer currentcostumer = Form1.currentcostumer;
        public inventory storeinventory = Form1.storeinventory;
        public static List<costumer> costumerslist = new List<costumer> { };
        public admin storeadmin = Form1.storeadmin;
        List<Discount> discounts = new List<Discount> { new spendxgetydiscount("spend 50 get 10% off", "10%off", 50, 10), new Percentageoffdiscount("50% off", "halfoff", 50) };

        private void rbtngenericproducts_CheckedChanged(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();
            foreach (var prod in storeinventory.productsininventory)
            {
                if (prod.isticket == false)
                {
                    lbproducts.Items.Add(prod.productname);
                }
            }
        }

        private void rdbtntickets_CheckedChanged(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();
            foreach (var prod in storeinventory.productsininventory)
            {
                if (prod.isticket == true)
                {
                    lbproducts.Items.Add(prod.productname);
                }
            }
        }

        private void lbproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationException noitemselected = new ApplicationException("please select an item.");
            if (lbproducts.SelectedIndex == -1)
            {

                MessageBox.Show(noitemselected.Message);
            }
            else
            {
                foreach (var prod in storeinventory.productsininventory)
                {
                    if (prod.productname == (string)lbproducts.SelectedItem)
                    {
                        tbproductinfo.Text = prod.printinfo();
                        tbproductinfo.Visible = true;
                    }
                }
            }
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            cbquantity.Visible = true;
            btncomtinue.Visible = true;
            lblquantity.Visible = true;
            cbquantity.Visible = true;
        }

        private void btncomtinue_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var prod in storeinventory.productsininventory)
                {
                    if (prod.productname == (string)lbproducts.SelectedItem)
                    {
                        currentcostumer.shoppingcart_.addproducttoshoppingcart(prod);

                        if ((string)cbquantity.SelectedItem != "1")
                        {

                            for (int i = Int16.Parse((string)cbquantity.SelectedItem); i > 1; i--)
                            {
                                currentcostumer.shoppingcart_.incrementproductquantity(prod);
                            }
                        }
                        string[] array = new string[4];
                        array[0] = currentcostumer.shoppingcart_.products[currentcostumer.shoppingcart_.products.Count - 1].productid;
                        array[1] = currentcostumer.shoppingcart_.products[currentcostumer.shoppingcart_.products.Count - 1].productname;
                        array[2] = currentcostumer.shoppingcart_.products[currentcostumer.shoppingcart_.products.Count - 1].unitprice.ToString();
                        array[3] = currentcostumer.shoppingcart_.products[currentcostumer.shoppingcart_.products.Count - 1].productquantity.ToString();
                        ListViewItem item = new ListViewItem(array);

                        lvshoppingcart.Items.Add(item);

                    }
                    tbgrandtotal.Text = currentcostumer.shoppingcart_.grandtotal.ToString();
                    lblquantity.Visible = false;
                    cbquantity.Visible = false;
                    btncomtinue.Visible = false;
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("please select a quantity");
            }
        } 

        

        private void btnremoveitem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvshoppingcart.Items.Count; i++)
            {
                if (lvshoppingcart.Items[i].Selected)
                {
                    lvshoppingcart.Items[i].Remove();
                    currentcostumer.shoppingcart_.removeproductfromshoppingcart(currentcostumer.shoppingcart_.products[i]);
                    i--;
                }
            }
            tbgrandtotal.Text = currentcostumer.shoppingcart_.grandtotal.ToString();
        }

        private void cbsorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbsorting.SelectedIndex == 0)
            {
                lvshoppingcart.Items.Clear();
                currentcostumer.shoppingcart_.sortcart.sortwithunitprice();
                foreach (var product in currentcostumer.shoppingcart_.products)
                {
                    string[] array = new string[4];
                    array[0] = product.productid;
                    array[1] = product.productname;
                    array[2] = product.unitprice.ToString();
                    array[3] = product.productquantity.ToString();
                    ListViewItem item = new ListViewItem(array);

                    lvshoppingcart.Items.Add(item);
                }
            }
            else if (cbsorting.SelectedIndex == 1)
            {
                lvshoppingcart.Items.Clear();
                currentcostumer.shoppingcart_.sortcart.reversesortwithunitprice();
                foreach (var product in currentcostumer.shoppingcart_.products)
                {
                    string[] array = new string[4];
                    array[0] = product.productid;
                    array[1] = product.productname;
                    array[2] = product.unitprice.ToString();
                    array[3] = product.productquantity.ToString();
                    ListViewItem item = new ListViewItem(array);

                    lvshoppingcart.Items.Add(item);
                }
            }
        }

        private void btnapplydiscount_Click(object sender, EventArgs e)
        {
            ApplicationException emptydiscountcode = new ApplicationException("no discount code entered.");
            ApplicationException nodiscountfound = new ApplicationException("invalid discount code");
            if (tbdiscountcode.Text == "")
            {
                MessageBox.Show(emptydiscountcode.Message);
            }
            else
            {
                bool found = true;
                foreach (var discount in discounts)
                {
                    if (discount.discountcode == tbdiscountcode.Text)
                    {
                        found = true;
                        lvshoppingcart.Items.Clear();
                        currentcostumer.shoppingcart_.adddiscount(discount);
                        foreach (var product in currentcostumer.shoppingcart_.products)
                        {
                            string[] array = new string[4];
                            array[0] = product.productid;
                            array[1] = product.productname;
                            array[2] = product.unitprice.ToString();
                            array[3] = product.productquantity.ToString();
                            ListViewItem item = new ListViewItem(array);

                            lvshoppingcart.Items.Add(item);
                        }
                        tbgrandtotal.Text = currentcostumer.shoppingcart_.grandtotal.ToString();
                     
                    }
                }
                if (found == false)
                {
                    MessageBox.Show(nodiscountfound.Message);
                }
            }
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            ApplicationException emptycart = new ApplicationException("your cart is empty!");
            if (lvshoppingcart.Items.Count == 0)
            {
                MessageBox.Show(emptycart.Message);
            }
            else
            {
                gbshippinginfo.Visible = true;
                tbshippingcost.Text = (0.05 * Int16.Parse(tbgrandtotal.Text)).ToString();

            }
        }

        private void btnfinalizepurchase_Click(object sender, EventArgs e)
        {
            ApplicationException infomissing = new ApplicationException("info missing!");

            if (tbcountry.Text == "")
            {
                MessageBox.Show(infomissing.Message);
            }
            else if (tbcity.Text == "")
            {
                MessageBox.Show(infomissing.Message);
            }
            else if (tbzipcode.Text == "") MessageBox.Show(infomissing.Message);
            else if (cbshippingtype.SelectedIndex == -1) MessageBox.Show(infomissing.Message);

            else
            {
                try
                {

                    shippinginfo newordershippinginfo;

                    if (cbshippingtype.SelectedIndex == 0)
                    {
                        newordershippinginfo = new shippinginfo(currentcostumer.userid, shippingtype.byland, tbcountry.Text, tbcity.Text, Int16.Parse(tbzipcode.Text));
                    }
                    else if (cbshippingtype.SelectedIndex == 1)
                    {
                        newordershippinginfo = new shippinginfo(currentcostumer.userid, shippingtype.onairplane, tbcountry.Text, tbcity.Text, Int16.Parse(tbzipcode.Text));
                    }
                    else
                    {
                        newordershippinginfo = new shippinginfo(currentcostumer.userid, shippingtype.bysea, tbcountry.Text, tbcity.Text, Int16.Parse(tbzipcode.Text));
                    }

                    lvshoppingcart.Items.Clear();
                    currentcostumer.shoppingcart_.checkoutcart(currentcostumer, newordershippinginfo);
                    MessageBox.Show(currentcostumer.orders[currentcostumer.orders.Count() - 1].printinfo());
                    gbshippinginfo.Visible = false;
                    tbgrandtotal.Text = "0";
                }
                catch (FormatException)
                {
                    MessageBox.Show("invalid zip code");
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnviewhistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(currentcostumer.printinfo());
        }
    }
}

