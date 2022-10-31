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
                new PropertyMetadata(IndicatorType.Twist));

        static Indicator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Indicator),
                new FrameworkPropertyMetadata(typeof(Indicator)));
        }

        public override void OnApplyTemplate()
        {
            this.UpdateVisualState();
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            if (e.Property == IsVisibleProperty)
            {
                this.UpdateVisualState();
            }
        }

        private void UpdateVisualState()
        {
            if (this.Template == null)
            {
                return;
            }

            var mainGrid = (FrameworkElement)GetTemplateChild("MainGrid");
            if (mainGrid == null)
            {
                return;
            }

            var targetState = this.IsVisible ? "Active" : "Inactive";
            VisualStateManager.GoToElementState(mainGrid, targetState, true);
        }
    }
}
