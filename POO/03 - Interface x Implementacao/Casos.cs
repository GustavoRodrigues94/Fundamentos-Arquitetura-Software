namespace POO
{
   public interface IRepositorio
   {
       void Adicionar();
   }

   public class Repositorio : IRepositorio
   {
       public void Adicionar()
       {
           // Adicionar item
       }
   }

   // princípio do acoplamento
   public class UsoImplementacao
   {
       public void Adicionar()
       {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
       }
   }
    
   // sempre prefira o uso de interfaces em vez de classes concretas
   public class UsoAbstracao
   {
       private readonly IRepositorio _repositorio;

       public UsoAbstracao(IRepositorio repositorio)
       {
           _repositorio = repositorio;
       }

       public void Adicionar()
       {
           _repositorio.Adicionar();
       }
   }
}
