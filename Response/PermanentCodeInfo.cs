using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    public class PermanentCodeInfo
    {
        /// <summary>
        /// 永久授权码
        /// </summary>
        public string permanent_code { get; set; }
        /// <summary>
        /// 授权商家ID
        /// </summary>
        public int company_id { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string company_name { get; set; }
    }

}
