using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WWS_DMA.WebUI.Models.Interfaces;
using WWS_DMA.WebUI.Models.Repositories;
using WWS_DMA.Domain.Concrete;


namespace WWS_DMA.WebUI.Controllers
{
    public class JobDetailController : Controller
    {
        private IJobDetailRepository jobDetailRepository;
        
        public JobDetailController()
        {
            this.jobDetailRepository = new JobDetailRepository(new AppDbContext());
        }

        // GET: JobDetail
        public ActionResult Index()
        {
            return View();
        }
    }
}