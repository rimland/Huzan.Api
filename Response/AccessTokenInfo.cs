using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    public class AccessTokenInfo
    {
        /// <summary>
        /// string	授权令牌，Access Token
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// string	应用AppID
        /// </summary>
        public string app_id { get; set; }
        /// <summary>
        /// string	商家ID
        /// </summary>
        public int company_id { get; set; }
        /// <summary>
        /// int	该Access Token的有效期，单位为秒。
        /// </summary>
        public int expires_in { get; set; }
    }

}
