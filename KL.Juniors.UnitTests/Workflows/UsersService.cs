using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KL.Juniors.UnitTests.Workflows
{
    public class UsersService
    {
        private readonly IUsersStorage _storage;
        public UsersService(IUsersStorage storage)
        {
            _storage = storage;
        }
        public string GetUser(Guid userId)
        {
            return _storage.Users.FirstOrDefault(x => x.Id == userId)?.Name;
        }
    }
}
