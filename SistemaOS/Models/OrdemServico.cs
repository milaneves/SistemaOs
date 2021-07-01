using System;
using System.ComponentModel.DataAnnotations;


namespace SistemaOS.Models
{
    public class OrdemServico
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Número OS")]
        [Required(ErrorMessage = "Informe o numero da OS")]
        public int NumeroOS { get; set; }

        [Display(Name = "Título do Serviço")]
        [Required(ErrorMessage = "Informe o título")]
        public string TituloServico { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Informe o nome do cliente")]
        public string NomeCliente { get; set; }

        [Display(Name = "CNPJ do cliente")]
        [Required(ErrorMessage = "informe o CNPJ do cliente")]
        public string CNPJCliente { get; set; }

        [Display(Name = "Nome do Prestador")]
        [Required(ErrorMessage = "Informe o nome do prestador")]
        public string NomePrestador { get; set; }

        [Display(Name = "CPF do prestador")]
        [Required(ErrorMessage = "Informe o CPF do prestador")]
        public string CPFPrestador { get; set; }

        [Display(Name = "Data Execução")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataExecucao { get; set; }

        [Display(Name = "Valor")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
    }
}
