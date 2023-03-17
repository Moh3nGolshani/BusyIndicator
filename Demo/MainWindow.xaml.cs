using BusyIndicator;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace Demo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IndicatorComboBox.SelectedIndex = 0;

            Stop();
        }

        private async void Stop()
        {
            await Task.Delay(System.TimeSpan.FromSeconds(3));
            BusyIndicator.IsBusy = false;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(MyTextBox.Text, out double duration))
            {
                duration = 10;
            }

            BusyIndicator.IsBusy = true;
            await Task.Delay(System.TimeSpan.FromSeconds(duration));
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
                    BusyIndicator.IndicatorType = IndicatorType.FourDots;
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
                case 11:
                    BusyIndicator.IndicatorType = IndicatorType.Wave;
                    break;
                case 12:
                    BusyIndicator.IndicatorType = IndicatorType.Pulse;
                    break;
                case 13:
                    BusyIndicator.IndicatorType = IndicatorType.DoubleBounce;
                    break;
                case 14:
                    BusyIndicator.IndicatorType = IndicatorType.ThreeDots;
                    break;
                case 15:
                    BusyIndicator.IndicatorType = IndicatorType.Grid;
                    break;
                case 16:
                    BusyIndicator.IndicatorType = IndicatorType.BouncingDot;
                    break;
                case 17:
                    BusyIndicator.IndicatorType = IndicatorType.Escalade;
                    break;
                case 18:
                    BusyIndicator.IndicatorType = IndicatorType.Twist;
                    break;
                default:
                    break;
            }
        }
    }
}
