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
   public class costumer:user
    {
       
        public string creditcardinfo { get; set; }
        public shoppingcart shoppingcart_ { get; set; }
       public List<order> orders { get; set; }
        public admin administrator { get; set; }
        public int counter { get; set; } = 1;
        public inventory storeinventory { get; set; }
        public costumer(string name,string _lastname,string _address,string _creditcardinfo,  List<order> _orders,admin _admin,  string _userid, string _email,string _password,loginstatus _status,inventory _storeinventory):
            base(_userid, _email, _password, _status,name,_lastname,_address)
        {
            
            creditcardinfo = _creditcardinfo;
            shoppingcart_ = new shoppingcart(this.userid, new List<product> { }, _storeinventory);
            orders = _orders ?? new List<order>();
            administrator = _admin;
            administrator.costumers.Add(this);
        }
      
        public void addorder(order k)
        {
            bool alreadyin = false;
            foreach (var order in orders)
            {
                if (k.orderid == order.orderid)
                {
                    alreadyin = true;
                }
            }
            if (alreadyin == false)
            {
                orders.Add(k);
            }
        }
        public void removeorder(order k)
        {
            for (int i= 0;i < orders.Count;i++)
            {
                if (k.orderid == orders[i].orderid)
                {
                    orders.RemoveAt(i);
                }
            }
        }
       

        public string printinfo()
        {
            StringBuilder a = new StringBuilder();
            a.Append("costumer info:");
            a.AppendLine();
            a.Append($"user id:" + userid + " email:" + email +"  address:"+address+ " status:" + status.ToString());
            a.AppendLine();
            
                    a.Append($"shopping cart  info: ");
                    a.AppendLine();
                    counter++;
                    a.Append(shoppingcart_.printinfo());
                    a.AppendLine();
                
            
            if (orders.Count != 0)
            {
                counter = 1;
                foreach (var ord in orders)
                {
                    a.Append($"order #{counter.ToString()} info: ");
                    a.AppendLine();
                    counter++;
                    a.Append(ord.printinfo());
                }
            }
            else
            {
                a.Append("no orders available")
                                    .AppendLine();
            }
            return a.ToString();

        }
    }
}
