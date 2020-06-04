using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using System.Data;

namespace LogicTier
{
    public class Persons
    {
        //Employee Attribute
        //public int isEmployee = 0;

        //Attributes
        public String Id_Personal { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public Char Gender { get; set; }
        public String PAddress { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Persons()
        {

        }

        //References Conections.cs
        Connections connections = new Connections();

        //Register Persons
        public String RegisterPersons()
        {
            String message;

            List<Parameters> list = new List<Parameters>();

            try
            {
                //Parameters IN

                list.Add(new Parameters("@Id_Personal", Id_Personal));
                list.Add(new Parameters("@LastName", LastName));
                list.Add(new Parameters("@FirstName", FirstName));
                list.Add(new Parameters("@Gender", Gender));
                list.Add(new Parameters("@PAddress", PAddress));
                list.Add(new Parameters("@DateOfBirth", DateOfBirth));

                //Parameters OUT
                list.Add(new Parameters("@Message", SqlDbType.VarChar, 100));             

                connections.ModifDB("Register_Person", list);
                message = list[6].Value.ToString();
                
            }
            catch (Exception exception)
            {

                throw exception;
            }

            return message;
        }

        public DataTable Persons_list()
        {
            return connections.GetData("Show_Person", null);
        }
    }
}
