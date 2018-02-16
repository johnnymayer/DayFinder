using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DayFinder.Models;
using System;

namespace DayFinder.Models
{
  public class DayFind
  {
    private int _year;
    private int _month;
    private int _day;

    public DayFind(int year, int month, int day)
    {
      _year = year;
      _month = month;
      _day = day;
    }

    public int GetDay()
    {
      return _day;
    }

    public int GetMonth()
    {
      return _month;
    }

    public int GetYear()
    {
      return _year;
    }

    public string ReturnDayOfWeek()
    {
      DateTime dt = new DateTime(_year, _month, _day);
      return dt.DayOfWeek.ToString();
    }


  }
}
