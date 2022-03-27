using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectionPersonForShop.DAL.Entityes
{
    /// <summary>
    /// Базовый класс сущности
    /// </summary>
    public class BaseEntityes
    {
        /// <summary>
        /// Уникальный интидификатор сущности
        /// </summary>
        [Required]
        public virtual int Id { get; set; }
    }
}
