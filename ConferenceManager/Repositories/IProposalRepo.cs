using ConferenceManager.Entities.Models;
using System.Collections.Generic;

namespace ConferenceManager.Repositories
{
    public interface IProposalRepo
    {
        ProposalModel Add(ProposalModel model);
        ProposalModel Approve(int proposalId);
        IEnumerable<ProposalModel> GetAllForConference(int conferenceId);
        ProposalModel GetById(int id);
    }
}