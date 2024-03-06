namespace ROCStarBackend;

internal class TestGroup
{
  public static Group Test =>
    new("OITSDO2U")
    {
      Students = [
        new Student
        {
          Id = 4
        }
      ]
    };
}
