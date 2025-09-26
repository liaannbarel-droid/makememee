using makememee.Models;

namespace makememee.ModelLogic
{
    internal class User : UserModel
    {

        public override void Register()
        {
            Preferences.Set(keys.Namekey, Name);
        }

        public void LogIn()
        {
            Preferences.Set(keys.Namekey, Name);
            Preferences.Set(keys.Emailkey, Email);
            Preferences.Set(keys.Passwordkey, Password);
        }

        public User()
        {
            Name = Preferences.Get(keys.Namekey, string.Empty);
        }
    }
}
