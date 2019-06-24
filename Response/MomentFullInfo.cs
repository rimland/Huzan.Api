using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    /// <summary>
    /// 朋友圈详情
    /// </summary>
    public class MomentFullInfo
    {
        /// <summary>
        /// 作者对象
        /// </summary>
        public MomentAuthor author { get; set; }
        /// <summary>
        /// 扩展对象
        /// </summary>
        public MomentBody body { get; set; }
        /// <summary>
        /// 评论对象列表
        /// </summary>
        public List<MomentComment> comments { get; set; }
        /// <summary>
        /// 朋友圈内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 创建时间戳，单位秒
        /// </summary>
        public int create_time { get; set; }
        /// <summary>
        /// 朋友圈ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 点赞对象列表
        /// </summary>
        public List<MomentLike> likes { get; set; }
        /// <summary>
        /// 媒体对象列表
        /// </summary>
        public MomentMedia[] media_list { get; set; }
        /// <summary>
        /// 牛客服微信号ID
        /// </summary>
        public string source_id { get; set; }
        /// <summary>
        /// 类型,1 图文,2 文字,3 文章, 4 音乐, 5 视频(视频网站的视频), 8 表情，10表情商店，13 卡包， 15 小视频（微信拍的小视频），17 QQ原创馆，26 笔记
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool is_delete { get; set; }

        /// <summary>
        /// 是否发送者
        /// </summary>
        public bool is_send { get; set; }
    }

    /// <summary>
    /// 作者对象
    /// </summary>
    public class MomentAuthor
    {
        /// <summary>
        /// 作者微信号
        /// </summary>
        public string alias { get; set; }
        /// <summary>
        /// 作者头像
        /// </summary>
        public string head_img_url { get; set; }
        /// <summary>
        /// 作者好友ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 作者昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 作者好友备注
        /// </summary>
        public string remark_name { get; set; }
        /// <summary>
        /// 作者微信用户名
        /// </summary>
        public string username { get; set; }
    }

    /// <summary>
    /// 扩展对象
    /// </summary>
    public class MomentBody
    {
        /// <summary>
        /// 分享来源
        /// </summary>
        public string source { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 文章URL或者文章副标题，判断非http开头为文章副标题
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 文章URL,url是副标题时使用
        /// </summary>
        public string url2 { get; set; }
    }

    public class MomentComment
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 评论创建时间戳
        /// </summary>
        public int create_time { get; set; }
        /// <summary>
        /// 评论者头像URL
        /// </summary>
        public string head_img_url { get; set; }
        /// <summary>
        /// 评论ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 评论者是否作者
        /// </summary>
        public bool is_author { get; set; }
        /// <summary>
        /// 评论者昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 评论者备注
        /// </summary>
        public string remark_name { get; set; }
        /// <summary>
        /// 评论回复头像URL
        /// </summary>
        public string to_head_img_url { get; set; }
        /// <summary>
        /// 评论回复昵称
        /// </summary>
        public object to_nickname { get; set; }
        /// <summary>
        /// 评论回复备注
        /// </summary>
        public string to_remark_name { get; set; }
        /// <summary>
        /// 评论回复微信用户名
        /// </summary>
        public object to_username { get; set; }
        /// <summary>
        /// 评论者微信用户名
        /// </summary>
        public string username { get; set; }
    }

    /// <summary>
    /// 点赞对象
    /// </summary>
    public class MomentLike
    {
        /// <summary>
        /// 评论创建时间戳
        /// </summary>
        public int create_time { get; set; }
        /// <summary>
        /// 评论者头像URL
        /// </summary>
        public string head_img_url { get; set; }
        /// <summary>
        /// 评论者是否作者
        /// </summary>
        public bool is_author { get; set; }
        /// <summary>
        /// 评论者昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 评论者备注
        /// </summary>
        public string remark_name { get; set; }
        /// <summary>
        /// 评论者微信用户名
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 评论ID
        /// </summary>
        public int id { get; set; }
    }

    /// <summary>
    /// 媒体对象
    /// </summary>
    public class MomentMedia
    {
        /// <summary>
        /// 媒体ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 缩略图
        /// </summary>
        public string thumb_url { get; set; }
        /// <summary>
        /// 媒体URL
        /// </summary>
        public string url { get; set; }
    }

}
