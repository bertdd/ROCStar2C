using ROCStarBackend;

namespace ROCtest;

[TestClass]
public class ROCStarTests
{
  [TestMethod]
  public void TestCreateStudent()
  {
    var student = new Student(1, "Bert");
    Console.WriteLine(student.Name);
  }

  [TestMethod]
  public void TestCreateTeacher()
  {
    var student = new Teacher(1, "Milan");
    Console.WriteLine(student.Name);
  }

  [TestMethod]
  public void TestCreateClassroom()
  {
    var classroom = new Classroom("A319C");
    Assert.AreEqual(classroom.Id, "A319C");
    Console.WriteLine(classroom.Id);
  }

  [TestMethod]
  public void TestCreateGroup()
  {
    const string id = "OITSDO2C";
    var group = new Group(id);
    Console.WriteLine(group.Id);
    Assert.IsNotNull(group);
    Assert.AreEqual(group.Id, id);
    Assert.IsTrue(group.Students.Count() == 0);
  }

  [TestMethod]
  public void AddStudentToGroup() {
        const string id = "OITSDO2C";
        var group = new Group(id);
        var student = new Student(255, "Milan");
        var teacher = new Student(2232, "Bert");

        group.Add(student);

        group.Add(teacher);

        group.Remove(teacher);

        Assert.IsFalse(group.Students.Contains(teacher));

        Assert.IsTrue(group.Students.Contains(student));
  }
}