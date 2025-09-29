using makememee.Models;

namespace makememee.ModelLogic
{
    internal class User : UserModel
    {
       
        public override void Register()
        {
            fbd.CreateUserWithEmailAndPasswordAsync(Email, Password, Name, OnComplete);
        }
        public void OnComplete (Task task)
        {
            if (task.IsCompletedSuccessfully)
                SaveToPreferences(); 
            else
                Shell.Current.DisplayAlert(Strings.CreateUserError, task.Exception?.Message,Strings.Ok);
        }

        private void SaveToPreferences()
        {
            Preferences.Set(Keys.Namekey, Name);
            Preferences.Set(Keys.Emailkey, Email);
            Preferences.Set(Keys.Passwordkey, Password);
        }

        public void LogIn()
        {
            Preferences.Set(Keys.Namekey, Name);
            Preferences.Set(Keys.Emailkey, Email);
            Preferences.Set(Keys.Passwordkey, Password);
        }

        public User()
        {
            Name = Preferences.Get(Keys.Namekey, string.Empty);
        }
    }
}
