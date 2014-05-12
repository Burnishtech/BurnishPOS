using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSDataManager.Entity;
using POSDataManager.DataManager;

namespace POSBizManager.BizManager
{
    public class UserBizManager
    {
        UserDataManager udm = new UserDataManager();
         List<User> getAllUser()  
        {
            return udm.getAllUser();
        }
         public bool validateUser(string username, string password)
        {
            //+ Here you would implement code, which will get the validation for the given credentials
            //+ from a database, a webservice or from somewhere else
            //! Remember : ONLY for demonstration purposes I have used a local Collection

            User validatedUser = udm.getAllUser().FirstOrDefault(user => user.UserName.Equals(username) && user.Password.Equals(password));
            return validatedUser != null;
        }
    }
}
