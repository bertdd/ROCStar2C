namespace ROCStarBackend;

/// <summary>
/// Represents the data for a student in 2U
/// </summary>
public class Student(int id, string name)
{
  public int Id { get; set; } = id;
  public string Name { get; set; } = name;
}
