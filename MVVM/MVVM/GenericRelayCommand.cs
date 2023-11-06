using System;
using System.Windows.Input;

namespace MVVM
{
	public class GenericRelayCommand<T> : ICommand
	{
		public event EventHandler CanExecuteChanged;
		Action<object> action;
		public GenericRelayCommand(Action<object> action)
		{
			this.action = action;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			//if (parameter == null) return;
			action(parameter);
		}
	}
}
