using System;
// required in addition to other 'using necessary
using System.Diagnostics;
using System.IO;

namespace testProj
{
    class test
    {
        static void Main(string[] args)
        {
            // Outputs at Start of Program
            Console.WriteLine("Starting Zip and Encrypt!");
            
            // Defining Paths and Variables
            // string startPath = @"./TestFiles";
            // string subPath = @"./TestFiles/Test";

            // Type your path and subpath vars and press enter
            Console.WriteLine("Enter main path:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string startPath = Console.ReadLine();

            // Type your path and subpath vars and press enter
            Console.WriteLine("Enter sub path:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string subPath = Console.ReadLine();


            Console.WriteLine("Main Path: " + startPath);
            Console.WriteLine("Sub Path: " + subPath);

            // Check if sub directory exists
            if (!Directory.Exists(startPath))  
            {  
                Console.WriteLine("start Directory Does not Exist"); 
            }  

            // Check if sub directory exists
            if (!Directory.Exists(subPath))  
            {  
                Console.WriteLine("Sub Directory Does not Exist"); 
            }  
        }
    }
}