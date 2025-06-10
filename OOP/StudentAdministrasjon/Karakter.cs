using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjon
{
    public class Karakter
    {
        private Student _student;
        private Fag _fag;
        private string _karakterverdi;

        public string StudentNavn
        {
            get { return _student.HentNavn(); }
        }

        public Karakter(Student student, Fag fag, string karakterverdi)
        {
            _student = student;
            _fag = fag;
            _karakterverdi = karakterverdi;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {_student.HentNavn()}, Fag: {_fag.HentNavn()}, Karakter: {_karakterverdi}");
        }
    }

   
}
