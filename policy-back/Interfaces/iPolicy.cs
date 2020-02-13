using System;


namespace policy_back.Interfaces
{
    public interface IPolicy
    {
        string Name { get; set; }
        string Description { get; set; }
        Models.Coverage Coverage { get; set; }
        DateTime StartUp { get; set; }
        DateTime StartUpCoverage { get; set; }
        int Price { get; set; }
        Models.Customer Customer { get; set; }
    }
}
