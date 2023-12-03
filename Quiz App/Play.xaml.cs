using System;
using System.Threading.Channels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Quiz_App
{
    public partial class Play : UserControl
    {
        public Play()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Assuming Quiz is a UserControl class
            Quiz quizControl = new Quiz();

            // Create a new window to host the UserControl
            Window window = new Window
            {
                Content = quizControl,
                Width = 800,
                Height = 450,
                Title = "Quiz Window"
            };

            // Hide the current window (Play.xaml)
            Application.Current.MainWindow.Hide();

            // Show the new window
            window.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Highscores highscoresWindow = new Highscores();

            // Hide the current window (Play.xaml)
            Application.Current.MainWindow.Hide();

            // Show the new window (Highscores)
            highscoresWindow.ShowDialog();
        }
    }
}
