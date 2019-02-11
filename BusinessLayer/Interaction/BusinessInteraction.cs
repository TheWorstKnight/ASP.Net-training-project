using BusinessLayer.Abstract;
using BusinessLayer.Model;
using DataLayer.Abstract;
using DataLayer.Model;
using System.Linq;

namespace BusinessLayer.Interaction
{
    public class BusinessInteraction : IBusinessInteraction
    {
        private IDLEntry _dataLayer;
        public BusinessInteraction(IDLEntry dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public bool Register(RegisterModel model)
        {
            var users = _dataLayer.DataInteraction.GetUsers();
            var user = users?.FirstOrDefault(u => u.Email == model.Name);
            if (user == null)
            {
                if (_dataLayer.DataInteraction.AddUser(new User { Email = model.Name, Password = model.Password, Age = model.Age }))
                    return true;
                else return false;
            }
            else return false;
        }
    }
}
