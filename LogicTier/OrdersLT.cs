using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using System.Data;

namespace LogicTier
{
    class OrdersLT
    {
        //Attributes
        static public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderArranged { get; set; }
        public DateTime OrderDelivered { get; set; }
        public String OrderStatus { get; set; }
        public String OrderComments { get; set; }
        public int ClientCode { get; set; }
        
        //References Connections
        Connections connections = new Connections();
        /*
        public DataTable ShowOrders()
        {
            DataTable dataTable

        }*/
    }

    
}
