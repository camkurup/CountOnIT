using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CountOnIT.Data
{
    public class DataMock
    {
        public DataMock() { }

        public void Write()
        {
            Console.WriteLine("Hello, World start!");
            string targetFile = Path.Combine("targetFileName");
            using FileStream outputStream = File.OpenWrite(targetFile);
            using StreamWriter streamWriter = new StreamWriter(outputStream);
            string intToFile = "1";
            Console.WriteLine("Write to file string " + intToFile);
            streamWriter.Write(intToFile);
            streamWriter.Close();
        }


        public void Read()
        {
            //Read from file
            string targetFile = Path.Combine("targetFileName");
            using FileStream InputStream = File.OpenRead(targetFile);
            using StreamReader reader = new StreamReader(InputStream);
            string returnedString = reader.ReadToEnd();
            Console.WriteLine("returnedString is: " + returnedString);
            Console.WriteLine("Hello, World end!");
        }
      

      
    }
}
