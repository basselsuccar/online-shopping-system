using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.feature;
using project1csc323.orderbase;

using project1csc323.users;

namespace project1csc323.productbase
{
  public class physicalproduct:product,Iphysicalproduct
    {
        public string brand { get; set; }

        public int wheight { set; get; }
        public string countrymadein { set; get; }
        public string color { set; get; }
        public physicalproduct(string _productid, string _productname, int _unitprice,string _color, string _countrymadein, int _wheight, string _brand,  string _description,int _countininventory)
           : base(_productid, _productname, _unitprice,_description,_countininventory)
        {
            wheight = _wheight;
            countrymadein = _countrymadein;
            brand = _brand;
            isticket = false;
            color = _color;
        }
       
        public void editphysicalprodinfo(string _productid, string _productname, int _unitprice, string _countrymadein, int _wheight, string _brand, string _description,string _color,int _countininventory)
        {
            base.editproductinfo(_productid, _productname, _unitprice,_description,_countininventory);
            wheight = _wheight;
            countrymadein = _countrymadein;
            brand = _brand;
            
            color = _color;
        }
        public override product clone()
        {
            physicalproduct e = (physicalproduct)MemberwiseClone();
            e.productquantity = this.productquantity;
            return e;
        }

        public override string printinfo()
        {
            StringBuilder a = new StringBuilder();

            a.Append(base.printinfo());
            a.AppendLine()
                .Append($"product wheight={wheight}grams  made in {countrymadein} brand={brand} color={color}")
                .AppendLine()
                .AppendLine();
               
            return a.ToString();
        }
    }
}
