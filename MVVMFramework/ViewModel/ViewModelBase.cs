using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MVVMFramework.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private bool? _closeWindowFlag;

        public event PropertyChangedEventHandler PropertyChanged;

        internal void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal bool? CloseWindowFlag
        {
            get => _closeWindowFlag;
            set
            {
                _closeWindowFlag = value;
                RaisePropertyChanged();
            }
        }

        internal virtual void CloseWindow(bool? result = true)
        {
            Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, new Action(() =>
            {
                CloseWindowFlag = CloseWindowFlag == null ? true : !CloseWindowFlag;
            }));
        }
    }
}
