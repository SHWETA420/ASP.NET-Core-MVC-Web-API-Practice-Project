﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IClass
{
    public interface IUsersService
    {
        Task<Response> AddUsersAsync(User user);
    }
}
