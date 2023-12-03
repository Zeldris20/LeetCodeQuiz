// Quiz.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Quiz_App
{
    public partial class Quiz : Page
    {
       
        private double currentProgress = 0.0;

        public Quiz()
        {
            InitializeComponent();
           
        }

        private void UpdateProgressBar(double increment)
        {
            currentProgress += increment;
            if (currentProgress > 100)
                currentProgress = 100;

            quizProgressBar.Value = currentProgress;
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Handle the ProgressBar ValueChanged event here if needed
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RightAnswer.Background = new SolidColorBrush(Color.FromRgb(0, 128, 0));
            UpdateProgressBar(25);
            ScoreTextBox.Text = "Score: 100";

            // Assuming Quiz2 is a UserControl class
            Quiz2 quiz2Control = new Quiz2();

            // Create a new window to host the UserControl
            Window window = new Window
            {
                Content = quiz2Control,
                Width = 800,
                Height = 450,
                Title = "Quiz2 Window"
            };

            // Hide the current window (Quiz.xaml)
            Quiz quizWindow = new Quiz();
            quizWindow.Focus();
            Window focusedWindow = Window.GetWindow(this);
            if (focusedWindow != null)
            {
                focusedWindow.Hide();
            }

            // Show the new window
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WrongA.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            UpdateProgressBar(25);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WrongB.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            UpdateProgressBar(25);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WrongD.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            UpdateProgressBar(25);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void quizProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        // Other event handlers and methods if needed
    }
}
