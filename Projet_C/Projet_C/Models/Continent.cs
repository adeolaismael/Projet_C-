using Microsoft.Build.Framework;

namespace Projet_C.Models
{
    public class Continent
    {   
        public int Id { get; set; }

        [Required]public string Name { get; set; }
        public ICollection <Country> List_Country { get; set; }
    }
}
