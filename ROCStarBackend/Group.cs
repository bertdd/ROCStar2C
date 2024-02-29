
namespace ROCStarBackend;

public class Group(string id)
{
  public string Id { get; private set; } = id;

  public List<Student> Students { get; private set; } = [];

  public void Add(Student student) => Students.Add(student);

  public void Remove(Student student) => Students.Remove(student);

  public override string ToString() => Id;
}
