﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Checkmarx.Soccer.API.ViewModels;

namespace Checkmarx.Soccer.API.Interfaces
{
    public interface ICompetitionViewModelService
    {
        Task<IEnumerable<CompetitionAreaViewModel>> GetCompetitions();
        Task<CompetitionWithStandingsViewModel> GetCompetitionWithStandings(int competitionId);
    }
}
