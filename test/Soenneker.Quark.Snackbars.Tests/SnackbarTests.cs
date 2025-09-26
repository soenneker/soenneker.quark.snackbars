using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Snackbars.Tests;

[Collection("Collection")]
public sealed class SnackbarTests : FixturedUnitTest
{
    public SnackbarTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
