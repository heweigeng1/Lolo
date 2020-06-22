using System;
using System.Collections.Generic;
using System.Text;

namespace Lolo.Ali.OSS
{
    public class OssProfile : IAccessKey
    {
        public string EndPoint { get; set; }

        public string ID { get; set; }

        public string Secret { get; set; }

    }
}
