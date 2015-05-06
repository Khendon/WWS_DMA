using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WWS_DMA.WebUI.Models.Interfaces;
using WWS_DMA.WebUI.Models.Repositories;
using WWS_DMA.Domain.Entities;

namespace WWS_DMA.WebUI.Controllers
{
    public class JobDetailController : Controller
    {
        private IJobDetailRepository repository = null;

        public JobDetailController()
        {
            this.repository = new JobDetailRepository();
        }

        public JobDetailController(IJobDetailRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var jobs = repository.GetJobDetails();

            return View(jobs);
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Insert(JobDetail job)
        {
            repository.InsertJobDetail(job);
            repository.Save();
            return View();
        }

        public ActionResult Edit(int id)
        {
            JobDetail existing = repository.GetJobDetailByID(id);
            return View(existing);
        }

        public ActionResult Update(JobDetail job)
        {
            repository.UpdateJobDetail(job);
            repository.Save();
            return View();
        }







    }
}