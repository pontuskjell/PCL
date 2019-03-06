using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace PCL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public Get Getter;
        public Datacontext db;

        public ValuesController()
        {
            db = new Datacontext();
            this.Getter = new Get();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<Hello> Get()
        {
            return Getter.GetHello();
        }

        // GET api/values
        [HttpGet]
        [Route("api/Cases")]
        public ActionResult<List<Case>> GetCases()
        {
            var Case = (from cases in db.Case select cases).FirstOrDefault();
            int newValue = 0;
            int.TryParse(Case.CaseNumber, out newValue);
            newValue += 1;
            Case.CaseNumber = newValue.ToString();

            db.SaveChanges();
            return (from cases in db.Case select cases).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "hej";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
