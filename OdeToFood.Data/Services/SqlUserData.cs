using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class SqlUserData : IUserData
    {
        private readonly OdeToFood1DbContext db;
        public SqlUserData(OdeToFood1DbContext db)
        {
            this.db = db;
        }
        public void Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return from r in db.Users
                   orderby r.Id
                   select r;
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
