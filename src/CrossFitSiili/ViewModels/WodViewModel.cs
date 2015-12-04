using System;
using System.ComponentModel.DataAnnotations;

namespace CrossFitSiili.ViewModels
{
    public class WodViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64,MinimumLength = 4)]
        public string Title { get; set; }

        [Required]
        [StringLength(1024,MinimumLength =2)]
        public string Description { get; set; }

        //[Required]
        public DateTime PublishAt { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        
    }
}