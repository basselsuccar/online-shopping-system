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
    public class buyxgetyfree:Discount
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<product> applicableproducts { get; set; }
        public buyxgetyfree(string _name,string code,List<product> _applicableproducts)
        {
            Name = _name;
            discountcode = code;
            applicableproducts = _applicableproducts;
        }
        public override shoppingcart applydiscountoncart(shoppingcart b)
        {
            
            foreach (var a in b.products)
            {
                if (applicableproducts.Contains(a) && a.productquantity >= X)
                {
                    decimal discountammount = 0;
                    b.discountname = Name;
                    discountammount += ((a.productquantity / X) * Y) * a.unitprice;
                    a.unitprice = a.unitprice - discountammount;
                }
            }
            
            return b;
        }
        public override order applydiscountonorder(order a)
        {
            decimal discountammount = 0;
            foreach (var b in a.products)
            {
                if (applicableproducts.Contains(b) && b.productquantity >= X)
                {
                    a.discountname = Name;
                    discountammount += ((b.productquantity / X) * Y) * b.unitprice;
                    b.unitprice = b.unitprice - discountammount;
                }
            }
            
            return a;
        }
    }
}
