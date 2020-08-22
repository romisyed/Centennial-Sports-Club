using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace Syed_Rumail.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Club.Any())
            {
                context.Club.AddRange(
                new Clubs
                {
                    Clubname = "Angels",
                    Tandc = "Terms",
                    PivacyPolicy = "strict policies",
                    Location = "Canada"
                },
                new Clubs
                {
                    Clubname = "Lions",
                    Tandc = "Conditions",
                    PivacyPolicy = "strict policies",
                    Location = "Canada"
                },
                new Clubs
                {
                    Clubname = "Kings",
                    Tandc = "Archu",
                    PivacyPolicy = "strict policies",
                    Location = "Canada"
                }
                );
                context.SaveChanges();
            }
        }
    }
}
