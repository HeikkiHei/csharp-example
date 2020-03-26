using System;
using System.IO;
using NUnit.Framework;
using Example;

namespace ExampleTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExample()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Hello World!\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match!");
      }
    }

    [Test]
    public void TestExampleNegated()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreNotEqual("Hei Maailma!\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match!");
      }
    }
  }
}