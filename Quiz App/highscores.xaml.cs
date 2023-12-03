using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Quiz_App
{
    public partial class Highscores : Window
    {
        public Highscores()
        {
            InitializeComponent();
        }
        
       
        public void SetUsername(string username)
        {
            Username.Text = username;
        }
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
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