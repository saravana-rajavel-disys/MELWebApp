namespace BusinessLayer.Interfaces.Login
{
    public interface IValidateLogin
    {
        bool IsValid(string userName, string password);
    }
}
