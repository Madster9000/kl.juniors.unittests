using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KL.Juniors.UnitTests.Workflows
{
    public class DatabaseUserStorage: IUsersStorage
    {
        public List<User> Users { get;}

        public DatabaseUserStorage()
        {
            Users = new List<User>
            {
                new User
                {
                    Id = Guid.Empty,
                    Name = "Denis123456"
                }
            };
        }
    }

    public interface IUsersStorage
    {
        List<User> Users { get;}
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
