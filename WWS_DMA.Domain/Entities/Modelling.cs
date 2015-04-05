using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WWS_DMA.Domain.Entities
{
    public class Modelling
    {
        // Fields
        [Key()]
        public int ModelID { get; set; }

        [Display(Name="Max Temperature")]
        [Range(0, 255)]
        public int MaxTemp { get; set; }

        [Display(Name="Max Pressure")]
        [Range(0, 30000)]
        public int MaxPres { get; set; }

        public long Duration { get; set; }

        [Display(Name="Points Expected")]
        public int NumPoints { get; set; }

        [Display(Name="T Period")]
        [Range(0, 255)]
        public int TPeriod { get; set; }
    }
}
