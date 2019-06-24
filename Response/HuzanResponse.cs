using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzan.Api.Response
{
    public class HuzanResponse
    {
        [DeserializeAs(Name = "meta")]
        public Meta Meta { get; set; }
        [DeserializeAs(Name = "pagination")]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSucc
        {
            get
            {
                if (Meta == null)
                    return false;
                else
                    return Meta.Code == 0;
            }
        }

        /// <summary>
        /// 是否有错
        /// </summary>
        public bool IsErr => !IsSucc;
    }

    public class HuzanResponse<T> : HuzanResponse
    {
        public T Data { get; set; }
    }

    [Serializable]
    public class Meta
    {
        /// <summary>
        /// 业务码, 0 为成功，其他为错误
        /// </summary>
        [DeserializeAs(Name = "code")]
        public int Code { get; set; }
        /// <summary>
        /// 错误信息，code 非 0 时有内容
        /// </summary>
        [DeserializeAs(Name = "message")]
        public string Msg { get; set; }

        public override string ToString()
        {
            return $"code:{Code}, message:{Msg}";
        }
    }

    /// <summary>
    /// 分页信息
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// 找到的总记录数
        /// </summary>
        public string rows_found { get; set; }
        /// <summary>
        /// 起始记录数
        /// </summary>
        public string offset { get; set; }
        /// <summary>
        /// 获取记录数
        /// </summary>
        public string limit { get; set; }
    }

}
