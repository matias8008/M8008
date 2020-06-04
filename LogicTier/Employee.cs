using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using System.Data;

namespace LogicTier
{
    public class Employee : Persons
    {
        //Attributes
        public String Id_Employee { get; set; }
        public DateTime SystemInDate { get; set; }
        public DateTime FirstDayEmployed { get; set; }
        public String Category { get; set; }
        public String Departament { get; set; }

        public Employee()
        {

        }

        //References Conections.cs
        Connections connections = new Connections();

        //Register Employee
        public String RegisterEmployee()
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
                list.Add(new Parameters("@DateOfBirth", this.DateOfBirth));
                list.Add(new Parameters("@SystemInDate", SystemInDate));
                //list.Add(new Parameters("@FirstDayEmployed", FirstDayEmployed));
                //list.Add(new Parameters("@Category", Category));
                //list.Add(new Parameters("@Departament", Departament));
                list.Add(new Parameters("@Id_Employee", Id_Employee));

                //Parameters OUT
                list.Add(new Parameters("@Message", SqlDbType.VarChar, 100));

                connections.ModifDBE("Register_Person_Employee", list);

                message = list[7].Value.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }

            return message;
        }

        public DataTable Employee_list()
        {
            return connections.GetData("Show_Employee", null);
        }

        public DataTable Search_Employee(String newQuery)
        {
            List<Parameters> list = new List<Parameters>();

            try
            {
                list.Add(new Parameters("@newQuery", newQuery));
            }
            catch (Exception e)
            {
                throw e;
               
            }

            return connections.GetData("Search_Employee", list);
        }

    }
}
