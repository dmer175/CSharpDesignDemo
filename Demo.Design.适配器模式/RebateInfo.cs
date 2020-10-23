using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Design.适配器模式
{
    public class RebateInfo
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string userId { get; set; }
        /// <summary>
        /// 业务ID
        /// </summary>
        public string bizId { get; set; }
        /// <summary>
        /// 业务时间
        /// </summary>
        public DateTime bizTime { get; set; }
        /// <summary>
        /// 业务描述
        /// </summary>
        public string desc { get; set; }
    }
}
