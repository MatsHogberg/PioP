using DataAccess.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    class PersonManager  : IDataManager<person>
    {
        public List<person> GetAll()
        {
            using (var db = new PIOEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.person.Include(p => p.carrerpath).ToList();
            }
        }

        public person GetOne(int id)
        {
            using (var db = new PIOEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.person.Include(p => p.carrerpath).SingleOrDefault(p => p.person_id == id);
            }
        }

        public person Add(person person)
        {
            try
            {
                using (var db = new PIOEntities())
                {
                    db.person.Add(person);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return GetOne(person.person_id);
        }

        public bool Update(person updatedPerson)
        {
            using (var db = new PIOEntities())
            {
                db.person.Attach(updatedPerson);
                db.Entry(updatedPerson).State = EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }

        public bool Delete(int id)
        {
            using (var db = new PIOEntities())
            {
                var personToRemove = db.person.Find(id);
                if (personToRemove == null)
                {
                    return false;
                }
                db.person.Remove(personToRemove);
                db.SaveChanges();
            }
            return true;
        }
    }
}
