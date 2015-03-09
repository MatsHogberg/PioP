using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Interfaces;
using Entities;
using System.Data.Entity;

namespace DataAccess
{
    public class ProjectManager : IDataManager<project>
    {
        public List<project> GetAll()
        {
            using (var db = new PIOEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return
                    db.project.Include(p => p.customer)
                      .Include(p => p.site)
                      .Include(p => p.businessManager)
                      .Include(p => p.projectManager)
                      .Include(p => p.meeting.Select(m => m.person))
                      .Include(p => p.meeting.Select(m => m.meetingtype))
                      .Include(p => p.meeting.Select(m => m.room))
                      .Include(p => p.meeting.Select(m => m.room.site))
                      .Include(p => p.meeting.Select(m =>m.meetingtype))
                      .ToList();
            }
        }

        public project GetOne(int projectId)
        {
            using (var db = new PIOEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return
                    db.project.Include(p => p.customer)
                      .Include(p => p.site)
                      .Include(p => p.businessManager)
                      .Include(p => p.projectManager)
                      .Include(p => p.meeting.Select(m => m.person))
                      .Include(p => p.meeting.Select(m => m.meetingtype))
                      .Include(p => p.meeting.Select(m => m.room))
                      .Include(p => p.meeting.Select(m => m.room.site))
                      .Include(p => p.meeting.Select(m => m.meetingtype))
                      .SingleOrDefault(p => p.project_Id == projectId);
            }
        }

        public project Add(project proj)
        {
            try
            {
                using (var db = new PIOEntities())
                {
                    db.project.Add(proj);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                return null;
            }

            return GetOne(proj.project_Id);
        }

        public bool Update(project updatedProject)
        {
            try
            {
                using (var db = new PIOEntities())
                {
                    db.project.Attach(updatedProject);
                    db.Entry(updatedProject).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new PIOEntities())
            {
                var projectToRemove = db.project.Find(id);
                if (projectToRemove == null)
                {
                    return false;
                }
                db.project.Remove(projectToRemove);
                db.SaveChanges();
            }
            return true;
        }
    }
}
