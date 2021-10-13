using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace IndividVar6Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла: ");
            string path = Console.ReadLine();
            try
            {
                StreamReader sr = new StreamReader(path);
                Queue<string> q = new Queue<string>();
                string str;
                try
                {
                    Console.WriteLine("Исходная коллекция");
                    foreach (string s in File.ReadAllLines(path))
                    {
                        q.Enqueue(sr.ReadLine());
                        Console.WriteLine(s);
                    }
                    sr.Close();
                    if (q.Count == 0)
                    {
                        Console.WriteLine("Файл пустой!");
                    }
                    else
                    {
                        str = q.Peek();
                        string[] num = str.Split(' ');
                        q.Clear();
                        for (int i = 0; i < num.Length; i++)
                        {
                            if (int.Parse(num[i]) >= 0)
                            {
                                q.Enqueue(num[i] + " ");
                            }
                        }
                        for (int i = 0; i < num.Length; i++)
                        {
                            if (int.Parse(num[i]) < 0)
                            {
                                q.Enqueue(num[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Отсортированная коллекция");
                        foreach (string s in q)
                        {
                            Console.Write(s);
                        }
                        Console.ReadLine();
                    }
                }
                catch { Console.WriteLine("Содержимое файла имеет неправильный формат!"); }
            }
            catch { Console.WriteLine("Имя файла введено неправильно или такого файла нет!"); }
        }
    }
}
