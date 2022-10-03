using DesignPatterns._02___Structural._2._2___Facade.CrossCutting;

namespace DesignPatterns._02___Structural._2._2___Facade.Domain
{
    public class ReuniaoVideoFacade : IReuniaoVideoFacade
    {
        private readonly IZoomApi _zoomApi;

        public ReuniaoVideoFacade(IZoomApi zoomApi)
        {
            _zoomApi = zoomApi;
        }

        public bool AgendarReuniaoVideo(Agenda agenda)
        {
            var reuniaoVideoCriada =  _zoomApi.CreateMeeting(agenda.TituloAgenda, agenda.TituloAgenda, agenda.DataHoraInicio, agenda.DataHoraFim);
            return reuniaoVideoCriada;
        }
    }
}
