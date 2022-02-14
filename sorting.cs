using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.users;
using project1csc323.orderbase;
using project1csc323.productbase;

namespace project1csc323.feature
{
   public class sorting
    {
        public shoppingcart cart { get; set; }
        public sorting(shoppingcart _cart)
        {
            cart = _cart;
        }
        public void sortwithunitprice()
        {
            for (int i = 0; i < cart.products.Count; i++)
            {
                for (int j = i + 1; j < cart.products.Count; j++)
                {
                    if (cart.products[i].unitprice > cart.products[j].unitprice)
                    {
                        product temp = null;
                        temp = cart.products[i];
                        cart.products[i] = cart.products[j];
                        cart.products[j] = temp;
                    }
                }
            }
        }
        public void reversesortwithunitprice()
        {
            for (int i = 0; i < cart.products.Count; i++)
            {
                for (int j = i + 1; j < cart.products.Count; j++)
                {
                    if (cart.products[i].unitprice < cart.products[j].unitprice)
                    {
                        product temp = null;
                        temp = cart.products[i];
                        cart.products[i] = cart.products[j];
                        cart.products[j] = temp;
                    }
                }
            }
        }
    }
}
