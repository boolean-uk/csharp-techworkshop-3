using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IUserRepository
    {
        void Save(User user);
        void Edit(User user, bool editable);
    }

    // This is your database layer.
    // You will also send your credentials for connection towards a database.
    
    public class UserRepository : IUserRepository
    {
        public void Save(User user)
        {
            // Implementation to save user to the database
            Console.WriteLine($"Saving user: {user.Name}");
        }
        public void Edit(User user, bool editable)
        {
            // Implementation to save user to the database
            Console.WriteLine($"Saving user: {user.Name}");
        }
    }
}
