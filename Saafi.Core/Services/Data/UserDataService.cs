using System.Threading.Tasks;
using Saafi.Core.Contracts.Repository;
using Saafi.Core.Contracts.Services;
using Saafi.Core.Model;

namespace Saafi.Core.Services.Data
{
    public class UserDataService : IUserDataService
    {
        private readonly IUserRepository _userRepository;
        private User _activeUser;
        public UserDataService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> SearchUser(string userName)
        {
            return await _userRepository.SearchUser(userName);
        }

        public async Task<User> Login(string userName, string password)
        {
            _activeUser = await _userRepository.Login(userName, password);
            return _activeUser;
        }

        public User GetActiveUser()
        {
            return _activeUser;
        }
    }
}