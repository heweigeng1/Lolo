using System;
using System.Collections.Generic;
using System.Text;

namespace Lolo.Ali.OSS
{
    public interface IGetOssProfile
    {
        OssProfile Get(string rootPath);
    }
}
