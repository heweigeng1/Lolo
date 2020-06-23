using System;
using System.Collections.Generic;
using System.Text;

namespace Lolo.SMS.Core
{
    public class AuditLog
    {
        public enum EnumSmsType
        {
            VerificationCode,
            Marketing,
            SystemNotification,
            Customized
        }

        /// <summary>
        /// 服务商
        /// </summary>
        public string ServiceProvider { get; set; }

        /// <summary>
        /// 操作名
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// 类型(验证码,营销,系统信息,自定义信息)
        /// </summary>
        public EnumSmsType SmsType { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 响应正文
        /// </summary>
        public string ResponseBody { get; set; }
    }
}
