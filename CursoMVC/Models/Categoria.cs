using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name="Descricao")]
        [Required(ErrorMessage ="O campo é obrigatório")]
        public string Descricao { get; set; }
        public List<Produto> Produto { get; set; }
    }
}
