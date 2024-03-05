
namespace ROCStarBackend;

public abstract class Person(int id, string name)
{
  public int Id { get; set; } = id;

  public string Name { get; set; } = name;

  public DateOnly BirthDate { get; set; }

  public int Age()
    => (DateTime.Now - new DateTime(BirthDate.Year, BirthDate.Month, BirthDate.Day)).Days / 365;
}
    