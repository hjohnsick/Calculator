using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class Examples
    {
        public static string ExampleLoadTextFile(string file)
        {
            if (file.Length < 10)
            {
                throw new System.IO.FileNotFoundException();
            }

            return "The file was correctly loaded";
        }
    }
}
