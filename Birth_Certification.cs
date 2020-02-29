using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    /// <summary>
    /// Свидетельство о рождении
    /// </summary>
    class Birth_Certification
    {
        /// <summary>
        /// Серия
        /// </summary>
        String seria { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        String numb { get; set; }

        public Birth_Certification()
        {

        }

        public Birth_Certification(String seria, String numb)
        {
            this.seria = seria;
            this.numb = numb;
        }

    }
}
