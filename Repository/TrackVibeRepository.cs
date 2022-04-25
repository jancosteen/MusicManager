﻿using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TrackVibeRepository: RepositoryBase<TrackVibe>, ITrackVibeRepository
    {
        public TrackVibeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }
    }
}
