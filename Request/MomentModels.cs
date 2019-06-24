using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Request.Moment
{
    //参考 https://open-doc.51zan.com/web/#/2?page_id=57

    /// <summary>
    /// 朋友圈消息
    /// </summary>
    public abstract class AbstractMoment
    {
        /// <summary>
        /// 必填，内容类型, ‘article’：文章，’photo’：图文，’video’：视频, ‘text’:文本
        /// </summary>
        public string content_type { get; protected set; }

        /// <summary>
        /// 必填，微信号ID列表
        /// </summary>
        public List<string> source_ids { get; set; }

        /// <summary>
        /// 可选，可见范围：0-所有人可见，1-仅自己可见，2-部分可见，3-不给谁看，默认为0，目前仅支持所有人可见。
        /// </summary>
        public int visible_range { get; set; } = 0;

        /// <summary>
        /// 可选，评论列表，单条评论限制200字以内。最多十条。
        /// </summary>
        public List<string> content_comments { get; set; }

        /// <summary>
        /// 可选，执行时间，默认为立即执行。时间格式为：YYYY-MM-DD H:i:s。 执行时间需要大于当前时间。   示例：2019-07-14 12:00:00
        /// </summary>
        public string execute_time { get; private set; }
        /// <summary>
        /// 设置执行时间
        /// </summary>
        public DateTime ExecuteTime
        {
            set
            {
                if (value.Year > 2000)
                    execute_time = value.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        /// <summary>
        /// url列表；content_type为’article’时，为文章地址,仅支持一篇文章地址，此参数必填，content_type为’photo’时，为图片地址，可支持多张图片地址，最多9张图，此参数必填，content_type为’video’时，为视频地址, 仅支持一个视频地址，此参数必填
        /// </summary>
        public string[] media_urls { get; protected set; }
    }

    /// <summary>
    /// 文本朋友圈
    /// </summary>
    public class TextMoment : AbstractMoment
    {
        public TextMoment()
        {
            content_type = "text"; //文本消息，必需
        }

        /// <summary>
        /// 必填，内容，限制1500字以内，content_type为’text’时，此参数必填
        /// </summary>
        public string content { get; set; }
    }

    /// <summary>
    /// 文章朋友圈
    /// </summary>
    public class ArticleMoment : AbstractMoment
    {
        public ArticleMoment()
        {
            content_type = "article"; //文章消息，必需
        }

        /// <summary>
        /// 可选，内容，content_type为’text’时，此参数必填。 示例： "这文章不错，大家转发起来"
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 必填，封面，content_type为’article’时，此参数必填
        /// </summary>
        public string cover { get; set; }

        /// <summary>
        /// 必填，标题，content_type为’article’时，此参数必填 ，长度不超过40字。
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 设置文章地址
        /// </summary>
        public string ArticleUrl
        {
            set
            {
                media_urls = null;
                if (!string.IsNullOrWhiteSpace(value))
                    media_urls = new[] { value };
            }
        }
    }

    /// <summary>
    /// 图文朋友圈
    /// </summary>
    public class PhotoMoment : AbstractMoment
    {
        public PhotoMoment()
        {
            content_type = "photo"; //图文消息，必需
        }

        /// <summary>
        /// 可选，内容，content_type为’text’时，此参数必填。 示例： "这组图片不错，哈哈哈"
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 必填，设置图片地址，可支持多张图片地址，最多9张图，此参数必填
        /// </summary>
        public List<string> PhotoUrls
        {
            set
            {
                media_urls = null;
                if (value?.Count > 0)
                    media_urls = value.ToArray();
            }
        }
    }

    /// <summary>
    /// 视频朋友圈
    /// </summary>
    public class VideoMoment : AbstractMoment
    {
        public VideoMoment()
        {
            content_type = "video"; //视频消息，必需
        }

        /// <summary>
        /// 可选，内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 必填，设置视频 Url
        /// </summary>
        public string VideoUrl
        {
            set
            {
                media_urls = null;
                if (!string.IsNullOrWhiteSpace(value))
                    media_urls = new[] { value };
            }
        }
    }
}
