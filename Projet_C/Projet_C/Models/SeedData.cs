using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Projet_C.Data;
using System;
using System.Linq;

namespace Projet_C.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Projet_CContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<Projet_CContext>>()))
            {
               // context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                // S’il y a déjà des films dans la base
                if (context.Continent.Any())
                {
                    return; // On ne fait rien
                }
                // Sinon on en ajoute un
                context.Continent.AddRange(
                new Continent
                {
                    Name = "Africa",
                    List_Country =  new List<Country> { }
                }
                );


                if (context.Country.Any())
                {
                    return; // On ne fait rien
                }
                // Sinon on en ajoute un
                context.Country.AddRange(
                new Country
                {
                    Country_name = "Cameroon",
                    Id_Continent = 1
                }
                );


                if (context.Popcs.Any())
                {
                    return; // On ne fait rien
                }
                // Sinon on en ajoute un
                context.Popcs.AddRange(
                new Popcs
                {
                    Nbre_pop = 20000000,
                    Annee=2023,
                    Id_country=1

                }
                );
                context.SaveChanges();
            }
        }
    }
}
