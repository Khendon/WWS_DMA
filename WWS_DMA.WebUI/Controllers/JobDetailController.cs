using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WWS_DMA.WebUI.Models.Interfaces;
using WWS_DMA.WebUI.Models.Repositories;
using WWS_DMA.Domain.Entities;
using System.Data;

namespace WWS_DMA.WebUI.Controllers
{
    public class JobDetailController : Controller
    {
        private IJobDetailRepository repository = null;
        public int PageSize = 5;

        public JobDetailController()
        {
            this.repository = new JobDetailRepository();
        }

        public JobDetailController(IJobDetailRepository repository)
        {
            this.repository = repository;
        }


        // GET
        public ViewResult Index()
        {
            var jobs = repository.GetJobDetails();                
            return View(jobs);
        }

        public ActionResult New()
        {
            List<SelectListItem> clientNames = new List<SelectListItem>();

            var clients = repository.GetClientDetails();

            foreach (var client in clients)
            {
                clientNames.Add(new SelectListItem { Text = client.Name + " " + client.Country });
            }

            ViewBag.Clients = clientNames;
            return View();
        }

        // POST
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

        public ActionResult ConfirmDelete(int id)
        {
            JobDetail existing = repository.GetJobDetailByID(id);
            return View(existing);
        }

        public ActionResult Delete(int id)
        {
            repository.DeleteJobDetail(id);
            repository.Save();
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult New([Bind(Include = "JobNumber, ClientID, FieldName, WellName, Product, InstallDate, NumRuns")]JobDetail jobDetail)
        {
            try
            {
                repository.InsertJobDetail(jobDetail);
                repository.Save();
                return RedirectToAction("Index");

            }
            catch (DataException /*dex */)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }

            return View(jobDetail);
        }







    }
}