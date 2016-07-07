using Xunit;

namespace DaySearcher.Objects
{
  public class SearcherTest
  {
    [Fact]
    public void DaySearcher_2015Only_5()
    {
      Searcher newTestSearcher = new Searcher();
      newTestSearcher.SetMonthString("1");
      newTestSearcher.SetDayString("1");
      newTestSearcher.SetYearString("2009");
      // System.Console.WriteLine("result: ");
      Assert.Equal("Thursday", newTestSearcher.GetDay());
    }
  }
}
