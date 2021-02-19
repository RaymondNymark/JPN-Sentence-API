using JPN_SentenceAPI.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JPN_SentenceAPI.Core.Services
{
    public interface IRetrieveSentence
    {
        List<Sentence> RetrieveSentencesBySearchTerm(string searchTerm);
        Task<Sentence> RetrieveSentencesBySearchTermAsync(string searchTerm);
    }
}