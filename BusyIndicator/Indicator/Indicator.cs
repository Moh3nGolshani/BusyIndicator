using System.Windows;
using System.Windows.Controls;

namespace BusyIndicator
{
    public class Indicator : Control
    {

        public IndicatorType IndicatorType
        {
            get { return (IndicatorType)GetValue(IndicatorTypeProperty); }
            set { SetValue(IndicatorTypeProperty, value); }
        }

        public static readonly DependencyProperty IndicatorTypeProperty =
            DependencyProperty.Register("IndicatorType",
                typeof(IndicatorType),
                typeof(Indicator),
                new PropertyMetadata(IndicatorType.Grid));

        static Indicator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Indicator),
                new FrameworkPropertyMetadata(typeof(Indicator)));
        }

        public override void OnApplyTemplate()
        {
            VisualStateManager.GoToElementState((FrameworkElement)GetTemplateChild("MainGrid"), "Active", true);
        }
    }
}

