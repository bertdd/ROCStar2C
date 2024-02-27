using ROCStarBackend;

namespace ROCStarTester;

[TestClass]
public class UnitTest1
{
  [TestMethod]
  public void TestCreateStudent()
  {
    var student = new Student();
    Assert.IsNotNull(student);
  }

  [TestMethod]
  public void TestCreateDocent()
  {
    var docent = new Docent();
    Assert.IsNotNull(docent);
  }
}
