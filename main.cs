using System;

class Program
{
  public static void Main(string[] args)
  {
    hero x = new hero();
    x.sName = "NewHero";
    x.nHP = 100;
    x.nPower = 120;

    Console.WriteLine("이름 : {0}, 체력 : {1}, 공격력 : {2}", x.sName, x.nHP, x.nPower);

    Console.WriteLine("이름 [{0}] ",x.sName);
    x.Attack("닝겐");
  }
}

class hero
{
  public string sName;
  public int nHP;
  public int nPower;

  public void Attack(string target)
  {
      Console.WriteLine("{0}에 {1}의 데미지를 주었습니다.", target, nPower);
  }
}

