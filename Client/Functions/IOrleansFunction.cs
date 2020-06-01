using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Client.Functions
{
    public interface IOrleansFunction
    {
        string Description { get; }
        Task PerformFunction(IClusterClient clusterClient);
    }
}
