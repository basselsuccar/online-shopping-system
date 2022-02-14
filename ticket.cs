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
    public class tickets : product
    {
        public string row { get; set; }
        public string seat { get; set; }
        public DateTime eventdate { get; set; }
        public DateTime doorsopenat { get; set; }
        public string showname { get; set; }
        public string eventlocation { get; set; }

        public tickets(string _productid, string _productname, int _unitprice,string _row,string _seat,DateTime _eventdate,DateTime _doorsopenat,string _eventlocation,string _showname, int _countininventory)
          : base(_productid, _productname, _unitprice, "no description", _countininventory)
            
        {
            row = _row;
            seat = _seat;
            eventdate = _eventdate;
            doorsopenat = _doorsopenat;
            showname = _showname;
            eventlocation = _eventlocation;
            isticket = true;
            

        }
        
        public void editticketinfo(string _productid, string _productname, int _unitprice, string _row, string _seat, DateTime _eventdate, DateTime _doorsopenat,  string _eventlocation, string _showname,int _countininventory)
        {
            base.editproductinfo(_productid, _productname, _unitprice,"no description",_countininventory);
            row = _row;
            seat = _seat;
            eventdate = _eventdate;
            doorsopenat = _doorsopenat;
            showname = _showname;
            eventlocation = _eventlocation;

        }
        public override product clone()
        {
            tickets e = (tickets)MemberwiseClone();
            e.productquantity = this.productquantity;
            return e;
        }
        public override string printinfo()
        {
            StringBuilder a = new StringBuilder();

            a.Append("productid=  " + productid + " productname=  " + productname + " unitprice=  " + unitprice + " quantity=" + productquantity);
            a.AppendLine()
                .Append($"showname={showname} event location={eventlocation} row={row} seat={seat} doors open at={doorsopenat} show starts at={eventdate}")
                .AppendLine()
                .Append($"description={description}")
                .AppendLine();
            return a.ToString();
        }
    }
    
}
