using ConferenceManager.Entities.Models;

namespace ConferenceManager.Repositories
{
    public interface IStatisticsRepo
    {
        StatisticsModel GetStatistics();
    }
}