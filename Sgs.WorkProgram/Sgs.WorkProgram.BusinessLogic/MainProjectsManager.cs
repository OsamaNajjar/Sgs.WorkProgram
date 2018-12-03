using System;
using Sameer.Shared.Data;
using Sgs.WorkProgram.Model;

namespace Sgs.WorkProgram.BusinessLogic
{
    public class MainProjectsManager : GeneralManager<MainProject>
    {
        public MainProjectsManager(IRepository repo) : base(repo)
        {
        }
    }
}
