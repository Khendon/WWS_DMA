using System;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WWS_DMA.Domain.Entities
{
    public class ClientDetail
    {
        // Fields
        [Key()]
        public int ClientID { get; set; }

        [Required()]
        [StringLength(30, MinimumLength=1)]
        [Display(Name="Client")]
        public string Name { get; set; }

        [Required()]
        [StringLength(30, MinimumLength=1)]
        public string Country { get; set; }


        // Navigation Properties
        public virtual ICollection<JobDetail> JobDetails { get; set; }
    }
}
