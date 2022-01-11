using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TentaPEditor.Models;
using TentaPEditor.Models.GraphQlResponses;
using TentaPEditor.Models.RestBodies;
using TentaPEditor.Models.RestResponses;

namespace TentaPEditor
{
    public class ApiHelper
    {
        //private const string apiBaseUrl = "https://localhost:5001/";
        private const string apiBaseUrl = "https://tentap.herokuapp.com/";
        private static string graphQlUrl { get { return string.Format("{0}graphql", apiBaseUrl); } }

        private static readonly HttpClient httpClient = new HttpClient();

        public async static Task<HttpResponseMessage> PostRequestAsync(string url, string body)
        {
            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(new Uri(url), content);
            return response;
        }

        public async static Task<List<Course>> GetAllCoursesAsync()
        {
            string query = @"{courses{id name modules{id name}debugInfo}}";
            HttpResponseMessage response = await PostRequestAsync(graphQlUrl, new GraphQlRequest(query).ToJson());

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                CoursesResponse coursesResponse = JsonConvert.DeserializeObject<CoursesResponse>(json);
                return coursesResponse.Data.Courses;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async static Task<Course> GetCourseAsync(int courseId)
        {
            string query = " { course(courseId: 1) { id name modules { id name tags { id name exercises { id number score exerciseImageUrl solutionImageUrl exerciseImageId solutionImageId source { id author date } } exerciseCount } } debugInfo } } ";
            HttpResponseMessage response = await PostRequestAsync(graphQlUrl, new GraphQlRequest(query).ToJson());

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                CourseResponse courseResponse = JsonConvert.DeserializeObject<CourseResponse>(json);
                return courseResponse.Data.Course;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task<Image> GetImageAsync(string imageUrl)
        {
            HttpResponseMessage response = await httpClient.GetAsync(imageUrl);

            if (response.IsSuccessStatusCode)
            {
                return Image.FromStream(await response.Content.ReadAsStreamAsync());
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task<bool> RemoveExercise(int exerciseId)
        {
            string requestPathEnd = "admin/exercise/remove?id=" + exerciseId.ToString();
            HttpResponseMessage response = await httpClient.DeleteAsync(apiBaseUrl + requestPathEnd);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task<UploadExerciseResponse> UploadExercise(UploadExerciseBody uploadExerciseBody)
        {
            string requestPathEnd = "admin/exercise/upload";
            HttpResponseMessage response = await PostRequestAsync(apiBaseUrl + requestPathEnd, uploadExerciseBody.ToJson());

            if (response.IsSuccessStatusCode)
            {
                return UploadExerciseResponse.FromJson(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
