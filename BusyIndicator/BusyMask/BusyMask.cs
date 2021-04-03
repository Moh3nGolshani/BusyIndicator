using System.Windows;
using System.Windows.Controls;

namespace BusyIndicator
{
    [TemplateVisualState(Name = VisualStates.StateHidden, GroupName = VisualStates.GroupVisibility)]
    [TemplateVisualState(Name = VisualStates.StateVisible, GroupName = VisualStates.GroupVisibility)]
    public class BusyMask : ContentControl
    {
        public bool IsBusy
        {
            get { return (bool)GetValue(IsBusyProperty); }
            set { SetValue(IsBusyProperty, value); }
        }

        public static readonly DependencyProperty IsBusyProperty =
            DependencyProperty.Register("IsBusy",
                typeof(bool),
                typeof(BusyMask),
                new PropertyMetadata(false, OnIsBusyChanged));

        public string BusyContent
        {
            get { return (string)GetValue(BusyContentProperty); }
            set { SetValue(BusyContentProperty, value); }
        }

        public static readonly DependencyProperty BusyContentProperty =
            DependencyProperty.Register("BusyContent",
                typeof(string),
                typeof(BusyMask),
                new PropertyMetadata("Please wait..."));

        public IndicatorType IndicatorType
        {
            get { return (IndicatorType)GetValue(IndicatorTypeProperty); }
            set { SetValue(IndicatorTypeProperty, value); }
        }

        public static readonly DependencyProperty IndicatorTypeProperty =
            DependencyProperty.Register("IndicatorType",
                typeof(IndicatorType),
                typeof(BusyMask),
                new PropertyMetadata(IndicatorType.Ellipse));

        public Control FocusAfterBusy
        {
            get { return (Control)GetValue(FocusAfterBusyProperty); }
            set { SetValue(FocusAfterBusyProperty, value); }
        }

        public static readonly DependencyProperty FocusAfterBusyProperty =
            DependencyProperty.Register("FocusAfterBusy",
                typeof(Control),
                typeof(BusyMask),
                new PropertyMetadata(null));

        static BusyMask()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BusyMask),
                new FrameworkPropertyMetadata(typeof(BusyMask)));
        }

        private static void OnIsBusyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((BusyMask)d).OnIsBusyChanged(e);
        }

        protected virtual void OnIsBusyChanged(DependencyPropertyChangedEventArgs e)
        {
            if (!(bool)e.NewValue)
            {
                if (FocusAfterBusy != null)
                {
                    FocusAfterBusy.Dispatcher.Delay(100, ( _ ) =>
                    {
                        FocusAfterBusy.Focus();
                    });
                }
            }

            ChangeVisualState((bool)e.NewValue);
        }

        public override void OnApplyTemplate()
        {
            ChangeVisualState();
        }

        protected virtual void ChangeVisualState(bool isBusyContentVisible = false)
        {
            VisualStateManager.GoToState(this, isBusyContentVisible ? "Visible" : "Hidden", true);
        }
    }
}
