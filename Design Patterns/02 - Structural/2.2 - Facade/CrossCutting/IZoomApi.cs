namespace DesignPatterns._02___Structural._2._2___Facade.CrossCutting
{
    public interface IZoomApi
    {
        bool CreateMeeting(string topic, string agenda, DateTime start_time, DateTime end_time);
    }
}
