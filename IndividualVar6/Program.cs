using System;
using System.Collections;
using System.IO;

namespace IndividualVar6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack intStack = new Stack();
            Console.WriteLine("Введите название файла: ");
            string path = Console.ReadLine();
            try
            {
                StreamReader sr = new StreamReader(path);
                Console.WriteLine("Исходная коллекция: ");
                foreach(char symb in File.ReadAllText(path))
                {
                    char c = (char)sr.Read();
                    intStack.Push(c);
                    Console.Write(c);
                }
                sr.Close();
                if (intStack.Count == 0)
                {
                    Console.WriteLine("Файл пустой");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Отсортированная коллекция: ");
                    for (int i = intStack.Count; i > 0; i--)
                    {
                        Console.Write(intStack.Pop());
                    }
                    Console.ReadLine();
                }
            }
            catch { Console.WriteLine("Имя файла введено неправильно или такого файла нет!"); }
        }
    }
}
