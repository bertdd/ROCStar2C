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
        },
        new Student(45, "Don") { BirthDate = new DateOnly(1998, 11, 2)},
        new Student(32, "Mehmet") { BirthDate = new DateOnly(2005, 12, 12)},
        new Student(13, "Erencan")
      }
    };

}
