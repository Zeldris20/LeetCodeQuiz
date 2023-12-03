using System;
using System.Windows;

namespace Quiz_App
{
    public partial class EndScreen : Window
    {
        public EndScreen()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get the content of UsernameText TextBox
                string usernameTextContent = UsernameText.Text;

                // Save the current username
                HighScoreManager.SaveCurrentUsername(usernameTextContent);

                // Close the current window (EndScreen)
                Window currentWindow = Window.GetWindow(this);
                currentWindow?.Close();

                // Open a new window for Highscores
                Highscores highscoreScreenWindow = new Highscores();
                highscoreScreenWindow.SetUsername(usernameTextContent); // Set the username
                highscoreScreenWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
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

            // Hide the current window (EndScreen.xaml)
            Close();

            // Show the new window
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Assuming Quiz is a UserControl class
            Play PlayControl = new Play();

            // Create a new window to host the UserControl
            Window window = new Window
            {
                Content = PlayControl,
                Width = 800,
                Height = 450,
                Title = "Play Window"
            };

            // Hide the current window (Play.xaml)
            Close();

            // Show the new window
            window.Show();
        }
    }
}