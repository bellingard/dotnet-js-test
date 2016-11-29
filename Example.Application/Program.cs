using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example.Core;

namespace Example.Application
{
  class Program
  {
    static void Main(string[] args)
    {
      MoneyBag bag = new MoneyBag();
      Money moneyA = new Money(10, "EUR");
      Money moneyB = new Money(20, "USD");
      Money moneyC = new Money(15, "EUR");
      Money moneyD = new Money(25, "JPY");
      IMoney money = bag.AddMoney(moneyA);
      money = money.AddMoney(moneyB);
      money = money.AddMoney(moneyC);
      money = money.AddMoney(moneyD);
      Console.WriteLine("My Portfolio : " + money.ToString());
      Console.ReadLine();
    }

  }

}
