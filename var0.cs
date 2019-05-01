using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StructLabStudent
{
    partial class Program
    {
        static void Variant0(Student[] studs)
        {
            StreamWriter strwr = new StreamWriter("output0.txt");
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].sex == 'F' && studs[i].informaticsMark == '5')
                {
                    strwr.Write(studs[i].surName);
                    strwr.WriteLine();
                }
            }
            strwr.Close();
        }
    }
}
