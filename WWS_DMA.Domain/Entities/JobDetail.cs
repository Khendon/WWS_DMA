using System;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace WWS_DMA.Domain.Entities
{
    public class JobDetail
    {
        public int JobID { get; set; }
        public int JobNumber { get; set; }
        public string FieldName { get; set; }
        public string WellName { get; set; }
        public string Product { get; set; }
        public DateTime InstallDate { get; set; }
        public int NumRuns { get; set; }

        public int ClientID { get; set; }
        public virtual ICollection<RunDetail> RunDetails { get; set; }
    }
}
