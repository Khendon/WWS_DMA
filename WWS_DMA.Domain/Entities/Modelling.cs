using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WWS_DMA.Domain.Entities
{
    public class Modelling
    {
        public int ModelID { get; set; }
        public int MaxTemp { get; set; }
        public int MaxPres { get; set; }
        public TimeSpan Duration { get; set; }
        public int NumPoints { get; set; }
        public int TPeriod { get; set; }
    }
}
