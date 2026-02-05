using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_cadastro_materiais.DTO
{
    public class Material
    {
        public int Id { get; set; }
        public string Codigo_Barra { get; set; }
        public string Codigo_Material { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
    }
}
