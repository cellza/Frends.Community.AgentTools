namespace AgentTools.Tests;

using AgentTools.Definitions;
using NUnit.Framework;

[TestFixture]
internal class UnitTests
{
    [Test]
    public void Test()
    {
        var input = new Input
        {
            Content = "foobar",
        };

        var options = new Options
        {
            Amount = 3,
            Delimiter = ", ",
        };

        var ret = NetworkClass.Ping(input, options, default);

        Assert.That(ret.Output, Is.EqualTo("foobar, foobar, foobar"));
    }
}
