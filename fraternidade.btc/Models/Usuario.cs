using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace fraternidade.btc.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IDUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtivacao { get; set; }

        public virtual ICollection<EnderecoBitcoin> EnderecosBitcoin { get; set; }
    }
}