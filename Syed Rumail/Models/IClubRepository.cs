using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syed_Rumail.Models
{
    public interface IClubRepository
    {
        IQueryable<Clubs> Club { get; }

        void SaveClub(Clubs clubResponse);

        Clubs DeleteClub(int id);

    }
}
