using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 用户所属商家id
        /// </summary>
        public int company_id { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 用户备注
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 是否有效
        /// </summary>
        public bool enabled { get; set; }
        /// <summary>
        /// 是否是主账号
        /// </summary>
        public bool is_creator { get; set; }
        /// <summary>
        /// 1：管理员，0：普通员工
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 创建时间（秒）
        /// </summary>
        public long create_time { get; set; }
    }
}
