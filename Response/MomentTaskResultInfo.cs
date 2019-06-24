using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    public class MomentTaskResultInfo
    {
        /// <summary>
        /// 微信号。
        /// </summary>
        public string source_id { get; set; }
        /// <summary>
        /// 执行状态
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 执行结果码，执行结束后返回此值
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 朋友圈id，发圈成功后返回此值。
        /// </summary>
        public string moment_id { get; set; }
    }
}
