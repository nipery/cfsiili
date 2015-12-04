using System;
using System.Security.AccessControl;

namespace CrossFitSiili.Models
{
    public class Wod
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PublishAt { get; set; }

        public DateTime Created { get; set; }

        public string User { get; set; }
    }
}