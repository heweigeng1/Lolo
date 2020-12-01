using System;
using Volo.Abp.Domain.Entities;

namespace Lolo.SMS
{
    /// <summary>
    /// 短信模版
    /// </summary>
    public class SMSTemplate: AggregateRoot<Guid>
    {
        public enum EnumTemplateType
        {

        }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public string Parameter { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
    }
}
