using DataLayer.Abstract;
using DataLayer.DataContextStorage;
using DataLayer.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Interaction
{
    public class DataInteraction : IDataInteraction
    {
        public bool AddUser(User user)
        {
            if (user != null)
            {
                using (DataContext db = new DataContext())
                {
                    db.Users.Add(new User { Email = user.Email, Password = user.Password, Age = user.Age });
                    db.SaveChanges();
                    return true;
                }
            }
            else return false;
        }

        public IEnumerable<User> GetUsers()
        {
            using (DataContext db = new DataContext())
            {
                //Users users = new Users();
                //foreach (var i in db.Users)
                //{
                //    users.Accounts.Add(new User { Email = i.Email, Password = i.Password, Age = i.Age });
                //}
                //return users.Accounts;
                bool any = db.Users.Any();
                return db.Users.Any()?db.Users.ToList():null;
            }
        }
    }
}
