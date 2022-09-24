using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor
{
    public class StartArguments
    {
        [JsonProperty("apiUrl")]
        public string ApiUrl { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("exerciseId")]
        public int ExerciseId { get; set; }

        public static StartArguments FromJson(string json)
        {
            return JsonConvert.DeserializeObject<StartArguments>(json);
        }
    }
}
