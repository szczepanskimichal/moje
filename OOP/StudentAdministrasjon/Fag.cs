using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjon
{
    public class Fag
    {
        private string _navn;
        private string _fagkode;
        private string _fagnavn;
        private int _studiepoeng;

        public Fag(string fagkode, string fagnavn, int studiepoeng, string navn)
        {
            _fagkode = fagkode;
            _fagnavn = fagnavn;
            _studiepoeng = studiepoeng;
            _navn = _navn;
        }


        public string HentNavn()
        {
            return _navn;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fagkode: {_fagkode}, Fagnavn: {_fagnavn}, Studiepoen: {_studiepoeng}");
        }

        public string Fagkode { get { return _fagkode; } }
        public string Fagnavn { get { return _fagnavn; } }
        public int Studiepoeng { get {
                return _studiepoeng; } }

    }
}
