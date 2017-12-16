using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NsiViewerDevExpress.Common
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [DebuggerStepThrough]
        protected void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
                return;
            storage = value;
            RaisePropertyChanged(propertyName);
        }

        [DebuggerStepThrough]
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
           if (PropertyChanged != null)
               PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}