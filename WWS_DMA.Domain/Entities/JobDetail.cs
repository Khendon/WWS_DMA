using System;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace WWS_DMA.Domain.Entities
{
    public class JobDetail
    {
        // Fields
        [Key()]
        public int JobID { get; set; }

        [Required()]
        [Display(Name="Job Number")]
        public int JobNumber { get; set; }

        [Required()]
        [Display(Name="Field")]
        [StringLength(30, MinimumLength=2)]
        public string FieldName { get; set; }

        [Required()]
        [Display(Name="Well")]
        [StringLength(30, MinimumLength=2)]
        public string WellName { get; set; }

        [Required()]
        [StringLength(30, MinimumLength=2)]
        public string Product { get; set; }

        [Display(Name="Installation Date")]
        public DateTime InstallDate { get; set; }

        [Display(Name="Runs")]
        [Range(0, 255)]
        public int NumRuns { get; set; }

        // Foreign Keys
        public int ClientID { get; set; }

        // Navigation Properties
        public virtual ClientDetail ClientDetail { get; set; }
        public virtual ICollection<RunDetail> RunDetails { get; set; }
    }
}
