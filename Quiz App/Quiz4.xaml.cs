// Quiz.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Quiz_App
{
    public partial class Quiz4 : Page
    {
        private double currentProgress = 0.0;

        public Quiz4()
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
            UpdateProgressBar(100);
            ScoreTextBox.Text = "Score: 400";

            // Close the current window (Quiz4)
            Window currentWindow = Window.GetWindow(this);
            currentWindow?.Close();

            // Open a new window for EndScreen
            EndScreen endScreenWindow = new EndScreen();
            endScreenWindow.Show();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WrongA.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            UpdateProgressBar(100);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WrongB.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            UpdateProgressBar(100);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WrongD.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            UpdateProgressBar(100);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Other event handlers and methods if needed
    }
}
