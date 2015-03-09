using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PioPortal.Controllers;
using PioPortal.ViewModels;

namespace Tests
{
    /*
    // todo: Hitta ett bra sätt att unit-testa controller som returnerar HttpResponseMessage
    [TestClass]
    public class ProjectControllerTests
    {
        private PioPortal.Controllers.ProjectsController _controller;
        [TestMethod]
        public void TestGetAllProjects()
        {
            var projects = Controller.Get();

            Assert.IsInstanceOfType(projects, typeof(List<PioPortal.ViewModels.Project>));
        }

        [TestMethod]
        public void TestCRUD()
        {
            Controller.Request = new HttpRequestMessage();
            Controller.Configuration = new HttpConfiguration();

            const string newNamePrefix = "Nytt namn:";

            List<Project> projectList;

            Project project;

            var projToAdd = GenerateProject();

            var projectName = projToAdd.Name;

            // C
            var response = Controller.Create(projToAdd);

            Assert.AreSame(response, typeof(HttpResponseMessage));

            Assert.IsTrue(response.TryGetContentValue<Project>(out project));

            Assert.AreNotEqual(projToAdd.Id, project.Id);

            Assert.AreEqual(projectName, project.Name);

            //R
            response = Controller.Get(project.Id);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

 
            Assert.IsTrue(response.TryGetContentValue<List<Project>>(out projectList));
            Assert.AreEqual(1, projectList.Count);

            var projectReadFromRepo = projectList[0];
            Assert.AreEqual(project.Id, projectReadFromRepo.Id);
            Assert.AreEqual(project.Code, projectReadFromRepo.Code);
            //TODO: Continue testing various properties to make sure both objects are the same

            //U
            projectReadFromRepo.Name = newNamePrefix + projectReadFromRepo.Name;
            response = Controller.Update(projectReadFromRepo);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);


            response  = Controller.Get(projectReadFromRepo.Id);

            Assert.IsTrue(response.TryGetContentValue<List<Project>>(out projectList));
            Assert.AreEqual(1, projectList.Count);

            projectReadFromRepo = projectList[0];
            Assert.IsTrue(projectReadFromRepo.Name.StartsWith(newNamePrefix));

            //D
            response = Controller.Delete(projectReadFromRepo.Id);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            response  = Controller.Get(projectReadFromRepo.Id);
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            Assert.IsTrue(response.TryGetContentValue<List<Project>>(out projectList));
            Assert.AreEqual(0, projectList.Count);
        }

        public void FixEfProviderServicesProblem()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        private ProjectsController Controller
        {
            // TODO: Skapa ett mock-repository och injekta i controllern
            get { return _controller ?? (_controller = new ProjectsController()); }
        }

        private PioPortal.ViewModels.Project GenerateProject(int id = 7)
        {
            return new PioPortal.ViewModels.Project
                {
                    AdminLevel = 1,
                    BusinessManager.Id = 3,
                    Code = "6665666",
                    Customer.Id = 18,
                    EndDate = new DateTime(2020, 12, 31),
                    Id = id,
                    Name = "TestProjekt",
                    ProjectManagerId = 4,
                    SiteId = 1,
                    StartDate = DateTime.Now
                };
        }
    }
     * */
}
