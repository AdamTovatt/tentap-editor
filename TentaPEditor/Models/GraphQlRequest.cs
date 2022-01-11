using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor.Models
{
    public class GraphQlRequest
    {
        [JsonProperty("operationName")]
        public string OperationName { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("variables")]
        public object Variables { get; set; }

        public GraphQlRequest(string query)
        {
            Query = query;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
