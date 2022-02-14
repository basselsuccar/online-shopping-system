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
    interface Iphysicalproduct
    {
        string brand { get; set; }

         int wheight { set; get; }
         string countrymadein { set; get; }
         string color { set; get; }
        
          
    }
}
