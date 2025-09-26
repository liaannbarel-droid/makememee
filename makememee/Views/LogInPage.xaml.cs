using makememee.ViewModels;

namespace makememee.Views;

public partial class LogInPage : ContentPage
{
	public LogInPage()
	{
		InitializeComponent();

        BindingContext = new LogInVM();
    }
}