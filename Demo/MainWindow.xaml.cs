using BusyIndicator;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Demo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IndicatorComboBox.SelectedIndex = 0;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Delay(10000);
            BusyIndicator.IsBusy = false;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (sender as ComboBox).SelectedValue;
            int index = IndicatorComboBox.Items.IndexOf(item);

            switch (index)
            {
                case 0:
                    BusyIndicator.IndicatorType = IndicatorType.DashLoader;
                    break;
                case 1:
                    BusyIndicator.IndicatorType = IndicatorType.DotLoader;
                    break;
                case 2:
                    BusyIndicator.IndicatorType = IndicatorType.ProgressBar;
                    break;
                case 3:
                    BusyIndicator.IndicatorType = IndicatorType.ProgressRing;
                    break;
                case 4:
                    BusyIndicator.IndicatorType = IndicatorType.Spinner;
                    break;
                default:
                    break;
            }
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
