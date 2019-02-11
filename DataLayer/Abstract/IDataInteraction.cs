using DataLayer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IDataInteraction
    {
        IEnumerable<User> GetUsers();
        bool AddUser(User user);
    }
}
