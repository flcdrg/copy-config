using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace copy_config
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }
        
        [Fact]
        public void FileExists()
        {
            var files = Directory.GetFiles(".");

            foreach (var file in files)
            {
                _output.WriteLine(file);
            }

            Assert.True(File.Exists("local.settings.json"));
        }
    }
}
