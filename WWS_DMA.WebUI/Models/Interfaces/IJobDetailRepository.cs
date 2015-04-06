using System;
using System.Collections.Generic;
using WWS_DMA.WebUI.Models.Repositories;
using WWS_DMA.Domain.Entities;

namespace WWS_DMA.WebUI.Models.Interfaces
{
    public interface IJobDetailRepository : IDisposable
    {
        IEnumerable<JobDetail> GetJobDetails();
        JobDetail GetJobDetailByID(int JobID);
        void InsertJobDetail(JobDetail JobDetail);
        void DeleteJobDetail(int JobID);
        void UpdateJobDetail(JobDetail JobDetail);
        void Save();
    }
}