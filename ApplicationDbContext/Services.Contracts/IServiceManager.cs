﻿using Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Contracts
{
    public interface IServiceManager
    {
        IAuthenticationService AuthenticationService { get; }
    }
}