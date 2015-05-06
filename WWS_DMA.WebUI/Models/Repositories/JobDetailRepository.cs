using System;
using System.Collections.Generic;
using System.Data.Entity;
using WWS_DMA.Domain.Concrete;
using WWS_DMA.Domain.Entities;
using WWS_DMA.WebUI.Models.Interfaces;

namespace WWS_DMA.WebUI.Models.Repositories
{
    public class JobDetailRepository : IJobDetailRepository, IDisposable
    {
        private AppDbContext DbContext = null;

        public JobDetailRepository()
        {
            this.DbContext = new AppDbContext();
        }

        public JobDetailRepository(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public IEnumerable<JobDetail> GetJobDetails()
        {
            return DbContext.JobDetails;
        }

        public JobDetail GetJobDetailByID(int id)
        {
            return DbContext.JobDetails.Find(id);
        }

        public void InsertJobDetail(JobDetail jobDetail)
        {
            DbContext.JobDetails.Add(jobDetail);
        }

        public void DeleteJobDetail(int jobID)
        {
            JobDetail jobDetail = DbContext.JobDetails.Find(jobID);
            DbContext.JobDetails.Remove(jobDetail);
        }

        public void UpdateJobDetail(JobDetail jobDetail)
        {
            DbContext.Entry(jobDetail).State = EntityState.Modified;
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        
    }
}