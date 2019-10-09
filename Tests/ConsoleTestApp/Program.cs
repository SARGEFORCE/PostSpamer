using Microsoft.VisualBasic.FileIO;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Concurrent;

namespace ConsoleTestApp
{
    #region Написать приложение, считающее в раздельных потоках факториал числа N, которое вводится с клавиатуры;

    //class Program
    //{
    //    static int[] part_1;
    //    static int[] part_2;
    //    static ulong[] result;
    //    static void Thread1()
    //    {
    //        ulong temp = 1;
    //        for (int i = 0; i < part_1.Length; i++)
    //        {
    //            temp = temp * Convert.ToUInt64(part_1[i]);
    //        }
    //        result[0] = Convert.ToUInt64((temp == 0) ? 1 : temp);
    //    }
    //    static void Thread2()
    //    {
    //        ulong temp = 1;
    //        for (int i = 0; i < part_2.Length; i++)
    //        {
    //            temp = temp * Convert.ToUInt64(part_2[i]);
    //        }
    //        result[1] = Convert.ToUInt64((temp == 0) ? 1 : temp);
    //    }
    //    static void Main(string[] args)
    //    {
    //        result = new ulong[2];
    //        ulong finally_result = 1;

    //        Console.WriteLine("Введите число, факториал которого нужно посчитать");
    //        int num = Convert.ToInt32(Console.ReadLine());
    //        int part1_length = num / 2; //количество цифр первой части
    //        int part2_length = num - part1_length; //количество цифр второй части
    //        part_1 = new int[part1_length];
    //        part_2 = new int[part2_length];
    //        //заполняем массивы соотвествующих длин соотвествующими числами
    //        for (int i = 1; i <= part1_length; i++) { part_1[i - 1] = i; }
    //        for (int i = 1; i <= part2_length; i++) { part_2[i - 1] = i + (part1_length); }

    //        //параметры потоков
    //        Thread thrd_1 = new Thread(new ThreadStart(Thread1));
    //        Thread thrd_2 = new Thread(new ThreadStart(Thread2));

    //        thrd_1.Start();
    //        thrd_2.Start();
    //        Console.WriteLine("Подумаем о вечности...");
    //        //Ждём вычисления                         //пауза чтобы не грузить проц вечной проверкой условия
    //        while (thrd_1.IsAlive || thrd_2.IsAlive) { Thread.Sleep(500); }

    //        //вычисляем конечный результат в основном потоке
    //        for (int i = 0; i < result.Length; i++) { finally_result *= result[i]; }

    //        Console.WriteLine($"Осенило! Результат вычисления - {finally_result}");
    //        //else Console.WriteLine("Не, ну это как-то слишком! Я так не умею. Выход за границы ulong'а. Введите число поменьше.");
    //        Console.ReadKey();
    //    }


    //    //void CSVfile(string path = @"c:\temp\test.csv")
    //    //{
    //    //    using (TextFieldParser parser = new TextFieldParser(path))
    //    //    {
    //    //        parser.TextFieldType = FieldType.Delimited;
    //    //        parser.SetDelimiters(",");
    //    //        List<string> fields = new List<string>();
    //    //        for (int i = 0; !parser.EndOfData; i = i + 2)
    //    //        {
    //    //            //Process row
    //    //            fields.Add(parser.ReadLine());
    //    //            foreach (string field in fields)
    //    //            {
    //    //                //TODO: Process field
    //    //            }
    //    //        }
    //    //    }
    //    //}
    //}
    #endregion

    #region Написать приложение, считающее в раздельных потоках сумму целых чисел до N, которое вводится с клавиатуры.

    //class Program
    //{
    //    static int[] part_1;
    //    static int[] part_2;
    //    static ulong[] result;
    //    static void Thread1()
    //    {
    //        ulong temp = 1;
    //        for (int i = 0; i < part_1.Length; i++)
    //        {
    //            temp = temp + Convert.ToUInt64(part_1[i]);
    //        }
    //        result[0] = Convert.ToUInt64((temp == 0) ? 1 : temp);
    //    }
    //    static void Thread2()
    //    {
    //        ulong temp = 1;
    //        for (int i = 0; i < part_2.Length; i++)
    //        {
    //            temp = temp + Convert.ToUInt64(part_2[i]);
    //        }
    //        result[1] = Convert.ToUInt64((temp == 0) ? 1 : temp);
    //    }
    //    static void Main(string[] args)
    //    {
    //        result = new ulong[2];
    //        ulong finally_result = 1;

