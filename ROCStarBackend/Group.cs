namespace ROCStarBackend;

public class Group(string id)
{
  public string Id { get; private set; } = id;

  public List<Student> Students { get; private set; } = [];

  public override string ToString() => Id;
}
