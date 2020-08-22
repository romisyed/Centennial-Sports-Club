using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syed_Rumail.Models
{
    public class PlayerRepository : IPlayerRepository
    {
        private ApplicationDbContext context;

        public static List<Players> pl = new List<Players>();


        public PlayerRepository(ApplicationDbContext ctx) { context = ctx; }
        public IQueryable<Players> Player => context.players;


        public void SavePlayer(Players plr)
        {
            if (plr.PlayerId == 0)
            {
                context.players.Add(plr);
            }
            else
            {
                Players pEntry = context.players.FirstOrDefault(p => p.PlayerId == plr.PlayerId);

                if (pEntry != null)
                {
                    pEntry.Playername = pEntry.Playername;
                    pEntry.Club = pEntry.Club;
                }
            }
            context.SaveChanges();
        }



        public static IEnumerable<Players> Players
        {
            get
            {
                return pl;
            }
        }

        public static void ManagePlayersPage(Players playerResponses)
        {
            pl.Add(playerResponses);
        }


        public static List<Players> GetPlayer()
        {
            return pl;
        }
    }

}



