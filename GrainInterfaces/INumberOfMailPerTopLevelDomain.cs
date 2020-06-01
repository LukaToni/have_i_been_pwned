using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrainInterfaces
{
    public interface INumberOfMailPerTopLevelDomain : IGrainWithGuidKey
    {
        Task<string> GetNumberOfMailPerTopLevelDomain(string topDomain);
    }
}
