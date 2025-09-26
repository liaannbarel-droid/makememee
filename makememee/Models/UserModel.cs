namespace makememee.Models
{
    internal abstract class UserModel
    {
        public bool IsRegister=>!string.IsNullOrWhiteSpace(Name);
        public string Name { get; set; }=string.Empty;
        public string Password { get; set; }=string.Empty;
        public string Email { get; set; }=string.Empty;
        public abstract void Register();
    }
}
