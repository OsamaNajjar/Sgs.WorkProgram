using System;
using Microsoft.EntityFrameworkCore;
using Sgs.WorkProgram.Model;

namespace Sgs.WorkProgram.DataAccess
{
    public class WorkProgramsDB : DbContext
    {
        public DbSet<SgsProgram> SgsPrograms { get; set; }

        public DbSet<MainProject> MainProjects { get; set; }
    }
}
