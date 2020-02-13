using System;
using policy_back.Interfaces;

namespace policy_back.Models
{
    public class Coverage: Entity, ICoverage
    {
        public int MinRisk { get; set ; }
        public int CoveragePercent { get ; set; }
        public string CoverageName { get; set ; }

        public Coverage()
        {
        }

      
    }
}
