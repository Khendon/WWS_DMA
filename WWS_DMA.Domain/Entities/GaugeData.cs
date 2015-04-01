using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WWS_DMA.Domain.Entities
{
    public class GaugeData
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public decimal Pressure { get; set; }
        public decimal Temperature { get; set; }
    }
}
