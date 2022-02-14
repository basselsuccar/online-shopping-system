using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.orderbase;
using project1csc323.feature;
using project1csc323.users;

namespace project1csc323.productbase
{
    public abstract class product
    {
        public string productid { get; set; }
        public string productname { get; set; }
        public string description { get; set; }
        public decimal unitprice { get; set; }
        public int productquantity { get; set; } = 1;
        public int productquantityininventory { get; set; }
        public bool isticket { get; set; }


        public product(string _productid, string _productname, int _unitprice, int _productinventory)
        {
            productid = _productid;
            productname = _productname;
            unitprice = _unitprice;
            description = "no description available";
            productquantityininventory = _productinventory;
        }
        public product(string _productid, string _productname, int _unitprice, string _description,int _productinventory)
        {
            productid = _productid;
            productname = _productname;
            unitprice = _unitprice;
            description = _description;
            productquantityininventory = _productinventory;
        }
        public  void editproductinfo(string _id,string _name,int _price,string _description,int _productinventory)
        {
            productid = _id;
            productname = _name;
            unitprice = _price;
            description = _description;
            productquantityininventory = _productinventory;
                
        }
        public virtual product clone()
        {
            product e = (product)MemberwiseClone();
            e.productquantity = this.productquantity;
            return e;
        }
       
    
        public virtual string printinfo()
        {
            StringBuilder a = new StringBuilder();
            
            a.Append($"productid=  {productid} productname={productname } unitprice={unitprice} quantity={productquantity}");
            a.AppendLine();
            a.Append($"description={description}")
                .AppendLine();
            return a.ToString();

        }
    }
}
