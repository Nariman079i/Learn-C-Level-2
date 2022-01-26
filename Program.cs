using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarimanJobs
{
    internal class Program
    {
        static void Main(string[] args)
        {


            void Task1() //1
            {

                string outPut, outPut1;

                int day = Convert.ToInt32(Console.ReadLine());
                int mes = Convert.ToInt32(Console.ReadLine());
                int year = Convert.ToInt32(Console.ReadLine());

                outPut = string.Format("Сегодня: {0} {1} {2}\n", day, mes, year);
                outPut1 = string.Format("Завтра: {0} {1} {2}\n", day + 1, mes, year);

                //проверка на високосность года

                Console.Write(outPut + outPut1);
                if (year % 4 != 0)
                {
                    Console.WriteLine("\tГод не високосный!");
                }
                else if (year % 100 != 0)
                {
                    Console.WriteLine("\tГод не високосный!");
                }
                else if (year % 400 != 0)
                {
                    Console.WriteLine("\tГод не високосный!");
                }
                else
                {
                    Console.WriteLine("\tГод високосный");
                }


                Console.WriteLine("Введите день недели!");

                int numWeek = Convert.ToInt32(Console.ReadLine());



                if (numWeek <= 0)
                {
                    Console.WriteLine("Такого дня в неделе нет!");
                }
                else if (numWeek == (6 | 7))
                {
                    Console.WriteLine("Выходной день!");
                }
                else if (numWeek > 7)
                {
                    Console.WriteLine("Такого дня в неделе нет!");
                }
                else
                {
                    Console.WriteLine("Рабочий день!");
                }
                
            }
            void Task2()
            {
                int digitOne , digitTwo , digitTree ;
                digitOne = 1;
                digitTwo = 5;
                digitTree = 3;
                Console.Write(digitOne + digitTwo + digitTree);
            }
            void Task3()
            {
                string myPerson = "Ibragimov \nMacagaji";
                Console.Write(myPerson);
            }
            void Task4()
            {
                Console.WriteLine(4 >= 6);
            }
            void Task5()
            {
                Console.WriteLine("Ваш рост (см) ");
                int height = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Ваш вес (кг) ");
                int mass = Convert.ToInt32(Console.ReadLine());

                int outPut = height - 100;
                int mainOutput = mass - outPut;
                if (mainOutput > 0)
                {
                    Console.WriteLine("Вам необходимо похудеть на {0}", mainOutput);
                }
                else if (mainOutput < 0)
                {
                    Console.WriteLine("Вам необходимо набрать вес {0}", -mainOutput);
                }
                else
                {
                    Console.WriteLine("С вами всё хорошо");
                }

            }
            void Task6(){
                int sayTime = 5;
                int dayWeek = 7;

                if (dayWeek  == 7)
                {
                    float outPut = (sayTime * 3) * 0.15f;
                    Console.WriteLine(outPut);
                }
                else
                {
                    int outPut = sayTime * 3;
                    Console.WriteLine(outPut);
                }
            }
            void Task7(){
                int a, b;

                a = 6;
                b = 5;

                if ((a | b) % 2 == 0)
                {
                    Console.WriteLine(a * b);
                }
                else
                {
                    Console.WriteLine(a + b);
                }
            }
            void Task8(){
                int sec = 10;

                int min = sec / 60;
                int sec2 = sec % 60;

                Console.WriteLine("{0} = {1}m {2}s", sec, min, sec2);

            }
            void Task9(){
                int a, b, c;
                a = 1;
                b = 4;
                c = 2;
                int D = b*b - 4 * a * c;
                
                if (D > 0)
                {
                    Console.WriteLine("2 корня!");
                }
                else if (D < 0)
                {
                    Console.WriteLine("нет корняей!");
                }
                else
                {
                    Console.WriteLine("1 корeнь!");
                }
            }
            void Task10()
            {
                string one_num, two_num;

                one_num = Console.ReadLine();
                two_num = Console.ReadLine();

                string[] num = one_num.Split(new char[] {'/'});
                string[] num1 = two_num.Split(new char[] { '/' });

                int nod = 0;
            
                int num_1 =  Convert.ToInt32(num[0]);
                int num_2 = Convert.ToInt32(num[1]);
                int num_3 = Convert.ToInt32(num1[0]);
                int num_4 = Convert.ToInt32(num1[1]);

                if ((num_1 | num_2 | num_3 | num_4) == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    return;
                }
                else if (num_4 % num_2 == 0)
                {
                    nod += num_4;
                }
                else if (num_2 % num_4 == 0)
                {
                    nod += num_2;
                }
                double outPut = Convert.ToDouble((num_1 / num_2) * (num_3 / num_4));
                double outPut1 = Convert.ToDouble((num_1 / num_2) + (num_3 / num_4));
                Console.WriteLine();
            }
            void Task11()
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Число {0} чётное число!" , num);
                }
                else
                {

                    Console.WriteLine("Число {0} не чётное число!", num);

                }

            }
            void Task12()
            {
                int num = Convert.ToInt32(Console.ReadLine());

                int h = num / 60;

                int m = num % 60;

                Console.WriteLine("{0}ч {1}м", h , m);


            }
            void Task13()
            {
                int num = Convert.ToInt32(Console.ReadLine());

                int h = num / 1000;

                int m = num % 1000;

                Console.WriteLine("{0}км {1}м", h, m);


            }
            void Task14()
            {
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case (1 & 2 & 3):
                        Console.WriteLine("{0}км {1}м");
                        break;
                    case (4 & 5 & 6):
                        Console.WriteLine("{0}км {2}м");
                        break;
                    case (7 & 8 | 9):
                        Console.WriteLine("{0}км {3}м");
                        break;
                    case ( 10 | 11 | 12 ):
                        Console.WriteLine("{0}км {4}м");
                        break;

                    default:
                        Console.WriteLine("{0}км {1}м");
                        break;
                }
                
                
                
                Console.WriteLine("{0}км {1}м");


            }
            void Task15()
            {

                Console.WriteLine("Выберите ответ!\n1 - ответ\n2 - ответ\n3 - Ответ");
                int outPut = Convert.ToInt32(Console.ReadLine());
                if (outPut == 3)
                {
                    Console.Write("Ответ правильный!");

                }
                else
                {
                    Console.Write("Ответ не правильный!");
                }
                
            }
            void Task16()
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());

                if (x > y)
                {
                    Console.WriteLine("x");

                }
                else if (x < y)
                {
                    Console.WriteLine("y");
                }
                else
                {
                    Console.WriteLine("y == x");
                }

            }
            void Task17()
            {
                string one_num, two_num;

                one_num = Console.ReadLine();
                two_num = Console.ReadLine();

                string[] num = one_num.Split(new char[] { '/' });
                string[] num1 = two_num.Split(new char[] { '/' });

                
                int num_1 = Convert.ToInt32(num[0]);
                int num_2 = Convert.ToInt32(num[1]);
                int num_3 = Convert.ToInt32(num1[0]);
                int num_4 = Convert.ToInt32(num1[1]);

                if ((num_1 | num_2 | num_3 | num_4) == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    return;
                }
                else {
                    int outPut = (num_1 * num_3) / (num_2 * num_4);
                    Console.WriteLine(outPut);
                }
                
            }


            
            Console.ReadKey();

        }
    }
}
