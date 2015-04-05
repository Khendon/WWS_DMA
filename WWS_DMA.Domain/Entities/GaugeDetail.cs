using System;
using System.ComponentModel.DataAnnotations;

namespace WWS_DMA.Domain.Entities
{
    public class GaugeDetail
    {
        // Fields
        [Key()]
        public int GaugeID { get; set; }

        [Required()]
        [Display(Name="Serial No.")]
        [StringLength(20, MinimumLength=4)]
        public string SerialNum { get; set; }

        [Required()]
        [Display(Name="Product Stream")]
        [StringLength(20, MinimumLength=3)]
        public string ProdStream { get; set; }

        [Display(Name="Total Runs")]
        [Range(0, 255)]
        public int RunsComplete { get; set; }
        
        [Range(0, 255)]
        public int MaxTempExp { get; set; }

        public long TimeInHole { get; set; }

        public DateTime ManufactureDate { get; set; }
    }
}
