using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace WWS_DMA.Domain.Entities
{
    public class Modelling
    {
        // Fields
        [Key, ForeignKey("RunDetail")]
        public int RunID { get; set; }

        [Display(Name="Max Temperature")]
        [Range(0, 255)]
        public int MaxTemp { get; set; }

        [Display(Name="Max Pressure")]
        [Range(0, 30000)]
        public int MaxPres { get; set; }

        [RegularExpression(@"^\d+.\d{0,2}$")]
        [Range(0, 99999999.99)]
        [Display(Name="Duration (days)")]
        public decimal Duration { get; set; }

        [Display(Name="Points Expected")]
        public int NumPoints { get; set; }

        [Display(Name="T Period")]
        [Range(0, 255)]
        public int TPeriod { get; set; }

        // Navigation Properties
        public virtual RunDetail RunDetail { get; set; }

    }
}
