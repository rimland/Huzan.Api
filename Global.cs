using Huzan.Api.Response;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api
{
/*
Access Token放在http头部里进行认证，POST请求没有特殊说明以json格式提交数据，请注意修改http请求头部信息：
Content-Type: application/json
Authorization: Bearer {{access_token}}
 */

    static class Global
    {
        /// <summary>
        /// api 根目录
        /// </summary>
        const string BaseUrl = "https://open-api.51zan.com/api/v2/";

        /// <summary>
        /// 获取请求路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetAipUrl(string path) => $"{BaseUrl}{path}";

        /// <summary>
        /// 获取 RestClient
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static RestClient GetRestClient() => new RestClient(BaseUrl);

        /// <summary>
        /// 获取 RestClient
        /// </summary>
        /// <param name="accessToken"> Access Token </param>
        /// <returns></returns>
        public static RestClient GetRestClient(string accessToken)
        {
            var client = new RestClient(BaseUrl);
            client.AddDefaultHeader("Authorization", "Bearer " + accessToken);
            return client;
        }

        public static HuzanResponse<T> Ext_Result<T>(this IRestResponse<HuzanResponse<T>> response)
        {
            if (response.IsSuccessful)
                return response.Ext_Succ();
            else
                return response.Ext_Err();
        }

        /// <summary>
        /// 执行请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static HuzanResponse<T> Ext_Execute<T>(this RestClient client, IRestRequest request) where T : new()
        {
            try
            {
                switch (request.Method)
                {
                    case Method.GET:
                        return client.Get<HuzanResponse<T>>(request).Ext_Result();
                    case Method.POST:
                        return client.Post<HuzanResponse<T>>(request).Ext_Result();
                    case Method.PUT:
                        return client.Put<HuzanResponse<T>>(request).Ext_Result();
                    case Method.DELETE:
                        return client.Delete<HuzanResponse<T>>(request).Ext_Result();
                    default:
                        return CreateErrResponse<T>($"不支持的 Method: {request.Method}");
                }
            }
            catch (Exception ex)
            {
                return CreateErrResponse<T>($"Message：{ex.Message}，StackTrace：{ex.StackTrace}");
            }
        }

        private static Lazy<JsonSerializer> jsonSerializer = new Lazy<JsonSerializer>(() => { return new JsonSerializer(); });
        private static HuzanResponse<T> Ext_Err<T>(this IRestResponse<HuzanResponse<T>> response)
        {
            switch (response.ResponseStatus)
            {
                case ResponseStatus.Completed:
                    var rsp = jsonSerializer.Value.Deserialize<HuzanResponse<T>>(response);
                    //return HuzanResponse.Err<T>($"code:{rsp.Meta.code}, message:{rsp.Meta.message}, Content:{response.Content}.");
                    return rsp;
                case ResponseStatus.None:
                case ResponseStatus.Error:
                case ResponseStatus.TimedOut:
                case ResponseStatus.Aborted:
                default:
                    //return HuzanResponse.Err<T>($"ResponseStatus:{response.ResponseStatus}, Content:{response.Content}.");
                    //return new HuzanResponse<T>() { Meta = new Meta() { code = -1, message = $"ResponseStatus:{response.ResponseStatus}, Content:{response.Content}." } };
                    return CreateErrResponse<T>($"ResponseStatus:{response.ResponseStatus}, Content:{response.Content}.");
            }
        }

        private static HuzanResponse<T> Ext_Succ<T>(this IRestResponse<HuzanResponse<T>> response)
        {
            return response.Data;
        }

        /// <summary>
        /// 创建代表错误返回对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        private static HuzanResponse<T> CreateErrResponse<T>(string errMsg)=> new HuzanResponse<T>() { Meta = new Meta() { Code = -1, Msg = errMsg } };
    }
}
