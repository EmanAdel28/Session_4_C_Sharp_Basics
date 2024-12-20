using System.Text;

namespace Demo_Session4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loop Statements
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for(int i = 1 ; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region For - Foreach
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{

            //    //if (Numbers[i] == 5)
            //    //{
            //    //    break;
            //    //}

            //    if (Numbers[i] == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(Numbers[i]);
            //}


            // Class impliement interface IEnummrable

            //foreach (int Number in Numbers)
            //{
            //    Console.WriteLine(Number);
            //}
            #endregion

            #region While - Do While
            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);

            //} while (Number % 2 == 1 || Flag);

            //Console.WriteLine($"{Number} is Even");

            //int Number = 3;
            //bool Flag = false;
            //while (Number % 2 == 1 || Flag)
            //{
            //    Console.WriteLine("Enter Even Number ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}
            //Console.WriteLine($"{Number} is Even");
            #endregion

            #region String
            // Class => Reference Type
            // immutable Data Type [Vlue can not be Changed]
            // Array Of Chars
            // A H M E D

            //string Name;
            //Name = new string("Ahmed");

            //Name = "Ahmed";

            //string Name01 = "Ahmed";
            //string Name02 = "Ali";

            //Console.WriteLine(Name01);
            //Console.WriteLine(Name01.GetHashCode());

            //Console.WriteLine(Name02);
            //Console.WriteLine(Name02.GetHashCode());

            //Name02 = Name01;
            //Console.WriteLine(Name01);
            //Console.WriteLine(Name01.GetHashCode());

            //Console.WriteLine(Name02);
            //Console.WriteLine(Name02.GetHashCode());

            //Name01 = "Mostafa";
            //Console.WriteLine(Name01);
            //Console.WriteLine(Name01.GetHashCode());

            //Console.WriteLine(Name02);
            //Console.WriteLine(Name02.GetHashCode());

            //string Message = "Hello";

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            //Message += "Route";

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());



            #endregion

            #region StringBuilder
            //StringBuilder Message;

            //Message = new StringBuilder("Welcome");

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            //Message.Append(" to Route");
            //Message.AppendLine(" Eman");
            //Message.Remove(0,7);
            //Message.Insert(0,"Hello");

            //Console.WriteLine();
            //int Age = 10;
            //string Name = "Ali";
            //Message.AppendFormat("Name : {0} , Age : {1}", Name, Age);

            //Console.WriteLine(Message);




            #endregion

            #region Array 1 D
            //int[] Numbers = new int[3] {1,2,3};
            //int[] Numbers = new int[] {1,2,3};
            //int[] Numbers =  {1,2,3};

            int[] Numbers = new int[3];

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //for(int i= 0; i< Numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter Element Number {i + 1}");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for(int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);

            #endregion
        }
    }
}
