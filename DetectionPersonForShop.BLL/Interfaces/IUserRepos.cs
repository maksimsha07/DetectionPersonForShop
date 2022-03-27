﻿using DetectionPersonForShop.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectionPersonForShop.BLL.Interfaces
{
    /// <summary>
    /// Интерфейс для методов обращения с таблицей пользователя
    /// </summary>
    public interface IUserRepos
    {
        /// <summary>
        /// Получить списов всех пользователей
        /// </summary>
        /// <returns>IEnumerable<User></returns>
        IEnumerable<User> GetAllUsers();
        /// <summary>
        /// Получить пользователя по id
        /// </summary>
        /// <param name="id">Индитификатор пользователя</param>
        /// <returns>User</returns>
        User GetUserById(int id);
        /// <summary>
        /// Сохранить пользователя в БД
        /// </summary>
        /// <param name="user">Объект пользователя</param>
        void SaveUsers(User user);
        /// <summary>
        /// Удалить пользователя
        /// </summary>
        /// <param name="user">User</param>
        void DeleteUser(User user);
    }
}
