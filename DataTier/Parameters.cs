using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataTier
{
    public class Parameters
    {
        //Parameters
        public String Name { get; set; }
        public Object Value { get; set; }
        public SqlDbType dbType { get; set; }
        public Int32 Size { get; set; }
        public ParameterDirection parameterDirection { get; set; }

        //CONSTRUCTORS
        //IN
        public Parameters (String objName, Object objValue)
        {
            Name = objName;
            Value = objValue;
            parameterDirection = ParameterDirection.Input;
        }

        //OUT
        public Parameters(String objName, SqlDbType objdbType, Int32 objSize)
        {
            Name = objName;
            dbType = objdbType;
            Size = objSize;
            parameterDirection = ParameterDirection.Output;
        }
    }
}
