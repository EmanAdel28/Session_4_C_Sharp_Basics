using System;
using System.Transactions;

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

            //bool Flag;
            //int DecimalNumber;


            //do
            //{
            //    Console.Write("Enter DecimalNumber ");
            //    Flag = int.TryParse(Console.ReadLine(), out DecimalNumber);
            //} while (!Flag || DecimalNumber < 0);

            //string binaryResult = "";

            //if (DecimalNumber == 0)
            //{
            //    binaryResult = "0";
            //}
            //else
            //{
            //    while (DecimalNumber > 0)
            //    {
            //        int remainder = DecimalNumber % 2;
            //        binaryResult = remainder + binaryResult; // Prepend the remainder to the result
            //        DecimalNumber /= 2;
            //    }
            //}

            //Console.WriteLine($"Binary representation: {binaryResult}");

            #endregion

            #region Q8
            // 8- . Write a program that prints an identity matrix using for loop, in other words takes a value n
            // //from the user and shows the identity table of size n * n.

            //bool Flag;
            //int Number;


            //do
            //{
            //    Console.Write("Enter Number ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (!Flag || Number < 0);

            //Console.Write($"Matrix {Number}*{Number} ");

            //for(int i = 0; i < Number; i++)
            //{
            //    for (int j = 0; j < Number; j++)
            //    {

            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    }

            #endregion

            #region Q9
            //9- Write C# program that Extract a substring from a given string.

            //string inputString;
            //int StartIndex;
            //int lenght;
            //bool Flag;


            //Console.WriteLine("input String ");
            //inputString = Console.ReadLine();
            //do
            //{
            //    Console.Write("Enter StartIndex ");
            //    Flag = int.TryParse(Console.ReadLine(), out StartIndex);

            //    Console.Write("Enter lenght  ");
            //    Flag = int.TryParse(Console.ReadLine(), out lenght);

            //} while (!Flag || StartIndex < 0 || lenght < 0 );

            //string substring = inputString.Substring(StartIndex, lenght);

            //// Display the result
            //Console.WriteLine($"Extracted substring: {substring}");
            #endregion

            #region Q10
            //10- Write C# program that take two string variables and print them as one variable 

            //String String01;
            //String String02;
            //String Result;

            //Console.WriteLine("input String01 ");
            //String01 = Console.ReadLine();

            //Console.WriteLine("input String02 ");
            //String02 = Console.ReadLine();

            //Result = $"{String01} {String02}";


            //Console.WriteLine($"Result is: {Result}");

            #endregion

            #region Q11
            //11- . Write a program that prints an identity matrix using for loop, in other words takes a value n
            //from the user and shows the identity table of size n * n.

            //bool Flag;
            //int Number;


            //do
            //{
            //    Console.Write("Enter Number ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (!Flag || Number < 0);

            //Console.Write($"Matrix {Number}*{Number} ");

            //for(int i = 0; i < Number; i++)
            //{
            //    for (int j = 0; j < Number; j++)
            //    {

            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    }
            #endregion

            #region Q12
            //12- Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //int Sum  = numbers.Sum();
            //Console.WriteLine($"Sum of element = {Sum}");
            #endregion

            #region Q13
            //13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //bool Flag;
            //int n;


            //do
            //{
            //    Console.WriteLine("Enter the lenght of array ");
            //    Flag = int.TryParse(Console.ReadLine(), out n);

            //} while(!Flag || n <0);

            //int[] array1 = new int[n];
            //int[] array2 = new int[n];
            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            //// Input elements for the second array
            //Console.WriteLine("Enter elements for the second array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] mergedArray = new int[2 * n];
            //Array.Copy(array1, 0, mergedArray, 0, n);  // Copy first array to mergedArray
            //Array.Copy(array2, 0, mergedArray, n, n);

            //Array.Sort(mergedArray);

            //// Display the sorted merged array
            //Console.WriteLine("The merged and sorted array is:");
            //foreach (int element in mergedArray)
            //{
            //    Console.Write(element + " ");
            //}
            #endregion

            #region Q14
            //14- Write a program in C# Sharp to count the frequency of each element of an array.

            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //// Declare the array and input its elements
            //int[] array = new int[size];
            //Console.WriteLine($"Enter {size} elements for the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //// Use a dictionary to store the frequency of each element
            //Dictionary<int, int> frequency = new Dictionary<int, int>();

            //// Count the frequency of each element in the array
            //foreach (int num in array)
            //{
            //    if (frequency.ContainsKey(num))
            //    {
            //        frequency[num]++;
            //    }
            //    else
            //    {
            //        frequency[num] = 1;
            //    }
            //}

            //// Display the frequency of each element
            //Console.WriteLine("Frequency of each element:");
            //foreach (KeyValuePair<int, int> entry in frequency)
            //{
            //    Console.WriteLine($"Element {entry.Key} appears {entry.Value} times.");
            //}
            #endregion

            #region Q15
            //15- Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] Numbers = new int[5];

            //int[] Numbers = new int[5] { 1, 2, 3, 4, 5 }; ;

            //Console.WriteLine("Enter Elements of Array");

            //for (int i = 0; i < Numbers.Length; i++) {

            //        Numbers[i] = int.Parse(Console.ReadLine());

            //        }

            //int Max = Numbers.Max();
            //Console.WriteLine("Max of elements");

            //Console.WriteLine(Max);

            //int Min = Numbers.Min();
            //Console.WriteLine("Min of elements");

            //Console.WriteLine(Min);


            #endregion

            #region Q16
            //16- Write a program in C# Sharp to find the second largest element in an array.

            //int[] Number = { 10, 30, 40, 15 };
            //int largest = int.MinValue;
            //int SecondLargest = int.MinValue;

            //foreach (int num in Number)
            //{
            //    if (num > largest)
            //    {
            //        SecondLargest =  largest;
            //        ;  // The current largest becomes the second largest
            //        largest = num;            // Update the largest
            //    }
            //    else if (num > SecondLargest && num != largest)
            //    {
            //        SecondLargest = num;      // Update the second largest
            //    }
            //}
            //Console.WriteLine($"The largest element is: {largest}");
            //Console.WriteLine($"The second largest element is: {SecondLargest}");
            #endregion

            #region Q17
            //17-. Consider an Array of Integer values with size N, having values as    


            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //// Declare the array and input its elements
            //int[] array = new int[size];
            //Console.WriteLine($"Enter {size} elements for the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //// Dictionary to store the first occurrence of each element
            //Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
            //int maxDistance = -1;  // Store the longest distance

            //// Iterate through the array and calculate the distance
            //for (int i = 0; i < size; i++)
            //{
            //    if (firstOccurrence.ContainsKey(array[i]))
            //    {
            //        // Calculate the distance between first occurrence and current index
            //        int distance = i - firstOccurrence[array[i]] - 1;
            //        if (distance > maxDistance)
            //        {
            //            maxDistance = distance;
            //        }
            //    }
            //    else
            //    {
            //        // Store the first occurrence of the element
            //        firstOccurrence[array[i]] = i;
            //    }
            //}

            //// Output the result
            //if (maxDistance != -1)
            //{
            //    Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
            //}
            //else
            //{
            //    Console.WriteLine("No two equal cells were found.");
            //}
            #endregion

            #region Q18
            //18- Write a program to create two multidimensional arrays of same size. Accept value from user
            //and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int columns = int.Parse(Console.ReadLine());

            //// Declare two 2D arrays with the specified dimensions
            //int[,] array1 = new int[rows, columns];
            //int[,] array2 = new int[rows, columns];

            //// Accept values from the user and store them in the first array
            //Console.WriteLine("Enter values for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Enter value for element ({i + 1},{j + 1}): ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Copy all elements from the first array to the second array using Array.Copy
            //for (int i = 0; i < rows; i++)
            //{
            //    // Copy the entire row from array1 to array2
            //    Array.Copy(array1, i * columns, array2, i * columns, columns);
            //}

            //// Print the second array
            //Console.WriteLine("\nSecond array after copying:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(array2[i, j] + "\t");
            //    }
            //    Console.WriteLine(); // Move to the next row
            //}

            #endregion

            #region Q19
            //19- Write a Program to Print One Dimensional Array in Reverse Order

            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine($"Enter {size} elements for the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(array);

            Console.WriteLine("Array in reverse order:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            #endregion


        }
    }
}
