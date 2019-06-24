using Huzan.Api.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Modules
{
    /// <summary>
    /// 商家接口
    /// </summary>
    public class Users
    {
        // https://open-doc.51zan.com/web/#/2?page_id=110
        /// <summary>
        /// 通过用户id取用户信息接口
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        public HuzanResponse<UserInfo> UserById(string accessToken, int userId)
        {
            var request = new RestRequest("users/{id}", Method.GET);
            // replaces matching token in request.Resource
            request.AddUrlSegment("id", userId);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<UserInfo>(request);
        }

        // https://open-doc.51zan.com/web/#/2?page_id=70
        /// <summary>
        /// 获取认证用户信息，通过用户认证码访问授权用户信息接口，取得用户信息
        /// </summary>
        /// <param name="code">string 用户认证码，只能使用一次</param>
        /// <returns></returns>
        public HuzanResponse<UserAuthInfo> UserAuthInfo(string accessToken, string code)
        {
            var request = new RestRequest("users/info", Method.GET);
            request.AddParameter("code", code);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<UserAuthInfo>(request);
        }

    }

    
   

}
