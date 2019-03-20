using System.Collections.Generic;
using Business;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace Facade.Controllers
{
    [Route("api/cases")]
    [ApiController]
    public class CaseController : ControllerBase
    {
        private CaseDispatcher caseController;

        public CaseController()
        {
            caseController = new CaseDispatcher();
        }

        // GET api/cases
        [HttpGet]
        public ActionResult<List<Case>> GetCases()
        {
            return caseController.GetCases();
        }
    }
}
