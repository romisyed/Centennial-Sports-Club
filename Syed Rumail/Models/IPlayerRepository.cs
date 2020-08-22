using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syed_Rumail.Models
{
    public interface IPlayerRepository
    {
        IQueryable<Players> Player { get; }

        void SavePlayer(Players playerResponse);
    }
}
