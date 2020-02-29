using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    /// <summary>
    /// Данные для Дневник.ру
    /// </summary>
    class Dnevnik
    {
        /// <summary>
        /// Ф.И.О.
        /// </summary>
        String fio { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        String sex { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        String birthday { get; set; }

        /// <summary>
        /// Дата поступления в ОО
        /// </summary>
        DateTime dateSchool { get; set; }

        /// <summary>
        /// Дата поступления в класс
        /// </summary>
        DateTime dateClass { get; set; }

        /// <summary>
        /// СНИЛС
        /// </summary>
        String snils { get; set; }

        /// <summary>
        /// Свидетельство о рождении
        /// </summary>
        Birth_Certification birthCertification { get; set; }

        /// <summary>
        /// Паспортные данные
        /// </summary>
        Passport passport { get; set; }

        public Dnevnik()
        {

        }
    }
}
