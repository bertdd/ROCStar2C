using ROCStarBackend;

namespace RoCTestNew;

[TestClass]
public class UnitTest1
{
  [TestMethod]
  public void TestStudent()
  {
    var student = new Student();
    Assert.IsNotNull(student);
  }

  [TestMethod]
  public void TestStudentId()
  {
    var student = new Student
    {
      Id = 5
    };
    Assert.AreEqual(student.Id, 5);
  }
}