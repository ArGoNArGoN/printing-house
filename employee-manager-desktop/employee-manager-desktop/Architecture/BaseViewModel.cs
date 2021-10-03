using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace employee_manager_desktop.Architecture
{
    public abstract class BaseViewModel
        : INotifyPropertyChanged
    {
        protected BaseViewModel() { InitializeCommand(); }

        protected virtual void InitializeCommand() { }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
