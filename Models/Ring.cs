using System.ComponentModel.DataAnnotations;

namespace AppTeste.Models {
    public class Ring {
        [Key]
        public int Id { get; set; }
        public required string Nome { get; set; } = string.Empty;
        public required string Poder { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [MaxLength(1000)]
        public string Portador { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [MaxLength(100)]
        [Display(Name ="Forjado ")]
        public required string ForjadoPor { get; set; } = string.Empty;
        public string Imagem { get; set; } = string.Empty;

    }
}

