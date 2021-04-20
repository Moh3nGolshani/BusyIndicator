using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BusyIndicator
{
    internal class EllipseHelper
    {
        public static readonly DependencyProperty StrokeDashArrayValueProperty =
            DependencyProperty.RegisterAttached("StrokeDashArrayValue",
                typeof(double),
                typeof(EllipseHelper),
                new PropertyMetadata(0.0, OnStrokeDashArrayValueChanged));

        public static double GetStrokeDashArrayValue(Ellipse ellipse)
        {
            return (double)ellipse.GetValue(StrokeDashArrayValueProperty);
        }

        public static void SetStrokeDashArrayValue(Ellipse ellipse, double value)
        {
            ellipse.SetValue(StrokeDashArrayValueProperty, value);
        }

        private static void OnStrokeDashArrayValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Ellipse ellipse)
            {
                var value = (double)e.NewValue;
                ellipse.StrokeDashArray = new DoubleCollection() { value, 100 };
            }
        }
    }
}
