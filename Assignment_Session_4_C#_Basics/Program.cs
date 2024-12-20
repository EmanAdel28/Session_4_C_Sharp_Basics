using System;

namespace Assignment_Session_4_C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //int Number;
            //bool Flag;


            //do
            //{
            //    Console.Write("Enter Number ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (!Flag || Number < 0);

            //Console.WriteLine($"Numbers Between 1 and {Number}");

            //for (int i = 1; i <= Number; i++)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region Q2
            //2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //int Number;
            //bool Flag;



            //do
            //{
            //    Console.Write("Enter Number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}while (!Flag || Number< 0 );

            //Console.WriteLine($"Multiplication table of {Number}");

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i * Number);

            //}

            #endregion

            #region Q3
            //3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //int Number;
            //bool Flag;

            //do
            //{
            //    Console.Write("Enter Number ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (!Flag || Number < 0);

            //Console.WriteLine($"Even Number Between 1 and {Number}");

            //for (int i = 1; i <= Number ; i++)
            //{
            //    if(i%2==0)
            //    Console.WriteLine(i);
            //}



            #endregion

            #region Q4
            //4- Write a program that takes two integers then prints the power.

            //int Number01;
            //int Number02;
            //bool Flag;
            //int Power = 1;


            //do
            //{
            //    Console.Write("Enter Number 1 ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number01);

            //    Console.Write("Enter Number 2 ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number02);

            //} while (!Flag || Number01 <0 || Number02<0);

            //Console.WriteLine($"{Number01} Power {Number02} : ");
            //for(int i = 1; i <= Number02; i++)
            //{
            //    Power *= Number01;


            //}
            //Console.WriteLine(Power);



            #endregion

            #region Q5
            //5- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();


            //string reversed = "";
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}

            //Console.WriteLine(reversed);

            #endregion

            #region Q6
            //6- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //int Number01;
            //int Number02;
            //bool Flag;



            //do
            //{
            //    Console.Write("Enter Number 1 ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number01);

            //    Console.Write("Enter Number 2 ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number02);

            //} while (!Flag || Number01 < 0 || Number02 < 0);

            //for (int i = Number01; i <= Number02; i++)
            //{
            //    if (i < 2)
            //        continue; // Skip numbers less than 2 as they are not prime

            //    bool isPrime = true;

            //    // Check if the current number is prime
            //    for (int k = 2; k <= Math.Sqrt(i); k++)
            //    {
            //        if (i % k == 0)
            //        {
            //            isPrime = false;
            //            break; // Exit the loop if a divisor is found
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            #endregion

            #region Q7
            //7- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

            bool Flag;
            int DecimalNumber;


            do
            {
                Console.Write("Enter DecimalNumber ");
                Flag = int.TryParse(Console.ReadLine(), out DecimalNumber);
            } while (!Flag || DecimalNumber < 0);

            string binaryResult = "";

            if (DecimalNumber == 0)
            {
                binaryResult = "0";
            }
            else
            {
                while (DecimalNumber > 0)
                {
                    int remainder = DecimalNumber % 2;
                    binaryResult = remainder + binaryResult; // Prepend the remainder to the result
                    DecimalNumber /= 2;
                }
            }

            Console.WriteLine($"Binary representation: {binaryResult}");

            #endregion


        }
    }
}
