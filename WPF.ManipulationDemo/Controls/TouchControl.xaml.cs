using System.Windows.Controls;
using System.Windows.Input;

namespace WPF.ManipulationDemo.Controls
{
    /// <summary>
    /// Interaction logic for TouchControl.xaml
    /// </summary>
    public partial class TouchControl : UserControl
    {
        public TouchControl()
        {
            InitializeComponent();
        }

        protected override void OnManipulationStarting(ManipulationStartingEventArgs e)
        {
            base.OnManipulationStarting(e);
        }

        protected override void OnManipulationDelta(ManipulationDeltaEventArgs e)
        {
            base.OnManipulationDelta(e);
        }

        protected override void OnManipulationCompleted(ManipulationCompletedEventArgs e)
        {
            base.OnManipulationCompleted(e);
        }
    }
}
