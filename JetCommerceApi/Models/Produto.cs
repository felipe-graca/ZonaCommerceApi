using System.ComponentModel.DataAnnotations;

namespace JetCommerceApi
{
    public class Produto
    {
        [Key]
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public double valorProduto { get; set; }
        public string urlImg { get; set; }

    }
}
