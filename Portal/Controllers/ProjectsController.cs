using DataAccess;
using DataAccess.Interfaces;
using Entities;
using PioPortal.Mappers;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Project = PioPortal.ViewModels.Project;

namespace PioPortal.Controllers
{
    public class ProjectsController : ApiController
    {
        private readonly IDataManager<project> _manager; 
        public ProjectsController() : this(new ProjectManager())
        {
        }

        public ProjectsController(IDataManager<project> manager)
        {
            _manager = manager;
        }

        // C

        [HttpPost]
        [ResponseType(typeof(Project))]
        public HttpResponseMessage Create(Project newProject)
        {
            var projectToAdd = ProjectMapper.Map(newProject);

            var addedProject = Manager.Add(projectToAdd);

            return addedProject != null ? Request.CreateResponse(HttpStatusCode.Created, ProjectMapper.Map(Manager.Add(projectToAdd))) : Request.CreateResponse(HttpStatusCode.InternalServerError, newProject);
        }

        // R
        [HttpGet]
        [ResponseType (typeof(List<Project>))]
        public HttpResponseMessage Get(int? id = null)
        {
            if (id != null)
            {
                var project = Manager.GetOne(id.Value);
                return project == null ? Request.CreateResponse(HttpStatusCode.NotFound, new List<Project>()) : Request.CreateResponse(HttpStatusCode.OK, new List<Project>() {ProjectMapper.Map(project)});
            }

            var projects = Manager.GetAll();
            var viewModelProjects = projects != null ? ProjectMapper.Map(projects) : new List<Project>();
            return Request.CreateResponse(HttpStatusCode.OK, viewModelProjects);
        }

        [HttpPut]
        [ResponseType(typeof(bool))]
        public HttpResponseMessage Update(Project updatedProject)
        {
            var projectToUpdate = ProjectMapper.Map(updatedProject);
            var updateResult = Manager.Update(projectToUpdate);
            return !updateResult ? Request.CreateResponse(HttpStatusCode.NotFound, false) : Request.CreateResponse(HttpStatusCode.OK, true);
        }

        [HttpDelete]
        [ResponseType(typeof(bool))]
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(Manager.Delete(id) ? HttpStatusCode.OK : HttpStatusCode.NotFound);
        }

        private IDataManager<project> Manager { get { return _manager; } } 
    }
}
