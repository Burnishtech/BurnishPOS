using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSDataManager.Entity
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EMailAddress { get; set; }
        public string ImageSourcePath { get; set; }
    }
}
