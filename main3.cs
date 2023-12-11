using System;

namespace ConsoleApp1
{
    class Program
    {
        class Test
        {
          private int nNum;

          public int NUMBER
          {
            get{ return nNum; }
            set
            {
              nNum = value;

              if (nNum > 100)
                  nNum = 100;
              else if (nNum < -100)
                  nNum = -100;
            }
          }

          public Test(int a)
          {
            nNum = a;
          }
          public void Show()
          {
            Console.WriteLine("nNum : {0}", nNum);
          }
        }

        static void Main(string[] args)
        {
          Test testA = new Test(88);
          testA.Show();

          testA.NUMBER = 10000;
          testA.Show();

          int nGetNumber = testA.NUMBER;
          Console.WriteLine(nGetNumber);
        }
    }
}