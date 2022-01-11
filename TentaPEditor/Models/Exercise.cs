using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor.Models
{
    public class Exercise
    {
        private const string noFetchErrorMessage = "An attempt to get exerciseImage was made without fetching the images for the exercise. Call Fetch() on the exercise first!";

        public int Id { get; set; }
        public int Number { get; set; }
        public float Score { get; set; }
        public string ExerciseImageUrl { get; set; }
        public string SolutionImageUrl { get; set; }
        public string ExerciseImageId { get; set; }
        public string SolutionImageId { get; set; }
        public Source Source { get; set; }

        public Image ExerciseImage { get { if (_exerciseImage == null) throw new Exception(noFetchErrorMessage); return _exerciseImage; } }
        private Image _exerciseImage = null;

        public Image SolutionImage { get { if (_solutionImage == null) throw new Exception(noFetchErrorMessage); return _solutionImage; } }
        private Image _solutionImage = null;

        public async Task FetchAsync()
        {
            try
            {
                _exerciseImage = await ApiHelper.GetImageAsync(ExerciseImageUrl);
            }
            catch
            {
                _exerciseImage = ImageHelper.GetErrorImage();
            }

            try
            {
                _solutionImage = await ApiHelper.GetImageAsync(SolutionImageUrl);
            }
            catch
            {
                _solutionImage = ImageHelper.GetErrorImage();
            }
        }

        public override string ToString()
        {
            return string.Format("{0}#{1} ({2})", Source.Date.ToShortDateString(), Number, Source.Author);
        }
    }
}
