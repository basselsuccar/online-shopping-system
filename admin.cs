using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.orderbase;
using project1csc323.feature;
using project1csc323.productbase;

namespace project1csc323.users
{
   public class admin:user
    {
        
        public int salary { get; set; }
        public int yearjoined { get; set; }
        public int yearsinservice { get { return DateTime.Now.Year - yearjoined; }}
        public List<costumer> costumers { get; set; }
        public admin(string _name, string _lastname, string _address, int _yearjoined, string _userid, string _email, string _password, loginstatus _status):base(_userid,_email,_password,_status,_name,_lastname,_address)
        {
            
            yearjoined = _yearjoined;
            if (yearsinservice > 3)
            {
                salary = 2000;
            }
            else if (yearsinservice <= 3)
            {
                salary = 1000;
            }
            costumers =new List<costumer>{ };
        }
        public void managecostumerorders()
        {
            foreach(var a in costumers)
            {
                for(int i = 0; i < a.orders.Count; i++)
                {
                    if (a.orders[i].order_status == orderstatus.arrived)
                    {
                        a.orders.RemoveAt(i);
                    }
                }
            }
        }
        public void deletecostumerinfo(costumer a)
        {
            for(int i = 0; i < costumers.Count; i++)
            {
                if (a.userid == costumers[i].userid)
                {
                    costumers[i].orders.Clear();
                    costumers[i].shoppingcart_.products.Clear();
                }
            }
        }
    }
}
