using Huzan.Api.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Modules
{
    // https://open-doc.51zan.com/web/#/2?page_id=57
    /// <summary>
    /// 朋友圈接口
    /// </summary>
    public class Moments
    {
        /// <summary>
        /// 发朋友圈
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="momentInfo"></param>
        /// <returns></returns>
        public static HuzanResponse<MomentSendInfo> SendMsg(string accessToken, Request.Moment.AbstractMoment momentInfo)
        {
            var request = new RestRequest("moments", Method.POST);
            request.AddHeader("Content-Type", "application/json");

            request.AddJsonBody(momentInfo);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<MomentSendInfo>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=113
        /// <summary>
        /// 获取发圈任务
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="task_id">发圈任务编号 ，唯一标识。</param>
        /// <returns></returns>
        public HuzanResponse<List<MomentTaskResultInfo>> MomentTaskResult(string accessToken, string task_id)
        {
            var request = new RestRequest("moments/{task_id}/result", Method.GET);
            request.AddUrlSegment("task_id", task_id);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<List<MomentTaskResultInfo>>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=114
        /// <summary>
        /// 获取朋友圈详情
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="source_id">牛客服微信号ID</param>
        /// <param name="moment_id">朋友圈ID</param>
        /// <returns></returns>
        public HuzanResponse<MomentFullInfo> MomentById(string accessToken, string source_id, string moment_id)
        {
            var request = new RestRequest("sources/{source_id}/moments/{moment_id}", Method.GET);
            request.AddUrlSegment("source_id", source_id);
            request.AddUrlSegment("moment_id", moment_id);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<MomentFullInfo>(request);
        }
    }
}
