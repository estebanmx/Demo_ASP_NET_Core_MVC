using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC_Omar.Models
{
    public class Cliente
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int      Id      { get; set; }
            public string   Nombre  { get; set; }
            public int      Edad    { get; set; }

            [Display(Name ="Fecha Ingreso")]
            public DateTime FechaIngreso { get; set; }
    }
}
