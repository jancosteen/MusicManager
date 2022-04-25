using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VibeRepository: RepositoryBase<Vibe>, IVibeRepository
    {
        public VibeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }
    }
}
