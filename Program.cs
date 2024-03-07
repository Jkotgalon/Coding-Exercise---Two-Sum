using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Coding Exercise!\n");

            Console.Write("Enter how many integers you are about to input >> ");
            int lengthOfArray = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[lengthOfArray];
            HashSet<int> enteredElements = new HashSet<int>();

            Console.Write("Enter the target integer >> ");
            int target = Convert.ToInt32(Console.ReadLine());

            int count = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                int num;
                do
                {
                    Console.Write($"Enter the integer for #{count + i} >> ");
                    num = int.Parse(Console.ReadLine());

                    if (enteredElements.Contains(num))
                    {
                        Console.WriteLine("This element has already been entered. Please enter a different element.");
                    }
                } while (enteredElements.Contains(num));

                nums[i] = num;
                enteredElements.Add(num);
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"[{i},{j}]");
                    }
                }
            }
        }
    }
}

