using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor
{
    public class Exercise
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("problemImageData")]
        public string ProblemImageData { get { return ProblemImage.GetBase64String(); } }

        [JsonProperty("solutionImageData")]
        public string SolutionImageData { get { return SolutionImage.GetBase64String(); } }

        [JsonIgnore]
        public Bitmap ProblemImage { get; set; }
        
        [JsonIgnore]
        public Bitmap SolutionImage { get; set; }

        public Exercise() { }

        public Exercise(int id)
        {
            Id = id;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
