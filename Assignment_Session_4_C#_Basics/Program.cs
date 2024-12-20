namespace Assignment_Session_4_C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            int Number;
            bool Flag;
            Console.Write("Please , Enter Number ");
            Flag = int.TryParse(Console.ReadLine(), out Number);

            Console.WriteLine($"Numbers Between 1 and {Number}");

            if (Flag && Number > 0) 
            {
                for (int i = 1; i <= Number; i++) 
                {
                Console.WriteLine(i);
                }
            }

            #endregion
        }
    }
}
