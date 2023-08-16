using System.Windows;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool running = false;

        public MainWindow()
        {
            InitializeComponent();
            btnToggleRun.Content = "Run";
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                // stop
                tbStatus.Text = "Stopped";
                btnToggleRun.Content = "Run";
            }
            else
            {
                // run
                tbStatus.Text = "Running";
                btnToggleRun.Content = "Stop";
            }
            running = !running;
        }
    }
}
