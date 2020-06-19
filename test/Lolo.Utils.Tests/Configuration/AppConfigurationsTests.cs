using Xunit;
using Lolo.Utils.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Lolo.Utils.Configuration.Tests
{
    public class AppConfigurationsTests
    {
        public AppConfigurationsTests()
        {
        }

        [Fact()]
        public void GetTest()
        {
            //Arrange
            string path= AppContext.BaseDirectory.Split("bin")[0];

            //ACT
            var config = AppConfigurations.Get(path);

            //Assert 
            Assert.True(config["CashierVersion:Version"]== "0.9.0", "This test needs an implementation");
        }
    }
}