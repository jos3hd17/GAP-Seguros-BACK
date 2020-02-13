using System;
namespace policy_back.Interfaces
{
    public interface ICoverage
    {
       int MinRisk { get; set; }
       int CoveragePercent { get; set; }
       string CoverageName { get; set; }
    }
}
