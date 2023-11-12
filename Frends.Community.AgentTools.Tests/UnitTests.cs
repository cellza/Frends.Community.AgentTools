namespace Frends.Community.AgentTools.Tests;

using Frends.Community.AgentTools.Definitions;
using NUnit.Framework;
using System.Net;

[TestFixture]
internal class UnitTests
{
    [Test]
    public void Test()
    {
        var input = new Input
        {
            Content = "localhost"
        };

        var options = new Options
        {
            Amount = 3,
            Delimiter = ", ",
        };

        var ret = NetworkTools.Ping(input, options, default);

        Assert.That(ret.Output, Is.EqualTo(true));
    }
}
