using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMBase
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        
        public bool CanExecute(object parameter)
        {
            if (null == canExecuteFunc)
                return true;

            return this.canExecuteFunc(parameter);
        }

        public void Execute(object parameter)
        {
            if (null != executeAction)
                this.executeAction.Invoke(parameter);
        }

        private Func<object, bool> canExecuteFunc;
        private Action<object> executeAction;
        public DelegateCommand(Action<object> executeAction = null, Func<object, bool> canExecuteFunc = null)
        {
            this.executeAction = executeAction;
            this.canExecuteFunc = canExecuteFunc;
        }
    }
}
