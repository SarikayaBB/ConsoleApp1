using SQLBaglanti.Controller;
using SQLBaglanti.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBaglanti
{
    public class Program
    {






        public static void Main(string[] args)
        {


            #region
            //string inp = (Console.ReadLine());
            //Console.WriteLine(timeConversion(inp));
            //Console.ReadLine();
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    List<int> list = new List<int>();
            //    for (int k = 0; k < n; k++)
            //    {
            //        list.Add(int.Parse(Console.ReadLine()));
            //    }
            //    arr.Add(list);
            //}

            //int result = diagonalDifference(arr);

            //Console.WriteLine(result);

            //Console.ReadLine();


            //    //int[] array = { 15, 13, 11, 9, 5 };
            //    //Console.WriteLine(MissingNumber(array));
            //    //Console.ReadLine();
            //    //Console.WriteLine("kelimeyi gir");
            //    //string str = Console.ReadLine();
            //    //Console.WriteLine(ReturnDuplicates(str));
            //    //Console.ReadLine();
            //    //Console.WriteLine("write down your string ");
            //    //string split = Console.ReadLine();
            //    //Console.WriteLine(Splitter(split));
            //    //Console.ReadLine();


            //   foreach (Customer customer in CustomerController.GetAll())
            //    {
            //        Console.Write(customer.Id + "\t" + customer.Guid + "\t" + customer.Name + "\t" + customer.Tel);
            //        Console.WriteLine();
            //    }
            //    foreach (Process process in ProcessController.GetAll())
            //    {
            //        Console.Write(process.Id + "\t" + process.Name + "\t" + process.Price);
            //        Console.WriteLine();

            //    }

            //    Console.ReadLine();
            #endregion
        }




        // AM PM Convertion
        public static string timeConversion(string s)
        {

            return DateTime.Parse(s).ToString("HH:mm:ss");
        }
        //Matrix diagonal difference
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftDiagonal = 0;
            int rightDiagonal = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                leftDiagonal += arr[i][i];
                rightDiagonal += arr[arr.Count() - 1 - i][i];

            }

            if (leftDiagonal > rightDiagonal)
            {
                return leftDiagonal - rightDiagonal;
            }
            else
            {
                return rightDiagonal - leftDiagonal;
            }

        }
        //find the max number in an array
        public static int MAxNumber(int[] nums)
        {
            int maxNumber = 0;
            foreach (int num in nums)
            {
                if (num > maxNumber) maxNumber = num;
            }
            return maxNumber;

        }
        // find the duplications in a word
        public static string ReturnDuplicates(string my_input)
        {
            string dup = "";
            char temp = new char();
            char[] letters = my_input.ToCharArray();
            for (int i = 1; i < letters.Length; i++)
            {
                temp = letters[i - 1];
                if (temp == letters[i])
                {
                    dup += temp;
                }
                else
                {
                    continue;
                }
            }
            return dup;
        }
        // find the missing number in an array that goes like 1 3 5 9 11
        public static int MissingNumber(int[] nums)
        {
            int missingNumber = 0;
            if (nums.FirstOrDefault() < nums.LastOrDefault())
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == nums.Length - 1)
                    {
                        continue;
                    }
                    else if (nums[i] == nums[i + 1] - 2)
                    {
                        continue;
                    }
                    else
                    {
                        missingNumber = (nums[i] + nums[i + 1]) / 2;
                    }
                }
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == nums.Length - 1)
                    {
                        continue;
                    }
                    else if (nums[i] == nums[i + 1] + 2)
                    {
                        continue;
                    }
                    else
                    {
                        missingNumber = (nums[i] + nums[i + 1]) / 2;
                    }
                }
            }
            return missingNumber;
        }

        // find the count of a character in an array 
        public static string Splitter(string str)
        {
            int aCounter = 0;
            int bCounter = 0;
            foreach (char c in str)
            {
                if (c == 'A')
                {
                    aCounter++;
                }
                else
                {
                    bCounter++;
                }
            }
            return "Number of A's in the given string is: " + aCounter + ", and the number of B's in the given string is: " + bCounter;
        }

    }

}




