using System;
using System.Collections.Generic;
using System.Text;
using Sameer.Shared.Data;
using Sgs.WorkProgram.Model;

namespace Sgs.WorkProgram.BusinessLogic
{
    public class SgsProgramsManager : GeneralManager<SgsProgram>
    {
        public SgsProgramsManager(IRepository repo) : base(repo)
        {
        }
    }
}
