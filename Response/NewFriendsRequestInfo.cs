using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    public class NewFriendsRequestInfo
    {
        /// <summary>
        /// 混淆后的好友id,可以用于指令通过好友
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 微信号的昵称
        /// </summary>
        public string content_nickname { get; set; }
        /// <summary>
        /// 新的好友打招呼内容
        /// </summary>
        public string content_verify_content { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string head_img_url { get; set; }
        /// <summary>
        /// 信息的最晚修改时间
        /// </summary>
        public long update_time { get; set; }
        /// <summary>
        /// 0-未通过 1-已通过
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 打招呼微信号
        /// </summary>
        public string username { get; set; }
    }


}
