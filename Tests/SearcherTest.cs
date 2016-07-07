using Xunit;

namespace DaySearcher.Objects
{
  public class SearcherTest
  {
    [Fact]
    public void DaySearcher_2015Only_5()
    {
      Searcher newTestSearcher = new Searcher();
      newTestSearcher.SetMonthString("7");
      newTestSearcher.SetDayString("15");
      newTestSearcher.SetYearString("2015");
      // System.Console.WriteLine("result: ");
      Assert.Equal("Wednesday", newTestSearcher.GetDay());
    }
  }
}
