using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StructLabStudent
{
    partial class Program
    {
	    static void Variant1(Student[] studs)
		{
			StreamWriter strwr = new StreamWriter("output.txt");
			for (int i = 0; i < studs.Length; i++)
			{
			    string[] str = studs[i].dateOfBirth.Split('.');
			    DateTime f = new DateTime(Convert.ToInt32(str[2]), Convert.ToInt32(str[1]), Convert.ToInt32(str[0]), 0, 0, 0);
                if (studs[i].sex == 'M' && DateTime.Now >= f.AddYears(18))
                {
                    strwr.Write(studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic + " ");
                    strwr.WriteLine();
                }
			}
            strwr.Close();
		}
    }
}
