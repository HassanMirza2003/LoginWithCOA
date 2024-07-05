using AppProps;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UserBll
    {
        UserDal userDal = new UserDal();
        public string LoginUserBll(User user)
        {
            return userDal.LoginUser(user);
        }
    }
}
