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
            int w = 0;
            do
            {
                Console.WriteLine("Щоб запустити виконання варiанту 1 (виконавець студент Весельський), введiть 1 \nЩоб запустити виконання варiанту 3 (виконавець студент Ббб), введiть 2 \nЩоб запустити виконання варiанту 12 (виконавець студент Ввв), введiть >= 3 \nДля виходу, введiть 0. ");
                w = Convert.ToInt32(Console.ReadLine());
                if (w == 1) Variant1(studs);
                /*else if (w == 3)
                else*/
            }
            while (w != 0);
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}
