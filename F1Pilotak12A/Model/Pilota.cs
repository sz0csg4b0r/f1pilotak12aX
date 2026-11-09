using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Pilotak12A.Model
{
    internal class Pilota
    {
        private string _nev;
        private string _szuldatum;
        private string _nezmetiseg;
        private string _rajtszam;

        public Pilota()
        {
        }

        public Pilota(string nev, string szuldatum, string nezmetiseg, string rajtszam)
        {
            Nev = nev;
            Szuldatum = szuldatum;
            Nezmetiseg = nezmetiseg;
            Rajtszam = rajtszam;
        }

        public string Nev
        {
            get => _nev;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("A név nem lehet üres!!!");
                _nev = value;
            }
        }
        public string Szuldatum { get => _szuldatum; set => _szuldatum = value; }
        public string Nezmetiseg { get => _nezmetiseg; set => _nezmetiseg = value; }
        public string Rajtszam { get => _rajtszam; set
            {
                if (string.IsNullOrWhiteSpace(value) || value == "")
                    _rajtszam = "999";
            }
        }

        public override string ToString()
        {
            return $"A pilota adatai: {Nev}-{Szuldatum} (nemzetiség: {Nezmetiseg}, rajtszám: {Rajtszam})";
        }





    }
}
