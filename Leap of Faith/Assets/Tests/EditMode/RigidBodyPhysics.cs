using NUnit.Framework;

public class RigidBodyPhysics
{
    [Test]
    public void StrengthTest()
    {
        Assert.AreEqual(1.1f, BasicRigidBodyPush.strength);
    }
}