using Caliburn.Micro;
using Castle.Core.Logging;

namespace Chat.ViewModels
{
	public class MainWindowViewModel : Screen
	{
		private readonly IWindowManager _windowManager;
		private string _text;

		public MainWindowViewModel(
			IWindowManager windowManager)
		{
			_windowManager = windowManager;
			Text = "text";
		}


		public string Text
		{
			get { return _text; }
			set
			{
				if (_text != value)
				{
					_text = value;
					NotifyOfPropertyChange(() => Text);
				}
			}
		}
	}
}
