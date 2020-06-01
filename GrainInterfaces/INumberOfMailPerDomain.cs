using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrainInterfaces
{
    public interface INumberOfMailPerDomain : IGrainWithGuidKey
    {
        Task<string> GetNumberOfMailPerDomain(string domain);
    }
}
