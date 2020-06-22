using Lolo.Utils.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lolo.Ali.OSS
{
    /// <summary>
    /// 默认从appsettings.json配置文件获取
    /// </summary>
    public class AppsettingsGetOssProfile : IGetOssProfile
    {

        public virtual OssProfile Get(string rootPath)
        {
            var root = AppConfigurations.Get(rootPath);
            return new OssProfile() { EndPoint = root["Oss:Endpoint"], ID = root["Oss:ID"], Secret = root["Oss:Secret"] };
        }
    }
}
