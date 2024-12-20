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
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10 };

            for (int i = 0; i < Numbers.Length; i++)
            {

                //if (Numbers[i] == 5)
                //{
                //    break;
                //}

                if (Numbers[i] == 5)
                {
                    continue;
                }
                Console.WriteLine(Numbers[i]);
            }


            // Class impliement interface IEnummrable

            foreach (int Number in Numbers)
            {
                Console.WriteLine(Number);
            }
            #endregion
        }
    }
}
