using System.Text;
using System.Web;

namespace TentaPEditor
{
    public partial class Form1 : Form
    {
        string errorMessage = null;
        private Api api;
        private Exercise exercise;

        public Form1(string[] args, bool didSetRegistry)
        {
            InitializeComponent();

            if (args.Length == 0)
            {
                if (didSetRegistry)
                    Environment.Exit(0);
                else
                    errorMessage = "Försökte installera programmet men rättigheter saknades";
            }
            else
            {
                try
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (string argument in args)
                        stringBuilder.AppendLine(argument);

                    string json = HttpUtility.UrlDecode(stringBuilder.ToString().Substring("tentap:".Length));
                    StartArguments arguments = StartArguments.FromJson(json);
                    api = new Api(arguments.ApiUrl, arguments.Token);
                    exercise = new Exercise(arguments.ExerciseId);
                }
                catch (Exception e)
                {
                    errorMessage = e.Message;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (errorMessage == null)
            {
                try
                {
                    Image problemImage = null;
                    Image solutionImage = null;

                    ImageCaptureWindow captureWindow1 = new ImageCaptureWindow();

                    captureWindow1.Show();
                    captureWindow1.OnImageWasCaptured += (Image image) =>
                    {
                        problemImage = image;

                        ImageCaptureWindow captureWindow2 = new ImageCaptureWindow();

                        captureWindow2.Show();
                        captureWindow2.OnImageWasCaptured += (Image image) =>
                        {
                            solutionImage = image;

                            DidCaptureImages(problemImage, solutionImage);
                        };
                    };
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(errorMessage);
                Environment.Exit(0);
            }
        }

        private async void DidCaptureImages(Image problemImage, Image solutionImage)
        {
            exercise.ProblemImage = (Bitmap)problemImage;
            exercise.SolutionImage = (Bitmap)solutionImage;

            var response = await api.PostRequestAsync("admin/exercise/create", exercise.ToJson());

            Environment.Exit(0);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Hide();
        }
    }
}