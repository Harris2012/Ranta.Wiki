using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.Wiki.Vo
{
    /// <summary>
    /// 博客
    /// </summary>
    public class BlogVo
    {
        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
