using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor.Models.RestResponses
{
    public class UploadExerciseResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("mode")]
        public string Mode { get; set; }

        public UploadExerciseResponse() { }

        public static UploadExerciseResponse FromJson(string json)
        {
            return JsonConvert.DeserializeObject<UploadExerciseResponse>(json);
        }
    }
}
