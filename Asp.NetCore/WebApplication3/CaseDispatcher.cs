using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business
{
    public class CaseDispatcher
    {
        private Datacontext db;

        public CaseDispatcher()
        {
            db = new Datacontext();
        }

        public List<Case> GetCases()
        {
            return (from cases in db.Case select cases).ToList();
        }
    }
}
