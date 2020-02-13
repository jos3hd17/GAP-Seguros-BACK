using System;
using policy_back.Interfaces;
namespace policy_back.Models

{
    public class Policy: Entity, IPolicy
    {
        public string Name { get; set; }
        public string Description { get ; set; }
        public Coverage Coverage { get; set; }
        public DateTime StartUp { get; set; }
        public DateTime StartUpCoverage { get; set; }
        public int Price { get; set; }
        public Customer Customer { get; set; }

        public Policy()
        {
            
        }

       
    }
}
