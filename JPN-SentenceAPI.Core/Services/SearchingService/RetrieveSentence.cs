using JPN_SentenceAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JPN_SentenceAPI.Core.Services
{
    public class RetrieveSentence : IRetrieveSentence
    {
        public List<Sentence> RetrieveSentencesBySearchTerm(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public async Task<Sentence> RetrieveSentencesBySearchTermAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
