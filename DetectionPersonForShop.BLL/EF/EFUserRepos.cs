using DetectionPersonForShop.BLL.Interfaces;
using DetectionPersonForShop.DAL;
using DetectionPersonForShop.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectionPersonForShop.BLL.EF
{
    public class EFUserRepos : IUserRepos
    {
        private EFDBContext context;

        private EFUserRepos(EFDBContext context)
        {
            this.context = context;
        }


        public void DeleteUser(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveUsers(User user)
        {
            throw new NotImplementedException();
        }
    }
}
