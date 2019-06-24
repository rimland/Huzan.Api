using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    /// <summary>
    /// 发朋友圈 返回信息
    /// </summary>
    public class MomentSendInfo
    {
        /// <summary>
        /// 发圈任务编号 ，唯一标识。
        /// </summary>
        public string task_id { get; set; }
    }
}
