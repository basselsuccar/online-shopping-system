using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.productbase;
using project1csc323.feature;
using project1csc323.users;

namespace project1csc323.orderbase
{
    public class shoppingcart
    {
        public string cartid { get; set; }
        public int quantity { get; set; }
        public DateTime datecreated { get; set; }
        public List<product> products { get; set; }
        public sorting sortcart { get; set; }
        public inventory storeproducts { get; set; }

        public Idiscountoncart discount { get; set; }
        public bool hasdiscount { get; set; } = false;
        public string discountname { get; set; } = "no discount applied";
        public decimal grandtotal { get { return products.Sum(x => x.unitprice * x.productquantity); }
        }
        public shoppingcart(string _cartid, List<product> _products, inventory _storeproducts)
        {
            cartid = _cartid;
            quantity = 0;
            datecreated = DateTime.Now;
            products =new List<product> { };
            storeproducts = _storeproducts;
            discount = null;
            foreach(var prod in _products)
            {
                this.addproducttoshoppingcart(prod);
            }
            sortcart = new sorting(this);

        }
        public void incrementproductquantity( product _product)
        {
            
                foreach (var prod in this.products)
                {
                    if (prod.productid == _product.productid && prod.productquantityininventory>prod.productquantity)
                    {
                        prod.productquantity++;
                    _product.productquantityininventory--;
                    }
                }
            
        }


       
       
        public void addproducttoshoppingcart( product p)
        {
            bool found=false;
            for (var a = 0; a < products.Count; a++)
            {
                if (p.productid == products[a].productid && products[a].productquantityininventory > products[a].productquantity)
                {
                    this.incrementproductquantity( p);
                    found = true;
                }
            }
            if (found == false)
            {
                foreach (var prod in storeproducts.productsininventory)
                {
                    if (prod.productid == p.productid)
                    {
                        product e = p.clone();
                        p.productquantityininventory--;
                        products.Add(e);
                    }
                }
            }
        }
        public void removeproductfromshoppingcart(product p)
        {
            for (var a = 0; a < products.Count; a++)
            {
                if (p.productid == products[a].productid)
                {
                    products.RemoveAt(a);
                    p.productquantityininventory++;
                }
            }

        }
        public void adddiscount(Discount b)
        {
            if (this.hasdiscount == false)
            {
                b.applydiscountoncart(this);
                this.hasdiscount = true;
            }
        }
        public void checkoutcart( costumer a,shippinginfo q)
        {
            List<product> boughtproducts = new List<product> { };
            foreach(var prod in products)
            {
                boughtproducts.Add(prod);
            }
            order t = new order(this.cartid, this.datecreated, boughtproducts, q, orderstatus.onitsway,this.storeproducts);
            if (this.hasdiscount==true)
            {
                t.hasdiscount = true;
            }
            a.orders.Add(t);
            this.products.Clear();
           
        }
        public string printinfo()
        {
            if (products.Count != 0)
            {
                StringBuilder a = new StringBuilder();
               
                a.Append($"cartid={ cartid}date created={datecreated.ToString()} discount={discountname}")
                    .AppendLine()
                    .Append("products in shopping cart:")
                    .AppendLine();

                foreach (var prod in products)
                {
                    a.Append(prod.printinfo());

                    quantity += prod.productquantity;
                }
                a.Append("items in cart=  " + quantity.ToString())
                    .AppendLine()
                    .Append($"grand total={grandtotal}")
                    .AppendLine();

                return a.ToString();
            }
            else return "";
        }
    }
}
