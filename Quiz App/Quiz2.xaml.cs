// Quiz.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Quiz_App
{
    public partial class Quiz2 : Page
    {
        private double currentProgress = 0.0;

        public Quiz2()
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

            // Assuming Quiz2 is a UserControl class
            Quiz3 quiz3Control = new Quiz3();

            // Create a new window to host the UserControl
            Window window = new Window
            {
                Content = quiz3Control,
                Width = 800,
                Height = 450,
                Title = "Quiz3 Window"
            };
            // Hide the current window (Quiz.xaml)
            Quiz2 quiz2Window = new Quiz2();
            quiz2Window.Focus();
            Window focusedWindow = Window.GetWindow(this);
            if (focusedWindow != null)
            {
                focusedWindow.Hide();
            }
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
