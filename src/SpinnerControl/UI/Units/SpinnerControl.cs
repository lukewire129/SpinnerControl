using System.Windows;
using System.Windows.Controls;

namespace SpinnerControl.UI.Units
{
    public class SpinnerControl : ContentControl
    {
        static SpinnerControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpinnerControl), new FrameworkPropertyMetadata(typeof(SpinnerControl)));
        }
    }
}
