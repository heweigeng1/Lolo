using System;
using System.Collections.Generic;
using System.Text;

namespace Lolo.SMS
{
    /// <summary>
    /// 短信模版
    /// </summary>
    public class SMSTemplate
    {
        public enum EnumTemplateType
        {

        }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public string Parameter { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
    }
}
