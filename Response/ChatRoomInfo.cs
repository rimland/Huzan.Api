using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    /// <summary>
    /// 群信息
    /// </summary>
    public class ChatRoomInfo
    {
        /// <summary>
        /// 群id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 群用户名
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 创建时间戳, 单位:s
        /// </summary>
        public int create_time { get; set; }
        /// <summary>
        /// 更新时间戳, 单位:s
        /// </summary>
        public int update_time { get; set; }
        /// <summary>
        /// 群显示名
        /// </summary>
        public string display_name { get; set; }
        /// <summary>
        /// 群头像
        /// </summary>
        public string head_img_url { get; set; }
        /// <summary>
        /// 群成员个数
        /// </summary>
        public int member_count { get; set; }
        /// <summary>
        /// 群昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 群备注
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 验证标识，0未开启，2开启
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 群公告
        /// </summary>
        public ChatRoomNotice notice { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool is_delete { get; set; }
        /// <summary>
        /// 群主
        /// </summary>
        public ChatRoomOwner owner { get; set; }
        /// <summary>
        /// 牛客服微信号ID
        /// </summary>
        public string source_id { get; set; }        
    }

    /// <summary>
    /// 群公告
    /// </summary>
    public class ChatRoomNotice
    {
        /// <summary>
        /// 群公告内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 群公告发布者信息
        /// </summary>
        public NoticeEditor editor { get; set; }
        /// <summary>
        /// 群公告发布时间
        /// </summary>
        public int publish_time { get; set; }
    }

    /// <summary>
    /// 群公告发布者信息
    /// </summary>
    public class NoticeEditor
    {
        /// <summary>
        /// 群公告发布者群内昵称
        /// </summary>
        public string display_name { get; set; }
        /// <summary>
        /// 群公告发布者头像
        /// </summary>
        public string head_img_url { get; set; }
        /// <summary>
        /// 群公告发布者成员ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 群公告发布者昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 群主备注
        /// </summary>
        public string remark_name { get; set; }
        /// <summary>
        /// 群公告发布者微信号
        /// </summary>
        public string username { get; set; }
    }

    /// <summary>
    /// 群主
    /// </summary>
    public class ChatRoomOwner
    {
        /// <summary>
        /// 群主群内昵称
        /// </summary>
        public string display_name { get; set; }
        /// <summary>
        /// 群主头像
        /// </summary>
        public string head_img_url { get; set; }
        /// <summary>
        /// 群主成员ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 群主昵称
        /// </summary>
        public string nickname { get; set; }

        public string remark_name { get; set; }
        /// <summary>
        /// 群主微信号
        /// </summary>
        public string username { get; set; }
    }
}
