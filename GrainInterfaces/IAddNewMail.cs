﻿using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrainInterfaces
{
    public interface IAddNewMail: IGrainWithGuidKey
    {
        Task<string> NewMail(string text);
    }
}
