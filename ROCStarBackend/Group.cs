
namespace ROCStarBackend;

public class Group(string id)
{
  public string Id { get; private set; } = id;

  public List<Student> Students { get; set; } = [];

  public void Add(Student student) => Students.Add(student);

  public void Remove(Student student) => Students.Remove(student);

  public override string ToString() => Id;

  readonly bool [] Ascending = [true, true, true];

  public void Sort(int column)
  {
    switch (column)
    {
      case 0:
        Students = Ascending[column] ? 
          [.. Students.OrderBy(student => student.Id)] :
          [.. Students.OrderByDescending(student => student.Id)];
        Ascending[column] =! Ascending[column];
        break;

      case 1:
        Students = Ascending[column] ?
         [.. Students.OrderBy(student => student.Name)] :
         [.. Students.OrderByDescending(student => student.Name)];
        Ascending[column] = !Ascending[column];
        break;

      case 2:
        Students = Ascending[column] ?
         [.. Students.OrderBy(student => student.BirthDate)] :
         [.. Students.OrderByDescending(student => student.BirthDate)];
        Ascending[column] = !Ascending[column];
        break;
    }
  }
}
