using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;

namespace LogicTier
{
    public class UserLogicTier
    {
        public String UserName { get; set; }
        public String Password { get; set; }

        //CONSTRUCTOR
        public UserLogicTier()
        {
            
        }

        Connections connections = new Connections();

        public String AuthenticateUser(String UserName, String Password)
        {
            String message = "";

            this.UserName = UserName;
            this.Password = Password;

            message = connections.CheckLogin(UserName, Password);
            return message;
        } 
    }
}
