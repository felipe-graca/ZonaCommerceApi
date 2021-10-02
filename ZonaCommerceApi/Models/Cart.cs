using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ZonaCommerceApi.Models
{
    public class Cart
    {
        [Key]
        public int idItem { get; set; }
        public int idProduto { get; set; }
        public int quantidadeProduto { get; set; }
        public double valorProduto { get; set; }

    }
}
