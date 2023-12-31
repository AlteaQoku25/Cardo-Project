﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class UserNotFoundException : NotFoundException
    {
        public string CultureId { get; }
        public UserNotFoundException( string cultureId) : base(null) {
        CultureId = cultureId;
        }
    }
}
