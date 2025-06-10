using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjon
{
    public class Student
    {
        private string _name;
        private int _alder;
        private string _studieprogram;
        private string _studentID;
        private string _studentName;
        private string _fag;
        private string _karakterverdi;

        public Student(string name, int alder, string studieprogram, string studentID, string fag, string karakterverdi)
        {
            _name = name;
            _alder = alder;
            _studieprogram = studieprogram;
            _studentID = studentID;
            _fag = fag;
            _karakterverdi = karakterverdi;
        }

        public string HentNavn()
        {
            return _name;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {_name}, Alder: {_alder}, Studieprogram: {_studieprogram}, StudentID: {_studentID}");
            Console.WriteLine($"Student: {_name}, Fag: {_fag}, Karakter: {_karakterverdi}");

        }
    }
}
