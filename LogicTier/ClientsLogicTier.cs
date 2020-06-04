using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using System.Data.SqlClient;
using System.Data;


namespace LogicTier
{
    public class ClientsLogicTier
    {

        //Atributes
        static public String ClientCode { get; set; }
        public String ClientName { get; set; }
        public String ClientContactLastName { get; set; }
        public String ClientContactFirstName { get; set; }
        public String Telephone { get; set; }
        public String ClientAddress1 { get; set; }
        public String ClientAddress2 { get; set; }
        public String ClientCity { get; set; }
        public String ClientZone { get; set; }
        public String ClientCountry { get; set; }
        public String ClientPostCode { get; set; }
        public String ClientEmployeeSalesRep { get; set; }

        //References Connections
        Connections connections = new Connections();

        public DataTable ShowClientsTable(String clientCode)
        {
            DataTable dataTable = connections.SearchClient(clientCode);
            return dataTable;
        }

        

        
        
        
        

    }
}
