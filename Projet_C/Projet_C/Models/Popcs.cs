using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;

namespace Projet_C.Models
{
    public class Popcs
    {
        public int Id { get; set; }

       [Required] public int Nbre_pop { get; set; }

        [Required] public int Annee { get; set; }
        
        [ ForeignKey("Country")] public int Id_country { get; set; }

        
    }
}
