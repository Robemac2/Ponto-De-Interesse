using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Entities
{
    [Table("Ponto-De-Interesse")]
    public class PontoDeInteresse
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Nome")]
        [MaxLength(50)]
        [Required]
        public required string Nome { get; set; }

        [Column("CoordenadaX")]
        [Range(0, int.MaxValue)]
        [Required]
        public int CoordenadaX { get; set; }

        [Column("CoordenadaY")]
        [Range(0, int.MaxValue)]
        [Required]
        public int CoordenadaY { get; set; }
    }
}