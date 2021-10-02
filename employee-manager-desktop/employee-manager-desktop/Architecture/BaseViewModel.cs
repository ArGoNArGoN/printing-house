using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace employee_manager_desktop.Architecture
{
    internal abstract class BaseViewModel
        : INotifyPropertyChanged
    {
        protected BaseViewModel() { }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
