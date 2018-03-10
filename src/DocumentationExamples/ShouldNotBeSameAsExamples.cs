using Xunit;
using Xunit.Abstractions;

namespace DocumentationExamples
{
    public class ShouldNotBeSameAsExamples
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ShouldNotBeSameAsExamples(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ShouldNotBeSameAs()
        {
            DocExampleWriter.Document(() =>
            {
                
            }, _testOutputHelper);
        }
    }
}