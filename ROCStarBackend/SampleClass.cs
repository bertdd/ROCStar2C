namespace ROCStarBackend;

public static class SampleClass
{
  public static Group OITSDO2C
    => new("OITSDO2C")
    {
      Students =
      {
        new Student(4, "Yveys"),
        new Student(5, "Milan"),
        new Student(6, "Bert")
        {
          BirthDate = new DateOnly(1960, 01, 15)
        },
        new Student(7, "Levinio")
        {
          BirthDate = new DateOnly(2004, 08, 22)
        }
      }
    };
}
