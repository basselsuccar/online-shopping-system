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
   public class spendxgetydiscount:Discount
    {
        public decimal threshhold { get; set; }
        public decimal discountpercentage{ get; set; }

        public spendxgetydiscount(string _name,string code,decimal _threshhold,decimal _discount):base(_name,code)
        {
            threshhold = _threshhold;
            discountpercentage = _discount;
        }
        public override shoppingcart applydiscountoncart(shoppingcart b)
        {
            if (b.grandtotal > threshhold)
            {
                b.discountname = Name;
                foreach(var a in b.products)
                {
                    a.unitprice = a.unitprice * (1 - discountpercentage/100);
                }
            }
            return b;
        }
        public override order applydiscountonorder(order a)
        {
            if (a.grandtotal-a.shipping.shippingcost > threshhold)
            {
                a.discountname = Name;
                foreach (var b in a.products)
                {
                    b.unitprice = b.unitprice * (1 - discountpercentage);
                }
            }
            return a;

        }

    }
}
