using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.orderbase;
using project1csc323.feature;
using project1csc323.users;

namespace project1csc323.orderbase
{
   public class shippinginfo
    {
        public string shippingid { get; set; }
        public shippingtype status { get; set; }
        public int shippingcost { get; set; }
        public string country { get; set; }
        public string city { get; set; }

        public int zipcode { get; set; }
        public shippinginfo(string _shippingid,shippingtype _status,int _shippingcost,string _country,string _city,int _zipcode)
        {
            shippingid = _shippingid;
            status = _status;
            shippingcost = _shippingcost;
            country = _country;
            city = _city;
            zipcode = _zipcode;
        }
        public shippinginfo(string _shippingid, shippingtype _status, string _country, string _city, int _zipcode)
        {
            shippingid = _shippingid;
            status = _status;
            shippingcost = 0;
            country = _country;
            city = _city;
            zipcode = _zipcode;
        }
        public void editshippinginfo(string _shippingid, shippingtype _status, string _country, string _city, int _zipcode)
        {
            shippingid = _shippingid;
            status = _status;
            shippingcost = 0;
            country = _country;
            city = _city;
            zipcode = _zipcode;
        }

        public string printinfo()
        {
            StringBuilder a = new StringBuilder();
            a.Append("shipping info:")
                .AppendLine()
                .Append($"shipping id={ shippingid}  shipping type={status.ToString()} shipping cost={shippingcost.ToString()} ")
                .Append($"country={country} city={city} zipcode={zipcode.ToString()}")
                .AppendLine();
            return a.ToString();
            
        }

    }

    }

    public enum shippingtype
    {
        byland,
        onairplane,
        bysea,
    }

