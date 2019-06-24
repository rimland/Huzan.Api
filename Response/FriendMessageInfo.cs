using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    /// <summary>
    /// 指令型接口-发送消息给好友 返回结果
    /// </summary>
    public class FriendMessageInfo
    {
        /// <summary>
        /// 回执消息id,需要开发者持久化后用于消息查询
        /// </summary>
        public string uuid { get; set; }
    }
}
