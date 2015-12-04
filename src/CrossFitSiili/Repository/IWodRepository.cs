using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrossFitSiili.Models;
using Microsoft.Data.Entity;

namespace CrossFitSiili.Repository
{
    public interface IWodRepository
    {
        Task<IEnumerable<Wod>> GetWods();
        Task<bool> AddWod(Wod wod);
    }

    class WodRepository : IWodRepository
    {
        private readonly CfSiiliContext _context;

        public WodRepository(CfSiiliContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Wod>> GetWods()
        {
            return await _context.Wods.OrderByDescending(t => t.PublishAt).ToListAsync().ConfigureAwait(false);
        }

        public async Task<bool> AddWod(Wod wod)
        {
            _context.Wods.Add(wod);
            var i = await _context.SaveChangesAsync().ConfigureAwait(false);
            return i > 0;
        }
    }
}