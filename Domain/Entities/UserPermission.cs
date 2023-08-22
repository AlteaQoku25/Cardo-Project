﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserPermission
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
    }
}
