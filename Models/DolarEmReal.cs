using System.ComponentModel.DataAnnotations;

namespace Exercicios.Models
{
    public class DolarEmReal
    {
        [Display(Name = "Valor da Cotação do Dólar")]
        [Required(ErrorMessage = "Informe o Valor da Cotação do Dólar")]
        [RegularExpression(@"^\d+,?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
        public double Cotacao { get; set; }

        [Display(Name = "Quantidade de Dólares")]
        [Required(ErrorMessage = "Informe a Quantidade de Dólares")]
        [RegularExpression(@"^\d+,?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
        public double QuantidadeDolar { get; set; }

        [Display(Name = "Valor em Reais")]
        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public double ValorEmReal { get => Calcular(); }

        private double Calcular()
        {
            return Cotacao * QuantidadeDolar;
        }
    }
}