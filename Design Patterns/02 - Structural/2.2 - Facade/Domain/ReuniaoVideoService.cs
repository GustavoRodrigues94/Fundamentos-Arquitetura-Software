namespace DesignPatterns._02___Structural._2._2___Facade.Domain
{
    public class ReuniaoVideoService : IReuniaoVideoService
    {
        private readonly IReuniaoVideoFacade _reuniaoVideoFacade;

        public ReuniaoVideoService(IReuniaoVideoFacade reuniaoVideoFacade)
        {
            _reuniaoVideoFacade = reuniaoVideoFacade;
        }

        public Agenda AgendarReuniaoVideo(Agenda agenda)
        {
            Console.WriteLine($"Criando reunião de vídeo: {agenda.TituloAgenda}");

            if (!_reuniaoVideoFacade.AgendarReuniaoVideo(agenda))
            {
                agenda.Status = "Erro ao agendar reunião de vídeo";
                return agenda;
            }

            agenda.Status = $"Reunião de vídeo agendada. Início: {agenda.DataHoraInicio}. Término: {agenda.DataHoraFim}";
            return agenda;
        }
    }
}
