using System.Windows;

namespace Splat
{
    public class PlatformModeDetector : IModeDetector
    {
        bool? inUnitTestRunner;

        public bool? InUnitTestRunner()
        {
            return inUnitTestRunner;
        }

        public void SetInUnitTestRunner(bool flag)
        {
            inUnitTestRunner = flag;
        }

        public bool? InDesignMode()
        {
            if (Application.Current?.MainWindow != null)
                return System.ComponentModel.DesignerProperties.GetIsInDesignMode(Application.Current.MainWindow);

            return System.ComponentModel.DesignerProperties.GetIsInDesignMode(new DependencyObject());
        }
    }
}
