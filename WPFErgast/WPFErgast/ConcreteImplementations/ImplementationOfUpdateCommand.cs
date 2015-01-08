using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WPFErgast.ViewModels
{
    internal class ImplementationOfUpdateCommand:ICommand
    {
        public ImplementationOfUpdateCommand(Configuration viewModel)
        {
            _viewModel = viewModel;
        }

        private Configuration _viewModel;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.CanUpdate;
        }


        public void Execute(object parameter)
        {
            Console.WriteLine("EXECUTE");
        }
    }
}
