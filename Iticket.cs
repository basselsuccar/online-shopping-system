using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.feature;
using project1csc323.orderbase;
using project1csc323.productbase;
using project1csc323.users;

namespace project1csc323.productbase
{
    interface Iticket
    {
         string row { get; set; }
         string seat { get; set; }
        DateTime eventdate { get; set; }
        DateTime doorsopenat { get; set; }
        string showname { get; set; }
        string eventlocation { get; set; }

    }
}
