using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Demo_Test.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public BaseViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RaiseIfPropertyChanged<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(property, value))
                return;

            property = value;
            OnPropertyChanged(propertyName);
        }
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => RaiseIfPropertyChanged(ref _isBusy, value);
        }

    }
}
