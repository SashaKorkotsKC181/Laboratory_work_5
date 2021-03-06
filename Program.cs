﻿using System;
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
                Console.WriteLine(" Щоб запустити виконання варiанту 1 (виконавець студент Весельський О.С.), введiть 1 \n Щоб запустити виконання варiанту 2 (виконавець студент Куротченко В.В), введiть 2 \n Щоб запустити виконання варiанту 3 (виконавець студент Коркоць О.Г.), введiть 3 \n Щоб запустити виконання варiанту 12 (виконавець студент Кайданський А.А.), введiть 12 \n Для виходу, введiть 0.");
                w = Convert.ToInt32(Console.ReadLine());
				if (w == 3) Variant0(studs);
				else if (w == 1) Variant1(studs);
				else if (w == 2) Variant2(studs);
                else if (w == 12) Variant3(studs);
                //else
            }
            while (w != 0);
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("data.txt");
            runMenu(studs);
        }
    }
}
