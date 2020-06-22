using Lolo.Utils.Configuration;
using Xunit;
using System;

namespace Lolo.Utils.Configuration.Tests
{
    public class AppConfigurationsTests
    {
        private readonly string path = AppContext.BaseDirectory.Split("bin")[0] + @"/Configuration";

        public AppConfigurationsTests()
        {
        }

        [Fact(DisplayName = "默认配置文件")]
        public void GetTest()
        {
            //Arrange

            //ACT
            var config = AppConfigurations.Get(path);

            //Assert 
            Assert.True(config["CashierVersion:Version"] == "0.9.0", "读取默认appsettings.json配置项,");
        }

        [Fact(DisplayName = "自定义配置文件")]
        public void GetTest1()
        {
            //Arrange

            //ACT
            var config = AppConfigurations.Get(path, "appsettings1.json");

            //Assert 
            Assert.True(config["CashierVersion:Version"] == "0.9.0", "读取自定义配置文件配置项");
        }

        [Fact(DisplayName = "多配置文件")]
        public void GetTest2()
        {
            //Arrange

            //ACT
            var config = AppConfigurations.Get(path, new string[] { "appsettings.json", "appsettings1.json" });
            //Assert 
            Assert.True(config["CashierVersion:Size"] == "1024", "多配置文件,测试不同项是否能读取");
            Assert.True(config["CashierVersion:Version"] == "0.9.0", "多配置文件,相同项取最后加载文件的值");
        }
    }
}