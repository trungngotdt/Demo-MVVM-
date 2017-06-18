using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class RalyWithoutPara : ICommand
    {
        readonly Action _action = null;
        readonly Func<bool> _predicate = null;
        public RalyWithoutPara(Action action) :this (null,action)
        {

        }
        public RalyWithoutPara(Func<bool> predicate, Action action)
        {
            _predicate = predicate;
            _action = action;
        }
        public bool CanExecute(object parameter)
        {
            return _predicate == null ? true : _predicate();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
