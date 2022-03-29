using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingRoster.Models
{
    public interface IBowlersRepository
    {
        //MIGHT NEED TO CHANGE THIS TO SET ALSO IF CONTEXT DOESN'T UPDATE?
        IQueryable<Bowler> Bowlers { get; }
        IQueryable<Team> Teams { get; }

        void SaveBowler(Bowler bowler);
        void AddBowler(Bowler bowler);
        void DeleteBowler(Bowler bowler);
    }
}
