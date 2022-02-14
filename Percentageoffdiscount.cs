using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.productbase;
using project1csc323.orderbase;
using project1csc323.users;

namespace project1csc323.feature
{
     public class Percentageoffdiscount:Discount
    {
        public decimal Discountpercentage{ get; set; }
        public Percentageoffdiscount(string _name,string code,decimal discountpercentage):base(_name,code)
        {
            Discountpercentage = discountpercentage;
        }
        public override shoppingcart applydiscountoncart(shoppingcart b)
        {
            b.discountname = $"{Discountpercentage} % on all products";
            for(var a=0;a<b.products.Count;a++ )
            {
                b.products[a].unitprice *= (1 - Discountpercentage/100);
            }
            return b;
        }
        public override order applydiscountonorder(order a)
        {
            a.discountname = $"{Discountpercentage} % on all products";
            for (var i = 0; i < a.products.Count; i++)
            {
                a.products[i].unitprice *= (1 - Discountpercentage / 100);
            }
            return a;
        }
    }
}
