namespace DesignPatterns._02___Structural._2._2___Facade.CrossCutting
{
    public interface IZoomConfiguration
    {
        string GetValue(string value);
        bool ValidateToken(string token);
        string RefreshToken(string tokenExpired);
    }
}
