using System;



using System.Collections.Generic;



using System.Linq;



using System.Text;



using System.Threading.Tasks;



namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2,
               result;
            bool a = true;







            char option;







            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");







            while (a == true)
            {
                Console.Write("Enter the Operation you want to perform : ");
                option = Convert.ToChar(Console.ReadLine());







                try
                {
                    switch (option)
                    {







                        case '1':
                            int i, n, sum = 0;
                            int[] b = new int[100];
                            Console.Write("--------------------------------------\n");







                            Console.Write("How many no of elements you want to add :");
                            n = Convert.ToInt32(Console.ReadLine());







                            for (i = 0; i < n; i++)
                            {
                                Console.Write("Enter the no - {0} : ", i);
                                b[i] = Convert.ToInt32(Console.ReadLine());
                            }







                            for (i = 0; i < n; i++)
                            {
                                sum += b[i];
                            }







                            Console.Write("Addition of the numbers : {0}\n\n", sum);
                            break;







                        case '2':







                            int f = 0;
                            int[] c = new int[100];



                            Console.Write("--------------------------------------\n");







                            Console.Write("How many no of elements you want to sub :");
                            n = Convert.ToInt32(Console.ReadLine());
                            for (i = 0; i < n; i++)
                            {
                                Console.Write("Enter the no {0} : ", i);
                                c[i] = Convert.ToInt32(Console.ReadLine());
                            }







                            for (i = 0; i < n; i++)
                            {
                                f = -c[i];
                                // result = sum;
                            }







                            Console.Write("Subraction of the numbers : {0}\n\n", f);







                            break;





















                        case '3':
                            int j = 0;
                            int pro = 1;
                            int[] k = new int[100];







                            Console.Write("--------------------------------------\n");







                            Console.Write("How many no of elements you want to Mul :");
                            n = Convert.ToInt32(Console.ReadLine());







                            for (i = 0; i < n; i++)
                            {
                                Console.Write("Enter the no {0} : ", i);
                                k[i] = Convert.ToInt32(Console.ReadLine());
                            }







                            for (i = 0; i < n; i++)
                            {
                                j = k[i];
                                pro = pro * j;
                                // result = sum;
                            }







                            Console.Write("Multiplication of the numbers : {0}\n\n", pro);







                            break;







                        case '4':







                            Console.Write("Enter the First Number : ");
                            Num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the Second Number : ");
                            Num2 = Convert.ToInt32(Console.ReadLine());
                            if (Num2 == 0)
                            {
                                Console.WriteLine("Denominiator should not be zero  ");
                            }
                            else
                            {
                                result = Num1 / Num2;







                                Console.WriteLine("The result of Division is : {0}", result);
                            }
                            break;







                        case '5':
                            a = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Don't enter alphabets So,please enter number", ex);
                }
            }
        }







    }







}