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
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Логин содержит символы 3 до 20")]
        public string Login { get; set; }
        /// <summary>
        /// Пароль позователя
        /// </summary>
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Пароль должен содержать больше 8 символов")]
        public string Password { get; set; }

        /// <summary>
        /// Почта пользователя
        /// </summary>
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
    }
}
