using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3API.Services
{
    public interface IHelion
    {
        IEnumerable<Person> GetPersons();
        Person GetPerson(int id);
        Interest GetInterest(int id);
        Task<Person> GetLinks(int id);
        Task<Person> GetInterests(int id);
        Person AddPerson(Person newPerson);
        Interest AddInterest(Interest newInterest);
        Link AddLink(Link newLink);
        IEnumerable<Person> Search(string name);
        PersonInterest personInterest(PersonInterest newPersonInterest);
    }
}
