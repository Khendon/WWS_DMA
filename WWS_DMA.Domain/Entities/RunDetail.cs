using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web;

namespace WWS_DMA.Domain.Entities
{
    public class RunDetail
    {
        // Fields
        [Key()]
        public int RunID { get; set; }

        [Display(Name="Run No.")]
        [Range(0, 255)]
        public int RunNum { get; set; }

        [Display(Name="RIH Date")]
        public DateTime RihDate { get; set; }

        [Display(Name="Sensor Depth")]
        [Range(0, 30000)]
        public int SensorDepth { get; set; }

        // Foreign Keys
        public int JobID { get; set; }

        // Navigation Properties
        public virtual JobDetail JobDetail { get; set; }
        public virtual Modelling ModelData { get; set; }
        public virtual ICollection<GaugeData> GaugeData { get; set; }
        public virtual ICollection<GaugeDetail> Gauges { get; set; }
    }
}
