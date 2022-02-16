using System;
using System.Linq;
namespace WaterProject.Models
{
    public class EFWaterProjectRepository: IWaterProjectRepository
    {
        private WaterProjectContext context { get; set; }
        
        public EFWaterProjectRepository(WaterProjectContext temp)
        {
            context = temp;
        }
        public IQueryable<Project> Projects => context.Projects;
    }
}
