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

        public EFUserRepos(EFDBContext context)
        {
            this.context = context;
        }

        public bool CreateUser(User user)
        {
            User userl = context.Users.FirstOrDefault(x => x.Login == user.Login);
            if (userl != null) return false;
            context.Add(user);
            context.SaveChanges();
            return true;
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
            User user = context.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public void SaveUsers(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void UpdateUser(User NewUser, User OldUser)
        {
            throw new NotImplementedException();
        }
    }
}
