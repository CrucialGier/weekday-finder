using System;
using Nancy;
using Xunit;
using System.Collections.Generic;

namespace DaySearcher.Objects
{
  public class Searcher
  {
    private string _monthStringInput;
    private string _dayStringInput;
    // private string _yearStringInput;
    private static string[] _days = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
    private static int[] _monthCodesNonLeap = {6, 2, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4};
    private static int[] _monthCodesLeapYear = {5, 1, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4};
    private static int _yearCode2015 = 4;

    public string GetMonthString()
    {
      return _monthStringInput;
    }
    public void SetMonthString(string newStringMonth)
    {
      _monthStringInput = newStringMonth;
    }
    public string GetDayString()
    {
      return _dayStringInput;
    }
    public void SetDayString(string newStringDay)
    {
      _dayStringInput = newStringDay;
    }

    // public bool IsLeapYear()
    // {
    //   if ((_yearInput % 400 == 0) || (_yearInput % 4 == 0 && _yearInput % 100 != 0))
    //   {
    //     return true;
    //   }
    // }

    public string GetDay()
    {
      int monthInput = int.Parse(_monthStringInput);
      int dayInput = int.Parse(_dayStringInput);
      // int yearInput = int.Parse(_yearStringInput);
      int monthValue = _monthCodesNonLeap[monthInput - 1];
      int totalValue = monthValue += dayInput += _yearCode2015;
      return _days[totalValue % 7];
    }
  }
}
