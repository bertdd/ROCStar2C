namespace ROCStarBackend;

public class TestData
{
  public static Group GetTestGroup()
  
    => new("OITSDO2E")
    {
      Students =
      {
        new Student("Mus"),
        new Student("Levi"),
        new Student("Gino"),
        new Student("Zine")
      }
    };
}
