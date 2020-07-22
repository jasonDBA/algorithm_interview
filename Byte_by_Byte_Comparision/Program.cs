using System;
using System.IO;

namespace Byte_by_Byte_Comparision
{
    class Program
    {
        // Question: What is the efficient way to see if two files are same?
        public static bool FileCompare(string file1, string file2)
        {
            // Answer: Will count the number of characters in each files
            // One character is represented as one byte - Byte-by-byte comparision
            
            // How?
            // 1. If we are using C#, we can use FileStream class to read a file as a byte array
            // 2. Count the length of two arrays then compare it

            // Doing two simple checks
            // 1. File reference
            // 2. The number of characters in two files

            // Compare both file reference
            if(file1 == file2)
            {
                return true;
            }

            // Compare the size of the two files
            // By reading their bytes
            
            // Open the two files
            // FileStream returns a byte array
            FileStream fs1 = new FileStream(file1, FileMode.Open);
            FileStream fs2 = new FileStream(file2, FileMode.Open);

            // if the size of the two files are not same, not equal.
            // Close the file and return false.
            if(fs1.Length != fs2.Length)
            {
                fs1.Close();
                fs2.Close();
                return false;
            }

            // If the size are same, reach one byte from each file.
            int file1Byte;
            int file2Byte;
            do
            {
                file1Byte = fs1.ReadByte();
                file2Byte = fs2.ReadByte();
            } while ((file1Byte == file2Byte) && (file1Byte != -1));

            // Close the files
            fs1.Close();
            fs2.Close();

            return ((file1Byte == file2Byte));

        }
        static void Main(string[] args)
        {
            string file1 = "Given file1 path";
            string file2 = "Given file2 path";

            bool result = FileCompare(file1, file2);

            Console.Write("Are the two files same? {0}", result);
        }
    }
}
