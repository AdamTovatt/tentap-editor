using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor.Models.RestBodies
{
    public class UploadExerciseBody
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int CourseId { get; set; }
        public int ModuleId { get; set; }
        public int TagId { get; set; }
        public int SourceId { get; set; }
        public string ExerciseImageData { get; set; }
        public string SolutionImageData { get; set; }

        public UploadExerciseBody(Image exerciseImage, Image solutionImage)
        {
            ExerciseImageData = exerciseImage.ToByteArray().ToBase64();
            SolutionImageData = solutionImage.ToByteArray().ToBase64();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
