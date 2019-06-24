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
    /// 微信号接口
    /// </summary>
    public class Source
    {
        //https://open-doc.51zan.com/web/#/2?page_id=35
        /// <summary>
        /// 获取商家微信号列表, 获取商家下的微信列表
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="offset">起始记录数，默认是0</param>
        /// <param name="limit">获取记录数，默认是1</param>
        /// <returns></returns>

        public HuzanResponse<List<SourceInfo>> SourceList(string accessToken, int offset, int limit)
        {
            var request = new RestRequest("sources", Method.GET);
            request.AddParameter("offset", offset);
            request.AddParameter("limit", limit);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<List<SourceInfo>>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=36
        /// <summary>
        /// 获取微信号详情，通过牛客服微信id获取微信详情
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sourceId">牛客服微信id</param>
        /// <returns></returns>
        public HuzanResponse<SourceInfo> SourceById(string accessToken, int sourceId)
        {
            var request = new RestRequest("sources/{source_id}", Method.GET);
            // replaces matching token in request.Resource
            request.AddUrlSegment("source_id", sourceId);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<SourceInfo>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=105
        /// <summary>
        /// 查询微信号在线状态，通过牛客服微信id获取牛客服是否在线
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sourceId"></param>
        /// <returns></returns>
        public HuzanResponse<OnlineStatusInfo> OnlineStatus(string accessToken, int sourceId)
        {
            var request = new RestRequest("sources/{source_id}/online_status", Method.GET);
            // replaces matching token in request.Resource
            request.AddUrlSegment("source_id", sourceId);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<OnlineStatusInfo>(request);
        }

    }
}
