using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Request.FriendMessage
{
    /// <summary>
    /// 指令型接口-发送好友消息，发送的消息对象 
    /// </summary>
    public class FriendMessageRequstModel
    {
        /// <summary>
        /// 牛客服微信id
        /// </summary>
        public string source_id { get; set; }
        /// <summary>
        /// 牛客服好友id
        /// </summary>
        public string friend_id { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public AbstractMsg content { get; set; }
    }

    public abstract class AbstractMsg
    {
        /// <summary>
        /// 消息类型标识
        /// </summary>
        public int type { get; protected set; }
    }

    /// <summary>
    /// 文本消息
    /// </summary>
    public class TextMsg : AbstractMsg
    {
        public TextMsg()
        {
            type = 1; //文本消息，必需
        }

        /// <summary>
        /// 消息内容，必需
        /// </summary>
        public string text { get; set; }
    }

    /// <summary>
    /// 图片消息
    /// </summary>
    public class ImageMsg : AbstractMsg
    {
        public ImageMsg()
        {
            type = 2; //图片，必需
        }

        /// <summary>
        /// 1:静态图，2：动态图
        /// </summary>
        public int image_type { get; set; }
        /// <summary>
        /// 图片url，必需
        /// </summary>
        public string media_url { get; set; }
        /// <summary>
        /// 缩略图url，必需
        /// </summary>
        public string thumb_url { get; set; }
    }

    /// <summary>
    /// 视频消息
    /// </summary>
    public class VideoMsg : AbstractMsg
    {
        public VideoMsg()
        {
            type = 3; //视频，必需
        }

        /// <summary>
        /// 视频url，必需
        /// </summary>
        public string media_url { get; set; }
        /// <summary>
        /// 缩略图url，必需
        /// </summary>
        public string thumb_url { get; set; }

        /// <summary>
        /// 视频时长, 秒
        /// </summary>
        public int duration { get; set; }
    }

    /// <summary>
    /// 文件消息
    /// </summary>
    public class AttachMsg : AbstractMsg
    {
        public AttachMsg()
        {
            type = 4; //文件，必需
        }

        /// <summary>
        /// 文件url，必需
        /// </summary>
        public string media_url { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string title { get; set; }
    }

    /// <summary>
    /// 网页消息
    /// </summary>
    public class UrlMsg : AbstractMsg
    {
        public UrlMsg()
        {
            type = 6; //网页，必需
        }

        /// <summary>
        /// 页面url，必需
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 图标url
        /// </summary>
        public string thumb_url { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }
    }

    /// <summary>
    /// 小程序消息
    /// </summary>
    public class MiniProgramMsg : AbstractMsg
    {
        public MiniProgramMsg()
        {
            type = 7; //7：小程序，必需
        }

        /// <summary>
        /// 小程序id，必需
        /// </summary>
        public string mini_program_id { get; set; }
        /// <summary>
        /// 缩略图，必需
        /// </summary>
        public string thumb_url { get; set; }
        /// <summary>
        /// 标题，必需
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 描述，必需
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 小程序页面路径，必需
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// 网页链接, 无法打开的小程序，将会跳转到这个 url 链接上
        /// </summary>
        public string web_page_url { get; set; }
    }

    /// <summary>
    /// 公众号名片消息
    /// </summary>
    public class OpenCardMsg : AbstractMsg
    {
        public OpenCardMsg()
        {
            type = 9; //9：公众号名片，必需
        }

        /// <summary>
        /// 公众号，必需
        /// </summary>
        public string card_username { get; set; }
    }

}
