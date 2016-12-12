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
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            comboBox.Items.Add("Calzones");
            comboBox.Items.Add("Empanadas");
            comboBox.Items.Add("Fideos");
            comboBox.Items.Add("Lasagna");
            comboBox.Items.Add("Ñoquis");
            comboBox.Items.Add("Pizzas");
            comboBox.Items.Add("Ravioles");
            comboBox.Items.Add("Tallarines");
            comboBox.Items.Add("Tartas");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ScreenManager.Instance.KillAllPresentations();

            if (ScreenManager.Instance.Presentations != null)

                for (int i = 0; i < ScreenManager.Instance.Presentations.Count; i++)
                {
                    ScreenManager.Instance.Presentations.Clear();
                }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.button_Click(sender, e);
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.button_Click(sender, e);
            ScreenManager.Instance.Run();
            this.textBlock1.Text = ScreenManager.Instance.Presentations.Count.ToString();
            this.textBlock.Text = "Cantidad de pantallas detectadas:";
        }
    }
}
