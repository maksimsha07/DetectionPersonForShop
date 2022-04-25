using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectionPersonForShop.DAL.Entityes
{
    /// <summary>
    /// Класс сущности пользователя
    /// </summary>
    public class User : BaseEntityes
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль позователя
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Почта пользователя
        /// </summary>
        public string Email { get; set; }
    }
}
