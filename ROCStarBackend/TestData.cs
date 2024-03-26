namespace ROCStarBackend;

public class TestData
{
  public static Group GetGroup()
  
    => new("OITSDO2E")
    {
      Students =
      {
        new Student(45, "Mus"),
        new Student(22, "Levi"),
        new Student(312, "Gino")
        {
          Birthday = new DateOnly(2000, 1, 10)
        },
        new Student(566, "Zinedine")
      }
    };
}
