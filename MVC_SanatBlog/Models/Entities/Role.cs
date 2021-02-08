﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_SanatBlog.Models.Entities
{
    public class Role
    {
        public class Role
        {
            public int RoleId { get; set; }
            public string RoleName { get; set; }

            public virtual List<AppUserAndRole> AppUserAndRoles { get; set; }
        }
    }
}