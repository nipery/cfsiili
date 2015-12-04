using System;
using System.Linq;

namespace CrossFitSiili.Models
{
    public class WodSeed
    {
        private readonly CfSiiliContext _context;

        public WodSeed(CfSiiliContext context)
        {
            _context = context;
        }

        public void EnsureSeedData()
        {
            if (!_context.Wods.Any())
            {
                _context.Add(new Wod
                {
                    Title = "PERJANTAI 4.12.2015",
                    Description = "Back squat 3-2-1-1-1",
                    Created = DateTime.Now,
                    PublishAt = DateTime.Today.AddHours(19)
                });
                _context.SaveChanges();
            }
        }
    }
}