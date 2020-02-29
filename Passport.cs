using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    /// <summary>
    /// Паспорт
    /// </summary>
    class Passport
    {
        /// <summary>
        /// Серия
        /// </summary>
        String seria { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        String numb { get; set; }

        public Passport()
        {

        }

        public Passport(String seria, String numb)
        {
            this.seria = seria;
            this.numb = numb;
        }
    }
}
