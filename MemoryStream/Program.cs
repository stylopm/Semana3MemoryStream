using System;
using System.IO;
using System.IO;
using System.Text;

namespace MemoryStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World de nuevo!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine("**************");  // Output the content

            Console.WriteLine(readText);  // Output the content

            Console.WriteLine("--------------");  // Output the content
        }
    }
}
