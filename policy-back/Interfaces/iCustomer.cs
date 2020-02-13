using System;
namespace policy_back.Interfaces
{
    public interface ICustomer
    {
        string ClientName { get; set; }
        string City { get; set; }
        int RiskPercent { get; set; }
    }
}
