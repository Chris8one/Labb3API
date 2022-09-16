using Labb3API.Models;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3API.Services
{
    public class HelionRepository : IHelion
    {
        private AppDbContext _appDbContext;

        public HelionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public PersonInterest personInterest(PersonInterest newPersonInterest)
        {
            _appDbContext.PersonInterests.Add(newPersonInterest);
            _appDbContext.SaveChanges();

            return newPersonInterest;
        }

        public Interest AddInterest(Interest newInterest)
        {
            _appDbContext.Interests.Add(newInterest);
            _appDbContext.SaveChanges();

            return newInterest;
        }

        public Link AddLink(Link newLink)
        {
            _appDbContext.Links.Add(newLink);
            _appDbContext.SaveChanges();

            return newLink;
        }

        public Person AddPerson(Person newPerson)
        {
            _appDbContext.Persons.Add(newPerson);
            _appDbContext.SaveChanges();

            return newPerson;
        }

        public Interest GetInterest(int id)
        {
            return _appDbContext.Interests.FirstOrDefault(i => i.InterestId == id);
        }

        public async Task<Person> GetInterests(int id)
        {
            return await _appDbContext.Persons.Include(pi => pi.PersonInterests).ThenInclude(i => i.Interest).FirstOrDefaultAsync(p => p.PersonId == id);
        }

        public async Task<Person> GetLinks(int id) => await _appDbContext.Persons.Include(l => l.Links).FirstOrDefaultAsync(p => p.PersonId == id);

        public Person GetPerson(int id) => _appDbContext.Persons.FirstOrDefault(p => p.PersonId == id);

        public IEnumerable<Person> GetPersons() => _appDbContext.Persons;

        public IEnumerable<Person> Search(string name)
        {
            IQueryable<Person> querySearch = _appDbContext.Persons;

            if (!string.IsNullOrEmpty(name))
            {
                querySearch = querySearch.Where(p => p.FirstName.Contains(name) || p.LastName.Contains(name));
            }

            return querySearch.ToList();
        }
    }
}
