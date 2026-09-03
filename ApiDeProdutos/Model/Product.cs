using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDeProdutos.Model
{
    [Table("Products")]
    public class Product
    {
        

        [Column("id")]
        [Key]
        [Required]
        public int Id { get; set; }
        [Column("nome")]
        [Required]
        public string Name { get; set; }
        [Column("price")]
        [Required]
        public decimal Price { get; set; }
        [Column("categoria")]
        [Required]
        public string Category { get; set; } 


    }
}
