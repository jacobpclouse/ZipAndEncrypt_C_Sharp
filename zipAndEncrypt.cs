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
            string startPath = @"./TestFiles";
            string subPath = @"./TestFiles/Test";
            Console.WriteLine(startPath);
            Console.WriteLine(subPath);

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