﻿using SehirRehberi.API.Models;
using System.Threading.Tasks;

namespace SehirRehberi.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register (User user,string password);
        Task<User> Login(string userName,string password);
        Task<bool> UserExists(string userName);
    }
}
