using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfApp1
{
    public class SimpleCommand : ICommand
    {
        public VM ViewModels { get; set; }

        public SimpleCommand(VM vm)
        {
            this.ViewModels = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            this.ViewModels.Method1();
        }
    }
}
