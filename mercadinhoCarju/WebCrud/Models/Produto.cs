using System.ComponentModel.DataAnnotations;

namespace WebCrud.Models
{
    public class Produto
    {
        [Display(Name = "Código do Produto")]   
        public int Prodid { get; set; }
        [Display(Name = "Nome do Produto")]
        public string ? Prodnome { get; set; }
        [Display(Name = "Preço do Produto")]
        public string? Prodpreco { get; set; }
        [Display(Name = "Quantidade no estoque")]
        public string? Prodqtd { get; set; }
        [Display(Name = "Descrição do Produto")]
        public string ? Proddescr { get; set; }
    }
}
