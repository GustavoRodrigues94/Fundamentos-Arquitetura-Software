namespace DesignPatterns._02___Structural._2._2___Facade.Domain
{
    public class Agenda
    {
        public Guid Id { get; set; }
        public string TituloAgenda { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public string Status { get; set; }
    }
}
