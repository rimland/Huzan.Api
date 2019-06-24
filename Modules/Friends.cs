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
    /// 好友基础接口
    /// </summary>
    public class Friends
    {
        //https://open-doc.51zan.com/web/#/2?page_id=38
        /// <summary>
        /// 获取指定微信号的好友列表, 获取牛客服微信号下的好友列表
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sourceId">牛客服微信id</param>
        /// <param name="offset">起始记录数，默认是0</param>
        /// <param name="limit">获取记录数，默认是1</param>
        /// <param name="update_time">更新起始时间戳,单位秒</param>
        /// <returns></returns>
        public HuzanResponse<List<FriendInfo>> FriendList(string accessToken, int sourceId, long update_time, int offset, int limit)
        {
            var request = new RestRequest("sources/{source_id}/friends", Method.GET);
            request.AddUrlSegment("source_id", sourceId);
            request.AddParameter("update_time", update_time);
            if (offset > 0)
                request.AddParameter("offset", offset);
            if (limit > 0)
                request.AddParameter("limit", limit);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<List<FriendInfo>>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=39
        /// <summary>
        /// 获取好友详情
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sourceId">牛客服微信id</param>
        /// <param name="friendId">牛客服好友id</param>
        /// <returns></returns>
        public HuzanResponse<FriendInfo> FriendById(string accessToken, int sourceId, int friendId)
        {
            var request = new RestRequest("sources/{source_id}/friends/{friend_id}", Method.GET);
            request.AddUrlSegment("source_id", sourceId);
            request.AddUrlSegment("friend_id", friendId);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<FriendInfo>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=52
        /// <summary>
        /// 获取指定微信号下全部标签
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sourceId"></param>
        /// <returns></returns>
        public HuzanResponse<List<LabelInfo>> LabelList(string accessToken, int sourceId)
        {
            var request = new RestRequest("sources/{source_id}/labels", Method.GET);
            request.AddUrlSegment("source_id", sourceId);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<List<LabelInfo>>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=106
        /// <summary>
        /// 获取指定微信号的好友请求列表, 获取牛客服微信号下的好友请求列表
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sourceId">牛客服微信id</param>
        /// <param name="status">新的好友请求状态： -1-全部， 0-未通过， 1-已通过</param>
        /// <param name="offset">起始记录数，默认是0</param>
        /// <param name="limit">获取记录数，默认是10</param>
        /// <param name="update_time">单位:毫秒(例子:1548296537471) 根据时间去获取增量数据,从头开始默认是0, 需要增量获取则传入最后一次增量结果的最后一条数据的update_time字段</param>
        /// <returns></returns>
        public HuzanResponse<List<NewFriendsRequestInfo>> NewFriendsRequests(string accessToken, int sourceId,int status, long update_time, int offset, int limit)
        {
            var request = new RestRequest("sources/{source_id}/new_friends_requests", Method.GET);
            request.AddUrlSegment("source_id", sourceId);
            request.AddParameter("status", status);
            request.AddParameter("update_time", update_time);
            if (offset > 0)
                request.AddParameter("offset", offset);
            if (limit > 0)
                request.AddParameter("limit", limit);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<List<NewFriendsRequestInfo>>(request);
        }

    }
}
