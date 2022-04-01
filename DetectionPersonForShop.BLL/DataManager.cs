using DetectionPersonForShop.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectionPersonForShop.BLL
{
    public class DataManager
    {
        private IUserRepos  _userRepos;

        public DataManager(IUserRepos userRepos)
        {
            _userRepos = userRepos;
        }

        public IUserRepos Users { get { return _userRepos; } }
    }
}
