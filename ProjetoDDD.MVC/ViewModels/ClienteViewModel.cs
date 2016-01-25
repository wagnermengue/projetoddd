using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Tamanho máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Tamanho mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Tamanho máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Tamanho mínimo {0} caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo {0} caracteres")]
        [MinLength(6, ErrorMessage = "Tamanho mínimo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        //public virtual IEnumerable<Produto> Produtos { get; set; }
    }
}