    //        Console.WriteLine("Введите число N");
    //        int num = Convert.ToInt32(Console.ReadLine());
    //        int part1_length = num / 2; //количество цифр первой части
    //        int part2_length = num - part1_length; //количество цифр второй части
    //        part_1 = new int[part1_length];
    //        part_2 = new int[part2_length];
    //        //заполняем массивы соотвествующих длин соотвествующими числами
    //        for (int i = 1; i <= part1_length; i++) { part_1[i - 1] = i; }
    //        for (int i = 1; i <= part2_length; i++) { part_2[i - 1] = i + (part1_length); }

    //        //параметры потоков
    //        Thread thrd_1 = new Thread(new ThreadStart(Thread1));
    //        Thread thrd_2 = new Thread(new ThreadStart(Thread2));

    //        thrd_1.Start();
    //        thrd_2.Start();

    //        //Ждём вычисления                         //пауза чтобы не грузить проц вечной проверкой условия
    //        while (thrd_1.IsAlive || thrd_2.IsAlive) { Thread.Sleep(500); }

    //        //вычисляем конечный результат в основном потоке
    //        for (int i = 0; i < result.Length; i++) { finally_result += result[i]; }

    //        Console.WriteLine($"Сумма чисел от 1 до N - {finally_result}");
    //        //else Console.WriteLine("Не, ну это как-то слишком! Я так не умею. Выход за границы ulong'а. Введите число поменьше.");
    //        Console.ReadKey();
    //    }
    //}

    #endregion

    #region CSV в потоке
    //class Program
    //{
    //    static ConcurrentQueue<string[]> fields = new ConcurrentQueue<string[]>();
    //    static void Main(string[] args)
    //    {
    //        Thread ThreadParse = new Thread(new ThreadStart(CsvFileParser));
    //        Thread ThreadWrite = new Thread(new ThreadStart(CsvToTxt));

    //        ThreadParse.Start(); Console.WriteLine("Поток 1 стартовал\n\n");
    //        while (ThreadParse.IsAlive){ Thread.Sleep (100); }
    //        ThreadWrite.Start(); Console.WriteLine("Поток 2 стартовал\n\n");

    //        Console.WriteLine("Все потоки завершились с кодом 0, проверьте файл txt, до свидания!\n\n");
    //        Console.ReadKey();
    //    }

    //    static void CsvFileParser()
    //    {
    //        string path = @"Test.csv";
    //        using (TextFieldParser parser = new TextFieldParser(path))
    //        {
    //            parser.TextFieldType = FieldType.Delimited;
    //            parser.SetDelimiters(";", ",");                
    //            while (!parser.EndOfData)
    //            {
    //                fields.Enqueue(parser.ReadFields());
    //            }                
    //        }
    //    }

    //    static void CsvToTxt()
    //    {
    //        string path = @"Test.txt";
    //        using (StreamWriter SW = new StreamWriter(path))
    //        {
    //            Console.OutputEncoding = Encoding.UTF8;
    //            foreach (string[] lines in fields)
    //            {
    //                foreach (string field in lines)
    //                {
    //                    SW.Write($"{field}\t ");
    //                    Console.Write($"{field}\t ");
    //                }
    //                SW.WriteLine();
    //                Console.WriteLine();
    //            }
    //        }
    //    }
    //}
    #endregion
    class Program
    {
        static Random rand = new Random();

        static int[,,] matrix_1, matrix_2, matrix_3;
        static DateTime time;

        static int N = 200; //размерность матриц

        static void Main(string[] args)
        {
            matrix_1 = new int[N, N, N];
            matrix_2 = new int[N, N, N];
            matrix_3 = new int[N, N, N];

            time = DateTime.Now;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int o = 0; o < N; o++)
                    {
                        matrix_1[i, j, o] = rand.Next(0, 9);
                        matrix_2[i, j, o] = rand.Next(0, 9);
                    }
                }
            }

            Parallel.For(0, N, (i, state) =>
            {
                Parallel.For(0, N, (j, state_b) =>
                {
                    for (int o = 0; o < N; o++)
                    {
                        matrix_3[i, j, o] = matrix_1[i, j, o] * matrix_2[i, j, o];
                    }
                });
            });

            Console.WriteLine("Посчитано за {0} milliseconds",(DateTime.Now - time).TotalMilliseconds);

            //for (int i = 0; i < 100; i++)
            //{
            //    for (int j = 0; j < 100; j++)
            //    {
            //        Console.Write(matrix_2[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
