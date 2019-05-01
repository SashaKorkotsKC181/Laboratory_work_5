using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLabStudent
{
    partial class Program
    {
        static void Variant3(Student[] studs)
        {
            StreamWriter strwr = new StreamWriter("kaitur.txt");
            int sum = 0;
            int number = 0;
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].scholarship != 0)
                {
                    sum += studs[i].scholarship;
                    number++;
                }
            }
            int arithmeticMean = sum / number;
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].scholarship != 0)
                {
                    if (arithmeticMean - studs[i].scholarship >= arithmeticMean / 5)
                        strwr.Write(studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic + " ");
                    strwr.WriteLine();
                }
            }
            strwr.Close();
        }
    }
}
