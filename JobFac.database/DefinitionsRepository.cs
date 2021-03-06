﻿using JobFac.lib.DataModels;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

// TODO insert/update/delete jobs, sequences, steps, and query jobs/sequences by category

namespace JobFac.database
{
    public class DefinitionsRepository : DapperRepositoryBase
    {
        public DefinitionsRepository(IConfiguration config)
            : base(config)
        { }

        public async Task<JobDefinition> GetJobDefinition(string id)
            => await QueryOneAsync<JobDefinition>(ConstQueries.SelectJobDefinition, new { Id = id });

        public async Task<SequenceDefinition> GetSequenceDefinition(string id)
            => await QueryOneAsync<SequenceDefinition>(ConstQueries.SelectSequenceDefinition, new { Id = id });

        public async Task<IReadOnlyList<StepDefinition>> GetStepsForSequence(string id)
            => await QueryAsync<StepDefinition>(ConstQueries.SelectSequenceSteps, new { Id = id });

    }
}
