namespace ROCStarBackend;

public class TestData
{
  public static Group GetGroup()
  {
    return
    new("OITSDO2A")
    {
      Students =
      [
        new Student(2165392, "Dejah"),
        new Student(2150270, "Danny")
        {
          BirthDate = new DateOnly(2004, 10, 27)
        },
        new Student(216975, "Lenny"),
        new Student(2165865, "Valerio"),
        new Student(999, "Bert")
      ]
    };
  }
}
