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

}