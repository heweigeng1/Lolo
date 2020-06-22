using System;
using System.Collections.Generic;
using System.Text;

namespace Lolo.Ali.OSS
{
    public interface IAccessKey
    {
        string ID { get; set; }
        string Secret { get; set; }
    }
}
