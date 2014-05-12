using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSDataManager.Entity;
using System.IO;

namespace POSDataManager.DataManager
{
    public class UserDataManager
    {
        #region Fields

        List<User> userList;
		private readonly string userImagesPath = @"\Images";

		#endregion // Fields
        
        public List<User> getAllUser()
        {

            this.userList = new List<User>()
								 {
									new User() { UserName="tapas", Password="nayak",
													 ImageSourcePath = Path.Combine( userImagesPath, "DemoUser2.png") },
									new User() { UserName="burnish", Password="burnish",
													 ImageSourcePath = Path.Combine( userImagesPath, "DemoUser1.png") },
								 };
            return userList;
        }
    }
}
