using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace transactionReaderWPF.ViewModel
{
    public abstract class BaseVM : INotifyPropertyChanged
    {
        //basic ViewModelBase
        public event PropertyChangedEventHandler PropertyChanged;

        internal void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((propertyName)));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            RaisePropertyChanged(propertyName);
            return true;
        }
    }
}
