using makememee.ModelLogic;
using System.Windows.Input;

namespace makememee.ViewModels
{
    class LogInVM
    {
        public ICommand LogInCommand { get; }
        private readonly User user = new();
        public string Name
        {
            get => user.Name;
            set
            {
                user.Name = value;
                (LogInCommand as Command)?.ChangeCanExecute();
            }
        }

        public string Email
        {
            get => user.Email;
            set
            {
                user.Email = value;
                (LogInCommand as Command)?.ChangeCanExecute();
            }
        }
        public string Password
        {
            get => user.Password;
            set
            {
                user.Password = value;
                (LogInCommand as Command)?.ChangeCanExecute();
            }
        }

        public LogInVM()
        {
            LogInCommand = new Command(LogIn, CanLogIn);
        }

        public bool CanLogIn()
        {
            return !string.IsNullOrWhiteSpace(user.Name) && !string.IsNullOrWhiteSpace(user.Name);
        }

        private void LogIn()
        {
            user.LogIn();
        }
    }
}
