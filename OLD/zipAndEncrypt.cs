// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
// Importing Libraries / Modules 
// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;



// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
// Main Project / Namespace
// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
namespace zipAndEncrypt
{
    class zip
    {
        static void Main(string[] args)
        {
            // Outputs at Start of Program
            Console.WriteLine("Starting Zip and Encrypt!");

            // Type your path and subpath vars and press enter
            Console.WriteLine("Enter main path:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string startPath = Console.ReadLine();
            Console.WriteLine("Main Path: " + startPath);

            // Check if sub directory exists
            if (!Directory.Exists(startPath))  
            {  
                Console.WriteLine("Start Directory DOES NOT Exist"); 
            }
            else {
                Console.WriteLine("Start Directory Exists!!!!"); 

                // Get a list of all subdirectories  
                var files = from file in  
                Directory.EnumerateFiles(startPath)  
                            select file;  
                Console.WriteLine("Files: {0}", files.Count<string>().ToString());  
                Console.WriteLine("List of Files");  
                foreach (var file in files)  
                {  
                    Console.WriteLine("{0}", file);  
                } 

            }

        }
    }
}