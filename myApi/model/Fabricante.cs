using System.ComponentModel.DataAnnotations;

namespace myApi.model
{
    public class Fabricante
    {
        [Key]
        public int id_fabricante { get; private set; }
        public string nome { get; private set; } 
        public string pais_origem { get; private set; }

        public Fabricante(int id_fabricante, string nome, string pais_origem)
        {
            this.id_fabricante = id_fabricante;
            this.nome = nome;
            this.pais_origem = pais_origem;
        }
    }
}
