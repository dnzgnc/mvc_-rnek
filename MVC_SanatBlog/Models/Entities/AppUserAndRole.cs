using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_SanatBlog.Models.Entities
{
    public class AppUserAndRole
    {
        public class AppUserAndRole
        {
            public int AppUserId { get; set; }
            public int RoleId { get; set; }

            public AppUser AppUser { get; set; }
            public Role Role { get; set; }
        }
    }
}