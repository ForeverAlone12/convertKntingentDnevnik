using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class AIS_Kontingent
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        String surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        String name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        String nname { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        String sex { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        DateTime birthday { get; set; }

        /// <summary>
        /// Класс
        /// </summary>
        String clas { get; set; }

        /// <summary>
        /// № личного дела
        /// </summary>
        String numb { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        String typeDocument { get; set; }

        /// <summary>
        /// Серия документа
        /// </summary>
        String seriaDocument { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        String numbDocument { get; set; }

        /// <summary>
        /// СНИЛС
        /// </summary>
        String snils { get; set; }

        /// <summary>
        /// Адрес регистрации
        /// </summary>
        String address { get; set; }
    }
}
