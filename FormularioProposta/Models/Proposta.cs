using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioProposta.Models
{
    public class Proposta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo 'Nome' é obrigatório")]
        [MaxLength(50)]
        public string NomeCliente { get; set; }   
        

        [Required(ErrorMessage ="O Campo 'Telefone' é obrigatório")]
        [MaxLength(11)]
        [Phone]
        public string Telefone { get; set; }
        
        [Required(ErrorMessage = "O Campo 'E-mail' é obrigatório")]
        [MaxLength(70)]
        [EmailAddress]
        public string EmailCliente { get; set; }

        [Required(ErrorMessage = "O Campo 'Renda Mensal' é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public decimal ValorRenda { get; set; }

        [Required(ErrorMessage = "O Campo 'Mensagem' é obrigatório")]
        [MaxLength(2000)]
        public string Mensagem { get; set; }
        public DateTime DataProposta { get; set; } = DateTime.Now;

        public bool Visualizado { get; set; } = false; 
    }
}
