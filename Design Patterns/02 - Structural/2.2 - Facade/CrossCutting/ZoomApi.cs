namespace DesignPatterns._02___Structural._2._2___Facade.CrossCutting
{
    public class ZoomApi : IZoomApi
    {
        private readonly IZoomConfiguration _zoomConfiguration;

        public ZoomApi(IZoomConfiguration zoomConfiguration)
        {
            _zoomConfiguration = zoomConfiguration;
        }

        public bool CreateMeeting(string topic, string agenda, DateTime start_time, DateTime end_time)
        {
            var token = _zoomConfiguration.GetValue("token");
            if (!_zoomConfiguration.ValidateToken(token))
                token = _zoomConfiguration.RefreshToken(token);

            return !string.IsNullOrWhiteSpace(token);
        }
    }
}
