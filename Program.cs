using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Remove Duplicate Characters using HashSet 

            //Console.Write("Enter a String : ");
            //string inputString = Console.ReadLine();
            //string resultString = string.Empty;

            //var unique = new HashSet<char>(inputString);
            //foreach (char c in unique)
            //{
            //    resultString += c;
            //}

            //Console.WriteLine("After Removing Duplicates : " + resultString);
            //Console.ReadKey();

            #endregion End Remove Duplicate Characters using HashSet

            #region Remove Duplicate Characters using LINQ 

            //Console.Write("Enter a String : ");
            //string inputString = Console.ReadLine();

            //var uniqueCharArray = inputString.ToCharArray().Distinct().ToArray();
            //var resultString = new string(uniqueCharArray);

            //Console.WriteLine("After Removing Duplicates : " + resultString);
            //Console.ReadKey();

            #endregion End Remove Duplicate Characters using LINQ

            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string resultString = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString += inputString[i];
                }
            }
            Console.WriteLine("After Removing Duplicates : {0} ", resultString);
            Console.ReadKey();
        }
    }
}
