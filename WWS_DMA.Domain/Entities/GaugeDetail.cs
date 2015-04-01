using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWS_DMA.Domain.Entities
{
    public class GaugeDetail
    {
        public int GaugeID { get; set; }
        public string SerialNum { get; set; }
        public string ProdStream { get; set; }
        public int RunsComplete { get; set; }
        public int MaxTempExp { get; set; }
        public TimeSpan TimeInHole { get; set; }
        public DateTime ManufactureDate { get; set; }
    }
}
