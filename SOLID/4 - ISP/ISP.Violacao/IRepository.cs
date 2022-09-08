namespace SOLID._4___ISP.ISP.Violacao
{
    public interface IRepository
    {
        void Adicionar();
        void Atualizar();
        void Deletar();
        void ObterDadosFiltrando();
    }
}
