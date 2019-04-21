using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StructLabStudent
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        {
            int k = 0;
            string[] str = File.ReadAllLines(fileName);
            Student[] a = new Student[str.Length];
            foreach (string i in str)
            {
                a[k] = new Student(i);
                k++;
            }
            return a;
        }

        static void runMenu(Student[] studs)
        {
            Console.WriteLine("Щоб запустити виконання варіанту 1 (виконавець студент Ааа), введіть 1 \nЩоб запустити виконання варіанту 3 (виконавець студент Ббб), введіть 2 \nЩоб запустити виконання варіанту 12 (виконавець студент Ввв), введіть >= 3 \nДля виходу, введіть 0. ");
            int w = Convert.ToInt32(Console.ReadLine());
            /* if (w == 1) 
             else if (w == 3)
             else*/
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
            Console.ReadKey();
        }
    }
}
