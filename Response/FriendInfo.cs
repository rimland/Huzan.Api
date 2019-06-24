using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    /// <summary>
    /// 好友信息
    /// </summary>
    public class FriendInfo
    {
        /// <summary>
        /// 牛客服好友id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 牛客服微信id
        /// </summary>
        public string source_id { get; set; }
        /// <summary>
        /// 好友头像
        /// </summary>
        public string head_img_url { get; set; }
        /// <summary>
        /// 用户设置微信号
        /// </summary>
        public string alias { get; set; }
        /// <summary>
        /// 原生微信id
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 好友昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 好友微信备注
        /// </summary>
        public string remark_name { get; set; }
        /// <summary>
        /// 微信标签
        /// </summary>
        public string[] labels { get; set; }
        /// <summary>
        /// 添加方式
        /// </summary>
        public AddFrom add_from { get; set; }
        /// <summary>
        /// 是否被删除
        /// </summary>
        public bool is_block { get; set; }
        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool is_delete { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public long update_time { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public long create_time { get; set; }
        /// <summary>
        /// 省份，外国的国家名称
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 性别，1男，2女，0未知
        /// </summary>
        public int sex { get; set; }
    }

    /// <summary>
    /// 添加方式
    /// </summary>
    public class AddFrom
    {
        /// <summary>
        /// 添加方式id
        /// </summary>
        public int key { get; set; }
        /// <summary>
        /// 添加方式描述
        /// </summary>
        public string value { get; set; }
    }
}
