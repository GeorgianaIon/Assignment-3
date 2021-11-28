using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdultsServer.Models;
using AdultsServer.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AdultsServer.Data
{
    public class SqliteAdultService : IAdultsService
    {
        private AdultContext adultContext;

        public SqliteAdultService(AdultContext adultContext)
        {
            this.adultContext = adultContext;
        }
        
        public async Task<Adult> AddAdultsAsync(Adult adult)
        {
            EntityEntry<Person> newAdult = await adultContext.Persons.AddAsync(adult);
            await adultContext.SaveChangesAsync();
            return (Adult)newAdult.Entity;
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            return await adultContext.Adults.Include(a => a.Job).ToListAsync();
        }

        public async Task RemoveAdultAsync(int AdultId)
        {
            Adult toDelete = await adultContext.Adults.
                Include(adult => adult.Job).
                FirstOrDefaultAsync(a => a.Id == AdultId);
            Job j = toDelete.Job;
            if (toDelete != null)
            {
                adultContext.Adults.Remove(toDelete);
                adultContext.Jobs.Remove(j);
                await adultContext.SaveChangesAsync();
            }
        }

        public async Task<User> AddUser(User user)
        {
            User existing = await adultContext.Users.FirstOrDefaultAsync(u =>
                u.UserName.Equals(user.UserName));

            if (existing != null) throw new Exception("That username is already taken");

            await adultContext.Users.AddAsync(user);
            await adultContext.SaveChangesAsync();
            return user;
        }
        
        public async Task<User> ReadAsync(string username, string password) {
            User user = await adultContext.Users.FirstOrDefaultAsync(u =>
                u.UserName.Equals(username) && u.Password.Equals(password));

            if (user == null) throw new NullReferenceException("No such user found");

            return user;
        }
    }
}