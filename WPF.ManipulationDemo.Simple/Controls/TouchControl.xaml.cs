using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF.ManipulationDemo.Simple.Controls
{
    // This class was implemented from https://blogs.msdn.microsoft.com/llobo/2009/12/21/wpf-manipulation-basics/

    /// <summary>
    /// Interaction logic for TouchControl.xaml
    /// </summary>
    public partial class TouchControl : UserControl
    {
        private TransformGroup transformGroup;
        private TranslateTransform translation;
        private ScaleTransform scale;
        private RotateTransform rotation;

        public TouchControl()
        {
            InitializeComponent();

            transformGroup = new TransformGroup();

            translation = new TranslateTransform(0, 0);
            scale = new ScaleTransform(1, 1);
            rotation = new RotateTransform(0);


            transformGroup.Children.Add(rotation);
            transformGroup.Children.Add(scale);
            transformGroup.Children.Add(translation);


            BasicRect.RenderTransform = transformGroup;
        }

        protected override void OnManipulationStarting(ManipulationStartingEventArgs e)
        {
            e.ManipulationContainer = this;
        }

        protected override void OnManipulationDelta(ManipulationDeltaEventArgs e)
        {
            // the center never changes in this sample, although we always compute it.
            Point center = new Point(
                 BasicRect.RenderSize.Width / 2.0, BasicRect.RenderSize.Height / 2.0);

            // apply the rotation at the center of the rectangle if it has changed
            rotation.CenterX = center.X;
            rotation.CenterY = center.Y;
            rotation.Angle += e.DeltaManipulation.Rotation;

            // Scale is always uniform, by definition, so the x and y will always have the same magnitude
            scale.CenterX = center.X;
            scale.CenterY = center.Y;
            scale.ScaleX *= e.DeltaManipulation.Scale.X;
            scale.ScaleY *= e.DeltaManipulation.Scale.Y;

            // apply translation
            translation.X += e.DeltaManipulation.Translation.X;
            translation.Y += e.DeltaManipulation.Translation.Y;
        }
    }
}
