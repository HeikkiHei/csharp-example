using System;
using NUnit.Framework;
using Animals;

public class PetTests
{
  [Test]
  public void DogTalkToOwnerReturnsWoof()
  {
    string expected = "Woof!";
    string actual = new Dog().TalkToOwner();

    Assert.AreEqual(expected, actual, "Dog should say Woof!");
  }

  [Test]
  public void RatTalkToOwnerReturnsSqueek()
  {
    string expected = "Squeek!";
    string actual = new Rat().TalkToOwner();

    Assert.AreEqual(expected, actual, "Rat should say Squeek!");
  }
}
