using Huzan.Api.Request.FriendMessage;
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
    /// 好友消息接口
    /// </summary>
    public class FriendMessages
    {
        //https://open-doc.51zan.com/web/#/2?page_id=107
        /// <summary>
        /// 指令型接口-通过指定的好友请求, 指令型接口-通过指定新的好友
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="sourceId">牛客服微信id</param>
        /// <param name="target_friend_id">需要通过的好友id ,从获取新的好友请求里返回</param>
        /// <returns></returns>
        public HuzanResponse<ConfirmNewFriendInfo> ConfirmNewFriend(string accessToken, int sourceId, string target_friend_id)
        {
            var request = new RestRequest("sources/{source_id}/confirm_new_friend", Method.POST);
            request.AddUrlSegment("source_id", sourceId);
            request.AddQueryParameter("target_friend_id", target_friend_id);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<ConfirmNewFriendInfo>(request);
        }

        //https://open-doc.51zan.com/web/#/2?page_id=46
        /// <summary>
        /// 指令型接口-发送好友消息
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="friendMessageInfo">发送的消息</param>
        /// <returns></returns>
        public HuzanResponse<FriendMessageInfo> SendMsg(string accessToken, FriendMessageRequstModel friendMessageInfo)
        {
            var request = new RestRequest("friend_messages", Method.POST);
            request.AddHeader("Content-Type", "application/json");

            request.AddJsonBody(friendMessageInfo);

            var client = Global.GetRestClient(accessToken);
            return client.Ext_Execute<FriendMessageInfo>(request);
        }
    }
}
