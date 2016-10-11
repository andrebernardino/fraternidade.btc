using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace fraternidade.btc.Models
{
    [Table("EnderecoBitcoin")]
    public class EnderecoBitcoin
    {
        [Key]
        public int IdEndereco { get; set; }
        public string endereco { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}