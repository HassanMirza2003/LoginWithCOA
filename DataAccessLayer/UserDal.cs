using AppProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserDal
    {
        DbCon DbCon = new DbCon();


        public string LoginUser(User user)
        {
            return "Select * from Users Where Email ='" +user.Email +"' And Password = '"+user.Password+"' ";
        }
    }
}
