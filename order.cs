using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.users;
using project1csc323.feature;
using project1csc323.productbase;


namespace project1csc323.orderbase
{
    public class order
    {
        public string orderid { get; set; }
        public DateTime dateordered { get; set; }
        public List<product> products { get; set; }
        public decimal grandtotal {  get { return products.Sum(x => x.unitprice * x.productquantity)+shipping.shippingcost; } }
        public shippinginfo shipping { get; set; }
        public orderstatus order_status { get; set; }
        public static int counter { get; set; } = 1;
        public int quantity { get; set; }
        public bool hasdiscount { get; set; } = false;
        public Idiscountonorder discount { get; set; }
        public string discountname { get; set; } = "no discount applied";
        public inventory storeproducts { get; set; }


        public order(string order_id, DateTime date_ordered, List<product> _products, shippinginfo shipping_, orderstatus _status, inventory _storeproducts)
        {
            orderid = order_id;
            dateordered = date_ordered;
            products = _products ?? new List<product>();
            shipping = shipping_;
            order_status = _status;
            quantity = 0;
            discount = null;
            storeproducts = _storeproducts;
        }


            public void incrementproductquantity( product e)
        {
            if (this.order_status == orderstatus.delayed)
            {
                foreach (var prod in products)
                {
                    if (prod.productid == e.productid && prod.productquantityininventory > prod.productquantity)
                    {
                        prod.productquantity++;
                        e.productquantityininventory--;
                    }
                }
            }
        }
        public void addproducttoorder(product p)
        {
            if (this.order_status == orderstatus.delayed)
            {
                bool found = false;
                for (var a = 0; a < products.Count; a++)
                {
                    if (p.productid == products[a].productid && products[a].productquantityininventory > products[a].productquantity)
                    {
                        this.incrementproductquantity(p);
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
        }
        public void adddiscount(Discount a)
        {
            if (this.order_status != orderstatus.arrived)
            {
                if (this.hasdiscount == false)
                {
                    a.applydiscountonorder(this);
                    this.hasdiscount = true;
                }
            }
        }
        public void removeproductfromsorder(product p)
        {
            if (this.order_status == orderstatus.delayed)
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
        }
       
       

        public string printinfo()
        {
            if (products.Count != 0)
            {
                StringBuilder a = new StringBuilder();
              
                a.Append($"orderid={orderid} date created= {dateordered.ToString()} discount:{discountname}")
                    .AppendLine()
                    .Append(shipping.printinfo())
                    .AppendLine()
                    .Append("products in order:")
                    .AppendLine();

                foreach (var prod in products)
                {
                    a.Append(prod.printinfo());

                    quantity += prod.productquantity;
                }
                a.Append("items in order=  " + quantity.ToString())
                    .AppendLine()
                    .Append("grand total= " + grandtotal.ToString());


                return a.ToString();
            }
            else return "";
        }
    }
    public enum orderstatus
    {
        onitsway,
        delayed,
        arrived,
    }
}
