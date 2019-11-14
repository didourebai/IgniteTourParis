using ConferenceManager.Entities.Models;
using System.Collections.Generic;

namespace ConferenceManager.Repositories
{
    public interface IConferenceRepo
    {
        ConferenceModel Add(ConferenceModel model);
        IEnumerable<ConferenceModel> GetAll();
        ConferenceModel GetById(int id);
    }
}