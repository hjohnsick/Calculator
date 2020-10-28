using Xunit;
using Practice;
using System.IO;

namespace Practice.Tests
{
    public class ExamplesTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("This is a vaild file name");

            Assert.True(actual.Length > 10);
        }

        [Fact]
        public void ExampleLoadTextFile_InValidNameShouldFail()
        {
            Assert.Throws<FileNotFoundException>(() => Examples.ExampleLoadTextFile(""));
        }
    }
}
