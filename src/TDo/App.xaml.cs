namespace TDo;
using TDo.Pages;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new TaskBlockPage());
	}
}
