using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamposDealer.Models
{
 //   [Keyless]
    public class Clientes
    {
        //[Required]

        //[Key]
        [DisplayName("ID")]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

       
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        public string nmCliente { get; set; }

        [DisplayName("Cidade")]
        public string nomeDaCidade { get; set; }
    }
}
