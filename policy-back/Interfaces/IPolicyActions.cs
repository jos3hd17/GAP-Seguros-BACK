using System;
using System.Collections.Generic;
using policy_back.Models;

namespace policy_back.Interfaces
{
    public interface IPolicyActions
    {
        List<Policy> GetAllPolicy();
        void AddPolicy(Policy policy);
    }

   
}
