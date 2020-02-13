using System;
using System.Collections.Generic;
using policy_back.Models;

namespace policy_back.Interfaces
{
    public interface ICoverageActions
    {
        List<Coverage> GetAllCoverage();
        void AddCoverage(Coverage coverage);
    }

    
}
