﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IClass
{
    public interface IUsersRepository
    {
        Task<int> AddUsersAsync(Users user);
    }
}
