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
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<product> storeproducts = new List<product> { new physicalproduct("rt5743", "trimmer", 20, "black", "china", 90, "braun", "description",10), new physicalproduct("123av", "cane", 12, "blue", "china", 22, "CAT", "description",18),
         new physicalproduct("123", "ball", 12, "blue", "china", 22, "nike", "description",100), new tickets("1208", "concert ticket", 100, "d5", "c5", DateTime.Now, DateTime.Now, "beirut", "imagine dragons",55)};

        public static inventory storeinventory = inventory.getinstance(storeproducts);
        public static List<costumer> costumerslist = new List<costumer> { };
        public  static admin storeadmin = new admin("joe", "doe", "lebanon", 2012, "sd32", "joe@gmail.com", "0000", loginstatus.online);
        public static costumer currentcostumer;

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (tbemail.Text == "admin" && tbpassword.Text == "admin")
            {
                Form3 adminside = new Form3();
                
                adminside.ShowDialog();
                
            }
            else {
                bool found = false;
                foreach (var cost in costumerslist)
                {
                    if (tbemail.Text == cost.email && tbpassword.Text == cost.password)
                    {
                        found = true;
                        currentcostumer = cost;
                        Form2 store = new Form2();
                        store.ShowDialog();
                    }
                }
                if (found == false)
                {
                    gbsignup.Visible = true;
                    ApplicationException signup = new ApplicationException("sign up!");
                    MessageBox.Show(signup.Message);
                } }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            ApplicationException infomissing = new ApplicationException("info missing!");
            
            if (tbcreditcardinfo.Text == "")
            {
                MessageBox.Show(infomissing.Message);
            }
            else if (tbaddress.Text == "")
            {
                MessageBox.Show(infomissing.Message);
            }
            else if(tbemailsignup.Text=="") MessageBox.Show(infomissing.Message); 
            else if(tbfirstname.Text=="") MessageBox.Show(infomissing.Message); 
            else if(tblastname.Text=="") MessageBox.Show(infomissing.Message); 
            else if(tbpasswordsignup.Text=="") MessageBox.Show(infomissing.Message);
            else
            {
                Random randomizer = new Random();
                costumer newcostumer = new costumer(tbfirstname.Text, tblastname.Text, tbaddress.Text, tbcreditcardinfo.Text, new List<order> { }, storeadmin, randomizer.Next(1, 1000).ToString(), tbemailsignup.Text, tbpasswordsignup.Text, loginstatus.online, storeinventory);
                currentcostumer = newcostumer;
                costumerslist.Add(newcostumer);
                Form2 store = new Form2();
                store.ShowDialog();
            }
        }
    }
    
}
