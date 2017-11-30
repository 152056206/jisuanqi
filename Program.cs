using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static float a, b;
        static string op, flag = "y";

        static void Main(string[] args)
        {
            while (flag.Equals("y") || flag.Equals("Y"))
            {
                Console.WriteLine("第一行输入第一操作数，第二行输入第二操作数，第三行输入要执行的操作(+，-，*，/)：");
                GetParams();
                Console.WriteLine("运算结果为：" + Calculate(a, b, op));
                Console.WriteLine("是否继续？（y或Y继续，其他键退出）");
                flag = Console.ReadLine();
            }
        }

        static void GetParams()
        {
            try
            {
                a = float.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("您输入的操作数格式有误--" + e.Data);
                a = 0;
            }

            try
            {
                b = float.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("您输入的操作数格式有误--" + e.Data);
                b = 0;
            }

            op = Console.ReadLine();
        }
        static float Calculate(float a, float b, string op)
        {
            switch (op)
            {
                case "+":
                    return Calculator.Add(a, b);
                case "-":
                    return Calculator.Sub(a, b);
                case "*":
                    return Calculator.Cheng(a, b);
                case "/":
                    return Calculator.Chu(a, b);
                default:
                    Console.WriteLine("您输入了一个未知的运算符");
                    return 0;
            }
        }
    }

    class Calculator
    {
        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Sub(float a, float b)
        {
            return a - b;
        }

        public static float Cheng(float a, float b)
        {
            return a * b;
        }

        public static float Chu(float a, float b)
        {
            if (b == 0)
            {
                Console.WriteLine("除数不能为0！");
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }
}
