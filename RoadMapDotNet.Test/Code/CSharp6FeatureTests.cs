using RoadMapDotNet.Code;
using Xunit;

namespace RoadMapDotNet.Test.Code
{
    public class CSharp6FeatureTests
    {
        [Fact]
        public void UsingStaticShouldWork()
        {
            var sut = new CSharp6Features();
            var result = sut.UsingStaticAbs(-3);
            Assert.Equal(result, 3);
        }

        [Fact]
        public void UsingAutoPropertyShouldWork()
        {
            var sut = new CSharp6Features();
            var result = sut.UsingAutoPropertyInitializer();
            Assert.Equal(result, 10);
        }

        [Fact]
        public void UsingFormattedStringShouldWork()
        {
            var sut = new CSharp6Features();
            var result = sut.UsingFormatedString("Daniel", 30);
            Assert.Equal(result, "Daniel is 30");
        }
    }
}
