using System.Collections.Generic;
using System.Linq;
using PioPortal.ViewModels;
using Project = PioPortal.ViewModels.Project;

namespace PioPortal.Mappers
{
    internal class ProjectMapper
    {
        public static Project Map(Entities.project @from)
        {
            var to = new Project
                {
                    AdminLevel = @from.adm_level,
                    BusinessManager = ManagerMapper.Map(@from.businessManager),
                    Code = @from.code,
                    Customer = new Customer{Id = @from.customer.customer_Id, Name = @from.customer.name},
                    EndDate = @from.end,
                    Id = @from.project_Id,
                    Name = @from.name,
                    ProjectManager = ManagerMapper.Map(@from.projectManager),
                    Site =SiteMapper.Map(@from.site),
                    StartDate = @from.start,
                    Meetings = MeetingMapper.Map(@from.meeting)
                };
            return to;
        }
        internal static List<Project> Map(List<Entities.project> projectList)
        {
            return projectList.Select(Map).ToList();
        }

        internal static Entities.project Map(Project @from)
        {
            var to = new Entities.project
                {
                    adm_level = @from.AdminLevel,
                    buisness_manager = @from.BusinessManager.Id,
                    code = @from.Code,
                    customer_Id = @from.Customer.Id,
                    end = @from.EndDate,
                    name = @from.Name,
                    project_Id = @from.Id,
                    project_manager = @from.ProjectManager.Id,
                    site_Id = @from.Site.Id,
                    start = @from.StartDate
                };
            return to;
        }
    }
}
