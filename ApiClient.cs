using Huzan.Api.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api
{
    public class ApiClient
    {
        ///// <summary>
        ///// 申请应用时分配的AppID
        ///// </summary>
        //internal static string AppId;
        ///// <summary>
        ///// 申请应用时分配的AppKey
        ///// </summary>
        //internal static string AppSecret;

        ///// <summary>
        ///// 初始化对象
        ///// </summary>
        ///// <param name="appId">申请应用时分配的AppID。</param>
        ///// <param name="appSecret">申请应用时分配的AppKey。</param>
        //public ApiClient(string appId, string appSecret)
        //{
        //    AppId = appId;
        //    AppSecret = appSecret;
        //}

        private Lazy<Authorize> lazyAuthorize = new Lazy<Authorize>(() => { return new Authorize(); });
        /// <summary>
        /// 应用授权相关接口
        /// </summary>
        public Authorize Authorize { get { return lazyAuthorize.Value; } }
        
        private Lazy<ChatRoom> lazyChatRoom = new Lazy<ChatRoom>(() => { return new ChatRoom(); });
        /// <summary>
        /// 群接口
        /// </summary>
        public ChatRoom ChatRoom { get { return lazyChatRoom.Value; } }

        private Lazy<FriendMessages> lazyFriendMessages = new Lazy<FriendMessages>(() => { return new FriendMessages(); });
        /// <summary>
        /// 好友消息接口
        /// </summary>
        public FriendMessages FriendMessages { get { return lazyFriendMessages.Value; } }

        private Lazy<Friends> lazyFriends = new Lazy<Friends>(() => { return new Friends(); });
        /// <summary>
        /// 好友基础接口
        /// </summary>
        public Friends Friends { get { return lazyFriends.Value; } }

        private Lazy<Moments> lazyMoments = new Lazy<Moments>(() => { return new Moments(); });
        /// <summary>
        /// 朋友圈接口
        /// </summary>
        public Moments Moments { get { return lazyMoments.Value; } }

        private Lazy<Source> lazySource = new Lazy<Source>(() => { return new Source(); });
        /// <summary>
        /// 微信号接口
        /// </summary>
        public Source Source { get { return lazySource.Value; } }

        private Lazy<Users> lazyUsers = new Lazy<Users>(() => { return new Users(); });
        /// <summary>
        /// 商家接口
        /// </summary>
        public Users Users { get { return lazyUsers.Value; } }
    }
}
