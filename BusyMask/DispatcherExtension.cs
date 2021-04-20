using System;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace BusyIndicator
{
    public static class DispatcherExtension
    {
        public static void Delay(this Dispatcher dispatcher, int delay, Action<object> action, object parm = null)
        {
            Task.Delay(delay).ContinueWith((t) =>
            {
                dispatcher.Invoke(action, parm);
            });
        }
    }
}

