using DesignPatterns._02___Structural._2._2___Facade.CrossCutting;
using DesignPatterns._02___Structural._2._2___Facade.Domain;

namespace DesignPatterns._02___Structural._2._2___Facade
{
    public class ExecucaoFacade
    {
        public static void Executar()
        {
            var agenda = new Agenda
            {
                Id = Guid.NewGuid(),
                TituloAgenda = "Reunião confirmação de contrato",
                Status = "Iniciando agendamento",
                DataHoraInicio = DateTime.Now,
                DataHoraFim = DateTime.Now.AddHours(1)
            };


            // Resolver com DI
            var reuniaoVideoService = new ReuniaoVideoService(new ReuniaoVideoFacade(new ZoomApi(new ZoomConfiguration())));

            var agendamentoResultado = reuniaoVideoService.AgendarReuniaoVideo(agenda);

            Console.WriteLine(agendamentoResultado.Status);
        }
    }
}
