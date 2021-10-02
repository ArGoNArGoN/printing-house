using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace employee_manager_desktop.Architecture
{
    /// <summary>
    /// Предоставляет возможность связывания VM c V
    /// </summary>
    public class Command
        : ICommand
    {
        protected Action<Object> execute;
        protected Func<Object, Boolean> canExecute;

        public virtual event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public Command(Action<Object> execute, Func<Object, Boolean> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public virtual Boolean CanExecute(Object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public virtual void Execute(Object parameter)
        {
            this.execute(parameter);
        }
    }
}
