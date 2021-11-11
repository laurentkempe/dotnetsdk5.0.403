using System.Reactive.Concurrency;
using System.Windows;
using System.Windows.Threading;

namespace fail
{
    public class WindowsSchedulerProvider
    {
        public static readonly WindowsSchedulerProvider Instance = new();
        
        private WindowsSchedulerProvider()
        {
        }

        public IScheduler Dispatcher { get; } = new DispatcherScheduler(Application.Current.Dispatcher, DispatcherPriority.Background);
    }
}