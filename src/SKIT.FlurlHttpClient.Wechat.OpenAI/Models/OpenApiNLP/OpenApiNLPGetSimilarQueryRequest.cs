﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/nlp/get_similar_query/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class OpenApiNLPGetSimilarQueryRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedUrlEncodedFormData
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置输入文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string QueryString { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid")]
        [System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = new Types.Data();
}
}
