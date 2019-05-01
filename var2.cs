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
			StreamWriter strwr = new StreamWriter("DeusMios.txt");
			for(int i = 0; i < studs.Length; i++)
			{
				if(studs[i].physicsMark == '5')
				{
					strwr.Write(studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic + " " + ((studs[i].mathematicsMark + studs[i].physicsMark + studs[i].informaticsMark) / 3) + " " + studs[i].scholarship);
					Console.WriteLine();
				}
			}
			strwr.Close();
		}
	}
}
