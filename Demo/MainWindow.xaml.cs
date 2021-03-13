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

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            BusyIndicator.IsBusy = true;
            await Task.Delay(5000);
            BusyIndicator.IsBusy = false;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (sender as ComboBox).SelectedValue;
            int index = IndicatorComboBox.Items.IndexOf(item);

            switch (index)
            {
                case 0:
                    BusyIndicator.IndicatorType = IndicatorType.Dashes;
                    break;
                case 1:
                    BusyIndicator.IndicatorType = IndicatorType.ColorDots;
                    break;
                case 2:
                    BusyIndicator.IndicatorType = IndicatorType.Bar;
                    break;
                case 3:
                    BusyIndicator.IndicatorType = IndicatorType.Ring;
                    break;
                case 4:
                    BusyIndicator.IndicatorType = IndicatorType.Ellipse;
                    break;
                case 5:
                    BusyIndicator.IndicatorType = IndicatorType.Cupertino;
                    break;
                case 6:
                    BusyIndicator.IndicatorType = IndicatorType.Cogs;
                    break;
                case 7:
                    BusyIndicator.IndicatorType = IndicatorType.DotCircle;
                    break;
                case 8:
                    BusyIndicator.IndicatorType = IndicatorType.Piston;
                    break;
                case 9:
                    BusyIndicator.IndicatorType = IndicatorType.Swirl;
                    break;
                case 10:
                    BusyIndicator.IndicatorType = IndicatorType.Blocks;
                    break;
                default:
                    break;
            }
        }

    }
}
