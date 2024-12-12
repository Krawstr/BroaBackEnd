using System.ComponentModel.DataAnnotations;


namespace BroaBackEnd.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Required]
        public int Quantidade { get; set; }

    }
}
