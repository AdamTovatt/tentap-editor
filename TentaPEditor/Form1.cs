using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TentaPEditor.Models;
using TentaPEditor.Models.RestBodies;
using TentaPEditor.Models.RestResponses;

namespace TentaPEditor
{
    public partial class Form1 : Form
    {
        private List<Course> courses = new List<Course>();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            courses = await ApiHelper.GetAllCoursesAsync();

            Course course = null;
            if (courses.FirstOrDefault() != null)
                course = await FetchCourseAsync(courses.First().Id);

            if (course != null)
            {
                FillModulePicker();
                FillTagPicker();
            }

            coursePicker.DataSource = courses;
        }

        private async Task<Course> FetchCourseAsync(int id)
        {
            Course course = await ApiHelper.GetCourseAsync(courses.First().Id);

            Course oldCourse = courses.Where(x => x.Id == id).FirstOrDefault();

            if (oldCourse != null)
            {
                courses[courses.IndexOf(oldCourse)] = course;
            }

            return course;
        }

        private void FillModulePicker()
        {
            Course course = (Course)coursePicker.SelectedItem;

            if (course == null)
                course = courses.First();

            modulePicker.DataSource = course.Modules;
        }

        private void FillTagPicker()
        {
            Module module = (Module)modulePicker.SelectedItem;

            if (module == null)
            {
                Course course = (Course)coursePicker.SelectedItem;

                if (course == null)
                    course = courses.First();

                module = course.Modules.First();
            }

            tagPicker.DataSource = module.Tags;
        }

        private void FillExerciseList()
        {
            Tag tag = (Tag)tagPicker.SelectedItem;

            if (tag != null)
            {
                exerciseList.DataSource = tag.Exercises;
            }
        }


        private void CoursePickerChangedIndex(object sender, EventArgs e)
        {
            FillModulePicker();
        }

        private void ModulePickerChangedIndex(object sender, EventArgs e)
        {
            FillTagPicker();
        }

        private async void TagPickerChangedIndex(object sender, EventArgs e)
        {
            FillExerciseList();
            exercisePictureBox.Image = null;
            solutionPictureBox.Image = null;
        }

        private async void ExerciseListChangedIndex(object sender, EventArgs e)
        {
            Exercise exercise = (Exercise)exerciseList.SelectedItem;

            if (exercise != null)
            {
                await exercise.FetchAsync();
                exercisePictureBox.Image = exercise.ExerciseImage;
                solutionPictureBox.Image = exercise.SolutionImage;
                sourceIdInput.Value = exercise.Source.Id;
                numberInput.Value = exercise.Number;
                sourceInfoLabel.Text = exercise.Source.ToString();
                exerciseIdLabel.Text = "Id: " + exercise.Id.ToString();
            }
        }

        private async void UploadButtonClick(object sender, EventArgs e)
        {
            ConsoleLog("Start upload exercise");
            uploadButton.Enabled = false;

            if (exercisePictureBox.Image == null)
            {
                ConsoleLog("ExercisePicture must be a picture");
                return;
            }

            if (solutionPictureBox.Image == null)
            {
                ConsoleLog("SolutionPicture must be a picture");
                return;
            }

            if (sourceIdInput.Value == 0)
            {
                ConsoleLog("SourceId can not be 0");
                return;
            }

            if (numberInput.Value == 0)
            {
                ConsoleLog("Number can not be 0");
                return;
            }

            if ((Course)coursePicker.SelectedItem == null)
            {
                ConsoleLog("Course can not be null, please select a course");
                return;
            }

            UploadExerciseBody body = new UploadExerciseBody(exercisePictureBox.Image, solutionPictureBox.Image);
            body.CourseId = ((Course)coursePicker.SelectedItem).Id;
            body.ModuleId = ((Module)modulePicker.SelectedItem).Id;
            body.TagId = ((Tag)tagPicker.SelectedItem).Id;
            body.Number = (int)numberInput.Value;
            body.SourceId = (int)sourceIdInput.Value;
            
            if((Exercise)exerciseList.SelectedItem != null)
            {
                body.Id = ((Exercise)exerciseList.SelectedItem).Id;
            }

            UploadExerciseResponse response = await ApiHelper.UploadExercise(body);
            ConsoleLog(response.Mode + " Id: " + response.Id);
            uploadButton.Enabled = true;
        }

        private async void DeleteButtonClick(object sender, EventArgs e)
        {
            bool response = await ApiHelper.RemoveExercise(((Exercise)exerciseList.SelectedItem).Id);

            if (response)
                ConsoleLog("Removed exercise");
        }

        public void ConsoleClear()
        {
            console.Text = "";
        }

        public void ConsoleLog(string text, bool newLine = true)
        {
            console.Text += text + (newLine ? "\n" : "");
        }
    }
}
