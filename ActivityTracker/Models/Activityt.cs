using System;
using System.ComponentModel.DataAnnotations;

namespace ActivityTracker.Models
{
    public class Activityt
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

    }
}
