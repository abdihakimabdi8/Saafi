﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Saafi.Core.Contracts.Repository;
using Saafi.Core.Model;

namespace Saafi.Core.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {

        private static readonly List<User> AllKnownUsers = new List<User>
        {
            new User { UserName = "colaadmaygaag", Password="123456", UserId = 1}, //extremely secure, don't try this at home
            new User { UserName = "gaaxnuug", Password="789456", UserId = 2},
            new User { UserName = "shaqaalihiiuguhoreeyay", Password="100000", UserId = 3}
        };

        public async Task<User> SearchUser(string userName)
        {
            return await Task.FromResult(AllKnownUsers.FirstOrDefault(u => u.UserName == userName));
        }

        public async Task<User> Login(string userName, string password)
        {
            return await Task.FromResult(AllKnownUsers.FirstOrDefault(u => u.UserName == userName && u.Password == password));
        }
    }
}
