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
    public interface Idiscountonorder
    {
      string Name { get; set; }
        order applydiscountonorder(order a);
    }
}
