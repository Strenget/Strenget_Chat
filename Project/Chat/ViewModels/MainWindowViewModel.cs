using System.Net.Mime;
using Caliburn.Micro;
using Castle.Core.Logging;

namespace Chat.ViewModels
{
	public class MainWindowViewModel : Screen
	{
		private readonly IWindowManager _windowManager;
		private string _text;
		private string _text1;


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

		public string Text1
		{
			get { return _text1; }
			set
			{
				if (_text1 != value)
				{
					_text1 = value;
					NotifyOfPropertyChange(() => Text1);
				}
			}
		}

		public void ChangeText()
		{
			NotifyOfPropertyChange( () => Text);
		}
		public void ChangeText1()
		{
			NotifyOfPropertyChange(() => Text1);
		}


	}
}
