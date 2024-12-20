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
            int Number;
            bool Flag;
           
            do
            {
                Console.Write("Enter Number ");
                Flag = int.TryParse(Console.ReadLine(), out Number);
            } while (!Flag || Number < 0);

            Console.WriteLine($"Even Number Between 1 and {Number}");

            for (int i = 1; i <= Number ; i++)
            {
                if(i%2==0)
                Console.WriteLine(i);
            }



            #endregion
        }
    }
}
