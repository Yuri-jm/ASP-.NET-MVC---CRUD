using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamposDealer.Models
{
    //[Keyless]
    public class Vendas
    {
        //[Key][DisplayName("ID")]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DisplayName("ID do cliente")]
        

        public string idCliente { get; set; }

        [DisplayName("ID do produto")]
        public int IdProduto { get; set; }

        [DisplayName("Quantidade")]
        public int qtdVenda { get; set; }

        [DisplayName("Valor unitário")]
        public float vlrUnitarioVenda { get; set; }

        [DisplayName("Data")]
        public DateTime dthVenda { get; set; } = DateTime.Now;

        [DisplayName("Valor total")]
        public float vlrTotalVenda { get; set; }
    }
}