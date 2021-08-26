using System;
using System.Collections.Generic;
using System.Text;

namespace Lz11
{
    sealed class MyClass : MyAbsClass, IMyInterface, IMySecondInterface
    {

        public int Property1 { get; set; }
        public int Property2 { get; set; }
        public int Property3 { get; set; }
        public int X { get { return x; } }
        private int x;
        public int Y { get { return y; } private set { y = value; } }
        private int y;
        public int MyIProp { get; set; }


        public MyClass(int Pr1, int Pr2, int Pr3)
        {
            this.Property1 = Pr1;
            this.Property2 = Pr2;
            this.Property3 = Pr3;
            NewObject();
        }
        public void Method1()
        {
            //Do somethig
        }
        public int Method2(int someVal)
        {
            return someVal * 10;
        }

        public static int ObjCreated = 0;
        public static void NewObject()
        {
            ObjCreated += 1;
        }

        public override int VMethod()
        {
            return base.VMethod() + 10;
        }

        public override int AMethod()
        {
            return 1500;
        }

        int IMyInterface.MyIMethod(int sval)
        {
            return sval * 3;
        }
        int IMySecondInterface.MyIMethod(int sval)
        {
            return sval * 3;
        }
    }
    public abstract class MyAbsClass
    {
        public virtual int VMethod()
        {
            return 10;
        }
        public abstract int AMethod();
    }
    public interface IMyInterface
    {
        public int MyIProp { get; set; }
        public int MyIMethod(int sval);
    }
    public interface IMySecondInterface
    {
        public int MyIProp { get; set; }
        public int MyIMethod(int sval);
    }

    public static class Extension  
    {
        static string ToString(this IMyInterface myClass)
        {
            return "ToString";
        }
    }

    class Exception : SystemException
    {
        public Exception(string message)
        {
            Console.WriteLine(message);
        }
    }

    public enum Weak { 
    ponedilok =1,
    vivtorok =2,
    sereda =3,
    chetver =4,
    piatnca =5,
    subota =6,
    nedilia =7
    }
}
