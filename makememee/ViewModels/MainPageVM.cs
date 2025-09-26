using makememee.ModelLogic;
using System.Windows.Input;

namespace makememee.ViewModels
{
    internal class MainPageVM
    {
        private readonly User user = new();
        public ICommand RegisterCommand { get; }

        public string Name 
        {
            get => user.Name;
            set
            {
                user.Name = value; 
               (RegisterCommand as Command)?.ChangeCanExecute();                
            } 
        }

       

        public MainPageVM()
        {
            RegisterCommand = new Command(Registeri, CanRegister);
        }
        public bool CanRegister()
        {
            return !string.IsNullOrWhiteSpace(user.Name) && !string.IsNullOrWhiteSpace(user.Name);
        }

        private void Registeri()
        {
            user.Register();
        }
    }
}
