﻿using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Demo
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool isBusy;
        public event PropertyChangedEventHandler PropertyChanged;
        public MainWindow()
        {
            InitializeComponent();
            IndicatorComboBox.SelectedIndex = 0;

            if (BusyIndicator.IsBusy)
                Stop();

            // Emulate that IsBusy is true from the very beginning:
            //Button_Click(null, null);
        }

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private async void Stop()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            IsBusy = false;
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
                duration = 5;
            }

            IsBusy = true;
            await Task.Delay(TimeSpan.FromSeconds(duration));
            IsBusy = false;
        }
    }
}
