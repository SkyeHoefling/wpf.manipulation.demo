using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System;

namespace WPF.ManipulationDemo.Binding.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        public ICommand ManipulationStarting
            => new RelayCommand<ManipulationStartingEventArgs>(OnManipulationStarting);

        public ICommand ManipulationDelta
            => new RelayCommand<ManipulationDeltaEventArgs>(OnManipulationDelta);

        public ICommand ManipulationCompleted
            => new RelayCommand<ManipulationCompletedEventArgs>(OnManipulationCompleted);

        private void OnManipulationStarting(ManipulationStartingEventArgs e)
        {
            throw new NotImplementedException();            
        }

        private void OnManipulationDelta(ManipulationDeltaEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnManipulationCompleted(ManipulationCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}