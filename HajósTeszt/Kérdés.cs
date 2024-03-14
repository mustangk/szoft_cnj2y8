using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajósTeszt
{
    internal class Kérdés
    {
        public string KérdésSzöveg { get; set; } = String.Empty;
        public string Válasz1 { get; set; } = String.Empty;
        public string Válasz2 { get; set; } = String.Empty;
        public string Válasz3 { get; set; } = String.Empty;
        public string URL { get; set; } = String.Empty;
        public int HelyesVálasz { get; set; }
        public int HelyesVálaszokSzáma { get; set; }
    }
}
