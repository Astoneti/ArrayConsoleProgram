using System;
using System.Collections.Generic;

namespace ArrayConsoleApp2
{
    class Program
    {
        public static void DisplayMеnu(int[] myArray)
        {
            Console.WriteLine($"\n Please select what do you want to do with your array by entering numbers from 1-3!\n Press 1 - to find negative value in your array : \n Press 2 - to find positive value in your array : \n Press 3 - to find number Of element equal zero : \n Press'0'- to exit!");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    DisplayNegativeValues(myArray);
                    break;
                case 2:
                    DisplayPositiveValues(myArray);
                    break;
                case 3:
                   DisplayNumberOfElementEqualZero(myArray);
                    break;
                default:
                    Console.WriteLine($"\n You entered an invalid value!\n Please try again!");
                    break;
            }
            DisplayMеnu(myArray);
        }
        public static void ShowValues(List<int> values) 
        {
            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
        }
        public static void DisplayNegativeValues(int [] myArray)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < 0)
                {
                    result.Add(myArray[i]);
                }
            }
            Console.WriteLine($"\n Negative values in array is : ");
            ShowValues(result);
            
        }
        public static void DisplayPositiveValues(int [] myArray)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > 0) 
                {
                    result.Add(myArray[i]);
                }
            }
            Console.WriteLine($"\n Positive values in array is : ");
            ShowValues(result);
        }
        public static void DisplayNumberOfElementEqualZero(int[] myArray)
        {
            int count = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 0)
                {
                    count = i;
                    break;
                }
            }
            Console.WriteLine("The number of element equal zero is : " + count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"\n How many array elements do you want to create?");
            Console.Write($"\n Attention! Your array must contain integer values, negative values, and values equal to zero!");
            Console.Write($"\n Please enter the value:\t ");
            int elementsCount1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n You have created an array of {elementsCount1} elements");
            int[] myArray = new int[elementsCount1];
            Console.WriteLine($"\n Now, you have to inicialized ich of them!!!");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\n Enter the array element under the index {i} : ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\n Congratulations,you have created an array : ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\n { myArray[i]}");
            }
            DisplayMеnu(myArray);
    }   }
    
}
