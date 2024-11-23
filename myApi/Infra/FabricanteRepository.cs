using Microsoft.EntityFrameworkCore;
using myApi.model;

namespace myApi.Infra
{
    public class FabricanteRepository : IFabricantesRepository
    {

        private readonly ConnectionContext _context = new ConnectionContext();

        public void add(Fabricante fabricante)
        {
            //Adicionando coisas
            try
            {
                _context.Fabricantes.Add(fabricante);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
                // Aqui você pode exibir mais detalhes, como ex.Message ou ex.StackTrace
            }
        }

        public List<Fabricante> Get()
        {
            return _context.Fabricantes.ToList();
        }
    }
}
