using System;

namespace ConsoleApp1
{
  class Test
  {
    public int nNum1 = 100;
    public int nNum2;

    string sName = "객체";

    public Test()
    {
      Console.WriteLine("Test() 실행");
    }
    //1. 생성자의 오버로딩
    public Test(string name)
    {
      sName = name;
      Console.WriteLine(sName + " 생성!");
    }

    //3. 이름이 동일한 변수이지만 this 키워드를 사용하여
    //   자기 자신의 인스턴스에 접근
    public Test(int nNum1, int nNum2)
    {
      this.nNum1 = nNum1;
      this.nNum2 = nNum2;
    }
   ~Test()
    {
      Console.WriteLine("{0} 소멸!", sName);
    }
      
    public void Show()
    {
      Console.WriteLine("{0} nNum1 : {1}, nNum2 : {2}", sName, nNum1, nNum2);
    }
      
    //5. 깊은 복사
    //새로운 인스턴스를 생성해 클론을 만듭니다.
    public Test GetClone()
    {
      Test newInstance = new Test("클론 객체");
      newInstance.nNum1 = this.nNum1;
      newInstance.nNum2 = this.nNum2;
      
      return newInstance;
    }
    }
      
    static void Main(string[] args)
    {
      //2. 초기화 되지 않은 멤버 변수
      Test testA = new Test("A 객체");
      testA.Show();
      
      
      Test testB = new Test(1, 3);
      testB.Show();
      
      //4. 참조가 끊겨 가비지가 되었음
      testB = null;       
      
      //6. 가비지 콜렉터 호출
      System.GC.Collect();
      Console.WriteLine();
      Console.WriteLine("가비지 컬렉터 호출.....");
      Console.WriteLine();
      
      Console.WriteLine("얕은 복사");
      Test testC = testA;
      testC.nNum1 = -10;
      testC.nNum2 = -30;
      testA.Show();       //testC의 필드에 값을 할당했지만 testA의 값이 변경되었음
      testC.Show();
      Console.WriteLine();
      
      Console.WriteLine("깊은 복사");
      testC = testA.GetClone();
      testC.nNum1 = 88;
      testC.nNum2 = 99;
      testA.Show();
      testC.Show();
      Console.WriteLine();
    }
  }
}