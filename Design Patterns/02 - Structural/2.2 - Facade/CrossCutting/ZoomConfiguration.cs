namespace DesignPatterns._02___Structural._2._2___Facade.CrossCutting
{
    public class ZoomConfiguration : IZoomConfiguration
    {
        public string GetValue(string node) =>
            new(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());

        public bool ValidateToken(string token) => false;

        public string RefreshToken(string tokenExpired) => new(Enumerable
            .Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
            .Select(s => s[new Random().Next(s.Length)]).ToArray());
    }
}
