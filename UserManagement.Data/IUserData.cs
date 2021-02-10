﻿using System;
using System.Collections.Generic;
using UserManagement.Core;

namespace UserManagement.Data
{
    public interface IUserData
    {
        IEnumerable<User> GetAllUsers();

        User GetById(int id);
    }
}