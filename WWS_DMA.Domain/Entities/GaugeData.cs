using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WWS_DMA.Domain.Entities
{
    public class GaugeData
    {
        // Fields
        [Key()]
        public int ID { get; set; }

        [Required()]
        public DateTime TimeStamp { get; set; }

        [RegularExpression(@"^\d+.\d{0,2}$")]
        [Range(0, 99999.99)]
        public decimal Pressure { get; set; }

        [RegularExpression(@"^\d+.\d{0,2}$")]
        [Range(0, 99999.99)]
        public decimal Temperature { get; set; }

        public bool IsSro { get; set; }
    }
}
