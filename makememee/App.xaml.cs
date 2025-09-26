using makememee.ModelLogic;
using makememee.Views;

namespace makememee
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            User user = new ();
            Page page = user.IsRegister ? new LogInPage() : new AppShell();
            MainPage = page;
        }
    }
}
