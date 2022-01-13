using System.Windows;
using System.Windows.Media;

namespace BusyIndicator
{
    internal class EscaladeHelper
    {
        public static readonly DependencyProperty StrokeDashArrayValueProperty =
            DependencyProperty.RegisterAttached("StrokeDashArrayValue",
                typeof(double),
                typeof(EscaladeHelper),

                new PropertyMetadata(0.0, OnStrokeDashArrayValueChanged));

        public static double GetStrokeDashArrayValue(System.Windows.Shapes.Path path)
        {
            return (double)path.GetValue(StrokeDashArrayValueProperty);
        }

        public static void SetStrokeDashArrayValue(System.Windows.Shapes.Path path, double value)
        {
            path.SetValue(StrokeDashArrayValueProperty, value);
        }

        private static void OnStrokeDashArrayValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is System.Windows.Shapes.Path path)
            {
                var value = (double)e.NewValue;
                path.StrokeDashArray = new DoubleCollection() { value, 10 };
            }
        }
    }
}
