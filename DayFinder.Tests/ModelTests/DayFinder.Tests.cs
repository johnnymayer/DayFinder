using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayFinder.Models;
using System;

namespace DayFinder.TestTools
{
  [TestClass]
  public class DayFinderTest
  {

    [TestMethod]
    public void GetDate_TestInput_Int()
    {
      //arrange
      int testYear = 2018;
      int testMonth = 2;
      int testDay = 15;
      DayFind newDayFind = new DayFind(2018, 2, 15);

      //act
      int targetYear = newDayFind.GetYear();
      int targetMonth = newDayFind.GetMonth();
      int targetDay = newDayFind.GetDay();

      //assert
      Assert.AreEqual(testYear, targetYear);
      Assert.AreEqual(testMonth, targetMonth);
      Assert.AreEqual(testDay, targetDay);

    }
  }
}
