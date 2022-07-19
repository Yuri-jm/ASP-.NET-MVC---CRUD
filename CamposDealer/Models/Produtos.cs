using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamposDealer.Models
{
    //[Keyless]
    public class Produtos
    {
        //[Key][DisplayName("ID")]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DisplayName("Descrição")]
        public string dscProduto { get; set; }

        [DisplayName("Valor")]
        public float vlrUnitario { get; set; }

    }


}
