using System;
using System.IO;
using Xunit;

namespace copy_config
{
    public class UnitTest1
    {
        [Fact]
        public void FileExists()
        {
            Assert.True(File.Exists("local.settings.json"));
        }
    }
}
