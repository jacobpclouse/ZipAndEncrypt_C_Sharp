// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
// Importing Libraries / Modules 
// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Runtime.InteropServices;


// Outputs at Start of Program
Console.WriteLine("Starting Zip and Encrypt!");

// Choose if this is a zip or unzip operation
Console.WriteLine("Is this an 'zip' or 'unzip' opeartion? ");
// Create a string variable and get user input from the keyboard and store it in the variable
string operationType = Console.ReadLine();
Console.WriteLine("Operation Type: " + operationType);

if(operationType != "unzip")
{
    Console.WriteLine("Zip Operation!");

    // Type your path and subpath vars and press enter
    Console.WriteLine("Enter main path:");
    // Create a string variable and get user input from the keyboard and store it in the variable
    string startPath = Console.ReadLine();
    Console.WriteLine("Main Path: " + startPath);

    // Type your new zipfile name and press enter
    Console.WriteLine("Enter zip file name (with '.zip' at end):");
    // Create a string variable and get user input from the keyboard and store it in the variable
    string zipName = Console.ReadLine();
    Console.WriteLine("Main Path: " + zipName);

    // Check if sub directory exists
    if (!Directory.Exists(startPath))
    {
        Console.WriteLine("Start Directory DOES NOT Exist");
    }
    else
    {
        Console.WriteLine("Start Directory Exists!!!!");

        // Get a list of all subdirectories and displaying them for the user to see
        var files = from file in
        Directory.EnumerateFiles(startPath)
                    select file;
        Console.WriteLine("Files: {0}", files.Count<string>().ToString());
        Console.WriteLine("List of Files");
        foreach (var file in files)
        {
            Console.WriteLine("{0}", file);
        }
        // Creating Zip file 
        ZipFile.CreateFromDirectory(startPath, zipName);

        

    }
}
else
{
    Console.WriteLine("Unzip Operation!");


    // Geting Path to zip file to unzip
    Console.WriteLine("Enter zip file path to unzip (with '.zip' at end):");
    // Create a string variable and get user input from the keyboard and store it in the variable
    string unzipName = Console.ReadLine();
    Console.WriteLine("Unzip This Zip Path: " + unzipName);

    // Geting Extract path where to place extracted folder
    Console.WriteLine("Enter extract path where to extract zip to:");
    // Create a string variable and get user input from the keyboard and store it in the variable
    string extractPath = Console.ReadLine();
    Console.WriteLine("Extract Path: " + extractPath);

    // function that actually unzips folder
    ZipFile.ExtractToDirectory(unzipName, extractPath);
}