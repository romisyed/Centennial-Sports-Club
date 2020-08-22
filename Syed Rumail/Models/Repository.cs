using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syed_Rumail.Models
{
    //Clubs-> Responsible for adding clubs to the club page
    public class Repository : IClubRepository
    {
        private ApplicationDbContext context;

        public static List<Clubs> cResponses = new List<Clubs>();


        public Repository(ApplicationDbContext ctx) { context = ctx; }
        public IQueryable<Clubs> Club => context.Club;


        public void SaveClub(Clubs clubResponse)
        {
            if (clubResponse.Id == 0)
            {
                context.Club.Add(clubResponse);
            }
            else
            {
                Clubs clubEntry = context.Club.FirstOrDefault(p => p.Id == clubResponse.Id);

                if (clubEntry != null)
                {
                    clubEntry.Clubname = clubResponse.Clubname;
                    clubEntry.Tandc = clubResponse.Tandc;
                    clubEntry.PivacyPolicy = clubResponse.PivacyPolicy;
                    clubEntry.Location = clubResponse.Location;
                    
                }
            }
            context.SaveChanges();
        }

        public Clubs DeleteClub(int id)
        {
            Clubs clubDelete = context.Club.FirstOrDefault(p => p.Id == id);
            if (clubDelete != null)
            {
                context.Club.Remove(clubDelete);
                context.SaveChanges();
            }
            return clubDelete;
        }

        public static IEnumerable<Clubs> Clubs
        {
            get
            {
                return cResponses;
            }
        }

        public static void AddClub(Clubs clubResponse)
        {
            cResponses.Add(clubResponse);
        }


        public static List<Clubs> GetClub()
        {
            return cResponses;
        }
    }

}

