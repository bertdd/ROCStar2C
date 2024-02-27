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
    var group = new Group("group1");
    Console.WriteLine(group.Id);
    Assert.IsNotNull(group);
    Assert.AreEqual(group.Id, "group1");
  }
}