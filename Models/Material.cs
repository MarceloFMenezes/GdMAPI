using GdMAPI.Models.Enum;

namespace GdMAPI.Models
{
    public class Material
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Marca {get; set;}
        public string? Cor {get; set;}
        public TipoEnum Tipo {get; set;}
        public int Quantidade {get; set;}
        
    }
}