namespace SOLID._4___ISP.ISP.Violacao
{
    public class ClienteRepository : IRepository
    {
        public void Adicionar()
        {
            // Adicionar o cliente
        }

        public void Atualizar()
        {
            // Atualizar o cliente
        }

        public void Deletar()
        {
            // Deletar o cliente
        }

        public void ObterDadosFiltrando()
        {
            // Não preciso paginar os clientes, logo, não irei implementar esse método
            throw new NotImplementedException();
        }
    }
}
