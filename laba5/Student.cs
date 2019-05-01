using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLabStudent
{
    struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            string[] k = new string[9];
            int x = 0;
            string z = "";
            int i = 0;
            while (x < 9)
            {
                if (lineWithAllData[i] != ' ') z += lineWithAllData[i];
                if (i == lineWithAllData.Length - 1) { k[x] = z; x++; z = ""; break; }
                else if (lineWithAllData[i] == ' ' && (i == lineWithAllData.Length - 1 || lineWithAllData[i + 1] != ' ')) { k[x] = z; x++; z = ""; }
                i++;
            }
            surName = k[0];
            firstName = k[1];
            patronymic = k[2];
            sex = Convert.ToChar(k[3]);
            dateOfBirth = k[4];
            mathematicsMark = Convert.ToChar(k[5]);
            physicsMark = Convert.ToChar(k[6]);
            informaticsMark = Convert.ToChar(k[7]);
            scholarship = Convert.ToInt32(k[8]); ;
        }
    }
}


