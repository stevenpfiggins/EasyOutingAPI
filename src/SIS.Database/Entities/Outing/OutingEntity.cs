using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Outing
{
    public class OutingEntity
    {
        [Key]
        public int OutingEntityId { get; set; }

        [Required]
        public string OutingName { get; set; }

        [Required]
        public string OutingDescription { get; set; }

        [Required]
        public string OutingLocation { get; set; }

        [Required]
        public DateTimeOffset OutingDate { get; set; }

        [Required]
        public string OutingType { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedOn { get; set; }

        [Required]
        public int OwnerId { get; set; }
    }
}
