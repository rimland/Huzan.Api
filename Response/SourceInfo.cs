using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    /// <summary>
    /// 商家微信号
    /// </summary>
    public class SourceInfo
    {
        /// <summary>
        /// 牛客服微信id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 微信昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 原生微信ID
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 用户设置微信号
        /// </summary>
        public string alias { get; set; }
        /// <summary>
        /// 省份，外国的国家名称
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 注册手机号
        /// </summary>
        public string mobile { get; set; }
        /// <summary>
        /// 牛客服微信备注
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 性别，1男，2女，0未知
        /// </summary>
        public int sex { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 头像url
        /// </summary>
        public string head_img_url { get; set; }
        /// <summary>
        /// 创建时间，时间戳
        /// </summary>
        public long create_time { get; set; }
        /// <summary>
        /// 商家id
        /// </summary>
        public string company_id { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int user_id { get; set; }
        /// <summary>
        /// 二维码名片
        /// </summary>
        public string qrcode_url { get; set; }
        /// <summary>
        /// 手机设备号
        /// </summary>
        public string serialno { get; set; }
        /// <summary>
        /// 在线状态
        /// </summary>
        public bool im_online_status { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public long update_time { get; set; }
    }


}
