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
    /// 群接口
    /// </summary>
    public class ChatRoom
    {
        //https://open-doc.51zan.com/web/#/2?page_id=53
        /// <summary>
        /// 获取指定群的群成员列表
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sourceId">牛客服微信id</param>
        /// <param name="chatroom_id">牛客服群id</param>
        /// <returns></returns>
        public HuzanResponse<List<ChatRoomMemberInfo>> MemberList(string accessToken, int sourceId, int chatroom_id)
        {
            var request = new RestRequest("sources/{source_id}/chatrooms/{chatroom_id}/members", Method.GET);
            request.AddUrlSegment("source_id", sourceId);
            request.AddUrlSegment("chatroom_id", chatroom_id);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<List<ChatRoomMemberInfo>>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=54
        /// <summary>
        /// 获取指定微信号的群列表
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sourceId">牛客服微信号ID</param>
        /// <param name="update_time">更新时间戳, 10位，单位:s，获取更新时间戳之后的数据</param>
        /// <param name="offset">开始记录数， 默认0</param>
        /// <param name="limit">获取记录数，默认10</param>
        /// <returns></returns>
        public HuzanResponse<List<ChatRoomInfo>> ChatRoomList(string accessToken, int sourceId, long update_time, int offset, int limit)
        {
            var request = new RestRequest("sources/{source_id}/chatrooms", Method.GET);
            request.AddUrlSegment("source_id", sourceId);
            request.AddParameter("update_time", update_time);
            if (offset > 0)
                request.AddParameter("offset", offset);
            if (limit > 0)
                request.AddParameter("limit", limit);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<List<ChatRoomInfo>>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=55
        /// <summary>
        /// 获取群详情
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sourceId">牛客服微信id</param>
        /// <param name="chatroom_id">牛客服群id</param>
        /// <returns></returns>
        public HuzanResponse<ChatRoomInfo> ChatRoomById(string accessToken, int sourceId, int chatroom_id)
        {
            var request = new RestRequest("sources/{source_id}/chatrooms/{chatroom_id}", Method.GET);
            request.AddUrlSegment("source_id", sourceId);
            request.AddUrlSegment("chatroom_id", chatroom_id);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<ChatRoomInfo>(request);
        }
    }
}
