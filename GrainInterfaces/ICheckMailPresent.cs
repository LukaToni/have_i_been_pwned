using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrainInterfaces
{
    public interface ICheckMailPresent: IGrainWithGuidKey
    {
        Task<string> CheckMail(string text);
    }
}
