using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.feature;
using project1csc323.productbase;
using project1csc323.users;

namespace project1csc323.orderbase
{
  public class inventory 
    {
        public static inventory instance;
        public List<product> productsininventory { get; set; }
        private inventory(List<product> products) {
            productsininventory = products;

        }
        public static inventory getinstance(List<product> products)
        {
            if (instance == null)
            {
                instance = new inventory(products);
            }
                return instance;
            
        }
        public void addproducttoinventory(product a)
        {
            bool found = false;
            foreach(var prod in productsininventory)
            {
                if (a.productid == prod.productid)
                {
                    found = true;
                }
            }
            if (found == false)
            {
                this.productsininventory.Add(a);
            }
        }
        public void removeproductfrominventory(product p)
        {
            for (var a = 0; a < productsininventory.Count; a++)
            {
                if (p.productid == productsininventory[a].productid)
                {
                    productsininventory.RemoveAt(a);
                }
            }

        }
    }
}
