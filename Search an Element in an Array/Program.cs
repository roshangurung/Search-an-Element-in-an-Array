using System;
using System.IO;

namespace Search_an_Element_in_an_Array/////This C# program is used to search an element with array indices. We have already defined the values of ‘ints[]’ array variable. Using for loop print the coefficient element values present in the ints[] array variable.////
{
    class Program////The Findobject() function uses the BinarySearch() function to search an array element. Nested if else condition statement is used to check that the value of ‘index’ variable is greater than 0. If the condition is true then execute the statement and print the index of the value present in the array.////
    {
        static void Main(string[] args)
        {
            string[] array1 = { "cat", "dogs", "donkey", "camel" };
            string v1 = Array.Find(array1,
                element => element.StartsWith("cam", StringComparison.Ordinal));
            string v2 = Array.Find(array1,
                element => element.Length == 3);
            Console.WriteLine("The Element that Starts with 'Cam' is : " + v1);
            Console.WriteLine("3 Letter word in the Array is : " + v2);
            Console.ReadLine();
        }
    }
}
///Output:
///The Element that Starts with 'Cam' is: Camel
///3 Letter word in the Array is : cat
