using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            // task3();
            // task4();
            // task5();
            // task6();
            // task7();
            // task8();
            //task9();
            //  task10();
            //  task11();
            //  task12();
            // task13();
            // task14();
             task15();
            // task16();
            //task17();
        }
        public static void task1()
        {
            Console.Write("Hello World!!!");
            Console.Write("Hello World!!!");
            Console.ReadKey();
        }
        public static void task2()
        {
            Console.WriteLine("Hello World!!!");
            Console.Write("Hello World!!!");
            Console.ReadKey();
        }
        public static void task3()
        {
            int number = 7;
            Console.WriteLine("Value is " + number);
            Console.ReadKey();
        }
        public static void task4()
        {
            string line = "I am a string";
            Console.WriteLine("String is:  " + line);
            Console.ReadKey();
        }
        public static void task5()
        {
            char word = 'A';
            Console.WriteLine("Character is : " + word);
            Console.ReadKey();
        }
        public static void task6()
        {
            float number = 4.3F;
            Console.WriteLine("Float number is : " + number);
            Console.ReadKey();
        }
        public static void task7()
        {
            string line;
            Console.Write("Enter any line: ");
            line = Console.ReadLine();
            Console.WriteLine("You have entered: " + line);
            Console.ReadKey();
        }
        public static void task8()
        {
            int number;
            Console.Write("Enter any number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("You have entered: " + number);
            Console.ReadKey();
        }
        public static void task9()
        {
            float number;
            Console.Write("Enter any number: ");
            number = float.Parse(Console.ReadLine());
            Console.WriteLine("You have entered: " + number);
            Console.ReadKey();

        }
        public static void task10()
        {
            float length;
            float area;
            Console.Write("Enter length: ");
            length = float.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("Area is : " + area);
            Console.ReadKey();

        }
        public static void task11()
        {
            float marks;
            Console.Write("Enter your marks: ");
            marks = float.Parse(Console.ReadLine());
            if (marks > 50)
                Console.Write("You are passed");
            else
                Console.Write("Your are failed");
            Console.ReadKey();

        }
        public static void task12()
        {
            for (int x = 1; x <= 5; x++)
                Console.WriteLine("Welcome jack");
            Console.ReadKey();

        }
        public static void task13()
        {
            int num = 0;
            int sum = 0;
            while (num != -1)
            {
                sum = sum + num;
                Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.Write("Sum is : " + sum);
            Console.ReadKey();

        }
        public static void task14()
        {
            int num;
            int sum = 0;
            do
            {

                Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            } while (num != -1);
            sum++;
            Console.Write("Sum is : " + sum);
            Console.ReadKey();

        }
        public static void task15()
        {
            int[] number = new int[3];
            int largest = -1;
            for (int x = 0; x < 3; x++)
            {
                Console.Write("Enter the number: ");
                number[x] = int.Parse(Console.ReadLine());
            }
            for (int x = 0; x < 3; x++)
            {
                if (number[x] > largest)
                    largest = number[x];
            }
            Console.WriteLine("Largest is " + largest);
            Console.ReadKey();
        }
        public static void task16()
        {
            int num1, num2, sum;

            Console.Write("Enter the first Number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second Number: ");
            num2 = int.Parse(Console.ReadLine());
            sum = printsum(num1, num2);
            Console.WriteLine("Sum is " + sum);
            Console.ReadKey();

        }
        static int printsum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void task17()
        {
            string path = "E:\\file.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
