using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web;

namespace WWS_DMA.Domain.Entities
{
    public class RunDetail
    {
        public int RunID { get; set; }
        public int RunNum { get; set; }
        public DateTime RihDate { get; set; }
        public int SensorDepth { get; set; }
    }
}
