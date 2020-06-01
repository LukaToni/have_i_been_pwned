using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Functions
{
    public interface IOrleansFunctionProvider
    {
        IList<IOrleansFunction> GetOrleansFunctions();
    }
}
