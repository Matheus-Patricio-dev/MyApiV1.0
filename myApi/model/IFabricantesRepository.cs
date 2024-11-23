namespace myApi.model
{
    public interface IFabricantesRepository
    {
        //metodo de adicionar
        void add(Fabricante fabricante);
        //Listando
        List<Fabricante> Get();
    }
}
