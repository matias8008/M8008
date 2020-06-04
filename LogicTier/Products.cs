using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using System.Data;

namespace LogicTier
{
    public class Products
    {
        //Attributes
        public String ProductCode { get; set; }
        public String ProductName { get; set; }
        public String Dimentions { get; set; }
        public String ProductProvider { get; set; }
        public String ProductDescription { get; set; }
        public int Stock { get; set; }
        public Double SalePrice { get; set; }
        public Double BuyPrice { get; set; }
        public int Categorie { get; set; }

        public Products()
        {

        }

        //References Conections.cs
        Connections connections = new Connections();

        

        public String RegisterProducts()
        {
            String message="";

            List<Parameters> list = new List<Parameters>();

            try
            {
                //  IN
                list.Add(new Parameters("@ProductCode", ProductCode));
                list.Add(new Parameters("@ProductName", ProductName));
                list.Add(new Parameters("@Dimentions", Dimentions));
                list.Add(new Parameters("@Productprovider", ProductProvider));
                list.Add(new Parameters("@Productdescription", ProductDescription));
                list.Add(new Parameters("@Stock", Stock));
                list.Add(new Parameters("@SalePrice", SalePrice));
                list.Add(new Parameters("@BuyPrice", BuyPrice));
                list.Add(new Parameters("@Categorie", Categorie));

                //  OUT
                list.Add(new Parameters("@Message", SqlDbType.VarChar, 100));

                connections.ModifDB("Register_Products", list);
                message = list[9].Value.ToString();
            }

            catch (Exception exception)
            {

                throw exception;
            }

            return message;
        }

        public DataTable Product_list()
        {
            return connections.GetData("Show_Products", null);
        }

    }
}
