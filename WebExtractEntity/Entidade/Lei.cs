using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebExtractSelenium.Entidade
{

    /// <summary>
    /// Classe Lei, será armazenado o título da Lei, o Texto e sua Data.
    /// </summary>
    public class Lei
    {
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public string Texto { get; set; }
    }
}
