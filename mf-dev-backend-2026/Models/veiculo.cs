using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2026.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar nome ")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar Palca ")]

        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar Ano de Fabricação ")]

        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar Ano do Modelo ")]

        public int AnoModelo { get; set; }

        


    }
}
