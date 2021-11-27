using System;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            string path = "918014123456";
            Patterns obj = new Patterns();
            checkvalue = obj.validatePinCode(path);

            if (checkvalue)
            {
                Console.WriteLine("Pattern Match");
            }
            else
            {
                Console.WriteLine("Pattern NOt Matched");
            }
        }
    }
}