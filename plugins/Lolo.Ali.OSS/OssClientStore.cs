using Aliyun.OSS;
using System;

namespace Lolo.Ali.OSS
{
    public class OssClientStore
    {

        public virtual OssClient DefaultOssClient(OssProfile ossProfile)
        {
            var client = new OssClient(ossProfile.EndPoint, ossProfile.ID, ossProfile.Secret);

            return client;
        }

    }
}
