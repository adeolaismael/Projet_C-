using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_C.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Country_name { get; set; }

        [ForeignKey("Continent")] public int Id_Continent { get; set; }
    }
}
