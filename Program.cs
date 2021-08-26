using System;

namespace Lz11
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                MyClass myClass = new MyClass(1, 2, 3);
                Console.WriteLine(myClass.ToString());
            throw new Exception("randomText");
            }
            catch (Exception e) 
            {
            }
        }
    }
}
