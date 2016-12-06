using Presenter.Core.ScreeenManager;
using System.Windows;

namespace Presenter.ControlPanel
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ScreenManager.Instance.KillAllPresentations();

            if (ScreenManager.Instance.Presentations != null)
                ScreenManager.Instance.Presentations.Clear();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.button_Click(sender, e);
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ScreenManager.Instance.Run();
        }
    }
}
