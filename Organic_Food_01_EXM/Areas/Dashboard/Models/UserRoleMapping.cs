﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organic_Food_01_EXM.Areas.Admin.Models
{
    public class UserRoleMapping
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
    }
}
