namespace Projet_C.Models
{
    public class Continent
    {   
        public int Id { get; set; }
        public ICollection <Country> Country { get; set; }
    }
}
