using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    /// <summary>
    /// 群成员信息
    /// </summary>
    public class ChatRoomMemberInfo
    {
        /// <summary>
        /// 成员微信号
        /// </summary>
        public string alias { get; set; }
        /// <summary>
        /// 牛客服群ID
        /// </summary>
        public string chatroom_id { get; set; }
        /// <summary>
        /// 群用户名
        /// </summary>
        public string chatroom_username { get; set; }
        /// <summary>
        /// 群内昵称
        /// </summary>
        public string display_name { get; set; }
        /// <summary>
        /// 成员头像
        /// </summary>
        public string head_img_url { get; set; }
        /// <summary>
        /// 成员ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 是否是管理员
        /// </summary>
        public bool is_admin { get; set; }
        /// <summary>
        /// 是否是群主
        /// </summary>
        public bool is_owner { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark_name { get; set; }
        /// <summary>
        /// 牛客服微信号ID
        /// </summary>
        public string source_id { get; set; }
        /// <summary>
        /// 成员微信用户名
        /// </summary>
        public string username { get; set; }
    }
}
