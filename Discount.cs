using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.orderbase;
using project1csc323.productbase;
using project1csc323.users;

namespace project1csc323.feature
{
   public abstract class  Discount:Idiscountoncart,Idiscountonorder
    {
        
        public virtual string Name { get; set; }
        public virtual string discountcode { get; set; }
        public virtual order applydiscountonorder(order a) {
            return a;//to be overriden
        }
        public virtual shoppingcart applydiscountoncart(shoppingcart b)
        {
            return b;//to be overriden
        }



        public Discount() { }
        public Discount(string _Name,string code)
        {
            Name = _Name;
            discountcode = code;
        }

    }
}
