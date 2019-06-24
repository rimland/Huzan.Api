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
    /// 接口应用接入
    /// </summary>
    public class Authorize
    {
        //https://open-doc.51zan.com/web/#/2?page_id=67
        /// <summary>
        /// 生成授权链接，跳转到授权页面，商家管理员点击授权后，跳转到回调地址redirect_uri，并把预授权码（pre_auth_code）回传给回调页面
        /// </summary>
        /// <param name="app_id">应用AppID</param>
        /// <param name="redirect_uri">回调URL</param>
        /// <param name="state">用于第三方应用防止CSRF攻击，成功授权后回调时会原样带回</param>
        /// <returns></returns>
        public Uri GetAuthorizeUri(string app_id, string redirect_uri, string state)
        {
            var restClient = new RestClient("https://open.51zan.com/oauth2/company_authorize");

            RestRequest request = new RestRequest(Method.GET);
            request.AddParameter("app_id", app_id);
            request.AddParameter("redirect_uri", redirect_uri);
            request.AddParameter("state", state);

            return restClient.BuildUri(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=68
        /// <summary>
        /// 获取永久授权码， 通过授权页面返回的预授权码取得永久授权码
        /// </summary>
        /// <param name="app_id">string	申请应用时分配的AppID</param>
        /// <param name="app_secret">string	申请应用时分配的AppKey</param>
        /// <param name="pre_auth_code">string	预授权码</param>
        public HuzanResponse<PermanentCodeInfo> PermanentCode(string app_id, string app_secret, string pre_auth_code)
        {
            var obj = new {
                app_id,
                app_secret,
                pre_auth_code
            };

            var client = Global.GetRestClient();
            var request = new RestRequest("permanent_code", Method.POST);
            request.AddHeader("Content-Type", "application/json");

            request.AddJsonBody(obj);

            //var response = client.Post<PermanentCodeRspInfo>(request);
            //return response.Ext_Result();

            return client.Ext_Execute<PermanentCodeInfo>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=69
        /// <summary>
        /// 获取访问令牌, 通过永久授权码换取访问令牌Access Token
        /// </summary>
        /// <param name="app_id">string	申请应用时分配的AppID。</param>
        /// <param name="app_secret">string	申请应用时分配的AppKey</param>
        /// <param name="permanent_code">string	永久授权码</param>
        /// <returns></returns>
        public HuzanResponse<AccessTokenInfo> AccessToken(string app_id, string app_secret, string permanent_code)
        {
            var obj = new
            {
                grant_type = "client_credentials", //此值固定为“client_credentials”。
                app_id,
                app_secret,
                permanent_code
            };
            
            var request = new RestRequest("access_token", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(obj);

            var client = Global.GetRestClient();
            return client.Ext_Execute<AccessTokenInfo>(request);
        }
    }
}
