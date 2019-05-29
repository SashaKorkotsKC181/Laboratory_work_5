using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StructLabStudent
{
	partial class Program
	{
		static void Variant2(Student[] studs)
		{
			int n = 0;
			StreamWriter strwr = new StreamWriter("DeusMios.txt");
			for(int i = 0; i < studs.Length; i++)
			{
				string[] str = studs[i].dateOfBirth.Split('.');
				DateTime f = new DateTime(Convert.ToInt32(str[2]), Convert.ToInt32(str[1]), Convert.ToInt32(str[0]), 0, 0, 0);
				if (DateTime.Now < f.AddYears(16))
				{
					n++;
					strwr.Write(studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic + " " + studs[i].sex + " " + studs[i].dateOfBirth
					 + " " + studs[i].mathematicsMark + " " + studs[i].physicsMark + " " + studs[i].informaticsMark + " " + studs[i].scholarship);
					strwr.WriteLine();
					Console.WriteLine(studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic + " " + studs[i].sex + " " + studs[i].dateOfBirth
					 + " " + studs[i].mathematicsMark + " " + studs[i].physicsMark + " " + studs[i].informaticsMark + " " + studs[i].scholarship);
				}
			}
			Console.WriteLine("Кiлькiсть студентiв молодших 16: {0}", n);
			strwr.Close();
		}
	}
}
