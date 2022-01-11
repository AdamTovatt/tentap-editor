
namespace TentaPEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coursePicker = new System.Windows.Forms.ComboBox();
            this.exercisePictureBox = new System.Windows.Forms.PictureBox();
            this.modulePicker = new System.Windows.Forms.ComboBox();
            this.tagPicker = new System.Windows.Forms.ComboBox();
            this.exerciseList = new System.Windows.Forms.ListBox();
            this.solutionPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exerciseTakeNewButton = new System.Windows.Forms.Button();
            this.solutionTakeNewButton = new System.Windows.Forms.Button();
            this.exerciseIdLabel = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceIdInput = new System.Windows.Forms.NumericUpDown();
            this.sourceInfoLabel = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.exercisePanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exercisePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceIdInput)).BeginInit();
            this.exercisePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // coursePicker
            // 
            this.coursePicker.FormattingEnabled = true;
            this.coursePicker.Location = new System.Drawing.Point(12, 12);
            this.coursePicker.Name = "coursePicker";
            this.coursePicker.Size = new System.Drawing.Size(238, 21);
            this.coursePicker.TabIndex = 0;
            this.coursePicker.SelectedIndexChanged += new System.EventHandler(this.CoursePickerChangedIndex);
            // 
            // exercisePictureBox
            // 
            this.exercisePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exercisePictureBox.Location = new System.Drawing.Point(25, 53);
            this.exercisePictureBox.Name = "exercisePictureBox";
            this.exercisePictureBox.Size = new System.Drawing.Size(298, 96);
            this.exercisePictureBox.TabIndex = 1;
            this.exercisePictureBox.TabStop = false;
            // 
            // modulePicker
            // 
            this.modulePicker.FormattingEnabled = true;
            this.modulePicker.Location = new System.Drawing.Point(12, 49);
            this.modulePicker.Name = "modulePicker";
            this.modulePicker.Size = new System.Drawing.Size(238, 21);
            this.modulePicker.TabIndex = 2;
            this.modulePicker.SelectedIndexChanged += new System.EventHandler(this.ModulePickerChangedIndex);
            // 
            // tagPicker
            // 
            this.tagPicker.FormattingEnabled = true;
            this.tagPicker.Location = new System.Drawing.Point(12, 87);
            this.tagPicker.Name = "tagPicker";
            this.tagPicker.Size = new System.Drawing.Size(238, 21);
            this.tagPicker.TabIndex = 3;
            this.tagPicker.SelectedIndexChanged += new System.EventHandler(this.TagPickerChangedIndex);
            // 
            // exerciseList
            // 
            this.exerciseList.FormattingEnabled = true;
            this.exerciseList.Location = new System.Drawing.Point(12, 130);
            this.exerciseList.Name = "exerciseList";
            this.exerciseList.Size = new System.Drawing.Size(238, 303);
            this.exerciseList.TabIndex = 5;
            this.exerciseList.SelectedIndexChanged += new System.EventHandler(this.ExerciseListChangedIndex);
            // 
            // solutionPictureBox
            // 
            this.solutionPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.solutionPictureBox.Location = new System.Drawing.Point(373, 53);
            this.solutionPictureBox.Name = "solutionPictureBox";
            this.solutionPictureBox.Size = new System.Drawing.Size(298, 96);
            this.solutionPictureBox.TabIndex = 6;
            this.solutionPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exercise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Solution";
            // 
            // exerciseTakeNewButton
            // 
            this.exerciseTakeNewButton.Location = new System.Drawing.Point(25, 155);
            this.exerciseTakeNewButton.Name = "exerciseTakeNewButton";
            this.exerciseTakeNewButton.Size = new System.Drawing.Size(75, 23);
            this.exerciseTakeNewButton.TabIndex = 9;
            this.exerciseTakeNewButton.Text = "Take new";
            this.exerciseTakeNewButton.UseVisualStyleBackColor = true;
            // 
            // solutionTakeNewButton
            // 
            this.solutionTakeNewButton.Location = new System.Drawing.Point(373, 155);
            this.solutionTakeNewButton.Name = "solutionTakeNewButton";
            this.solutionTakeNewButton.Size = new System.Drawing.Size(75, 23);
            this.solutionTakeNewButton.TabIndex = 10;
            this.solutionTakeNewButton.Text = "Take new";
            this.solutionTakeNewButton.UseVisualStyleBackColor = true;
            // 
            // exerciseIdLabel
            // 
            this.exerciseIdLabel.AutoSize = true;
            this.exerciseIdLabel.Location = new System.Drawing.Point(22, 210);
            this.exerciseIdLabel.Name = "exerciseIdLabel";
            this.exerciseIdLabel.Size = new System.Drawing.Size(28, 13);
            this.exerciseIdLabel.TabIndex = 11;
            this.exerciseIdLabel.Text = "Id: ?";
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(75, 250);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(44, 20);
            this.numberInput.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Source:";
            // 
            // sourceIdInput
            // 
            this.sourceIdInput.Location = new System.Drawing.Point(75, 292);
            this.sourceIdInput.Name = "sourceIdInput";
            this.sourceIdInput.Size = new System.Drawing.Size(44, 20);
            this.sourceIdInput.TabIndex = 15;
            // 
            // sourceInfoLabel
            // 
            this.sourceInfoLabel.AutoSize = true;
            this.sourceInfoLabel.Location = new System.Drawing.Point(25, 337);
            this.sourceInfoLabel.Name = "sourceInfoLabel";
            this.sourceInfoLabel.Size = new System.Drawing.Size(57, 13);
            this.sourceInfoLabel.TabIndex = 16;
            this.sourceInfoLabel.Text = "sourceInfo";
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(1043, 399);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 17;
            this.uploadButton.Text = "Save";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.UploadButtonClick);
            // 
            // exercisePanel
            // 
            this.exercisePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exercisePanel.Controls.Add(this.label1);
            this.exercisePanel.Controls.Add(this.exercisePictureBox);
            this.exercisePanel.Controls.Add(this.sourceInfoLabel);
            this.exercisePanel.Controls.Add(this.solutionPictureBox);
            this.exercisePanel.Controls.Add(this.sourceIdInput);
            this.exercisePanel.Controls.Add(this.label2);
            this.exercisePanel.Controls.Add(this.label4);
            this.exercisePanel.Controls.Add(this.exerciseTakeNewButton);
            this.exercisePanel.Controls.Add(this.label3);
            this.exercisePanel.Controls.Add(this.solutionTakeNewButton);
            this.exercisePanel.Controls.Add(this.numberInput);
            this.exercisePanel.Controls.Add(this.exerciseIdLabel);
            this.exercisePanel.Location = new System.Drawing.Point(328, 12);
            this.exercisePanel.Name = "exercisePanel";
            this.exercisePanel.Size = new System.Drawing.Size(790, 381);
            this.exercisePanel.TabIndex = 18;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(962, 399);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(328, 475);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(790, 96);
            this.console.TabIndex = 20;
            this.console.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 583);
            this.Controls.Add(this.console);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.exercisePanel);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.exerciseList);
            this.Controls.Add(this.tagPicker);
            this.Controls.Add(this.modulePicker);
            this.Controls.Add(this.coursePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exercisePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceIdInput)).EndInit();
            this.exercisePanel.ResumeLayout(false);
            this.exercisePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox coursePicker;
        private System.Windows.Forms.PictureBox exercisePictureBox;
        private System.Windows.Forms.ComboBox modulePicker;
        private System.Windows.Forms.ComboBox tagPicker;
        private System.Windows.Forms.ListBox exerciseList;
        private System.Windows.Forms.PictureBox solutionPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exerciseTakeNewButton;
        private System.Windows.Forms.Button solutionTakeNewButton;
        private System.Windows.Forms.Label exerciseIdLabel;
        private System.Windows.Forms.NumericUpDown numberInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sourceIdInput;
        private System.Windows.Forms.Label sourceInfoLabel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Panel exercisePanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RichTextBox console;
    }
}

