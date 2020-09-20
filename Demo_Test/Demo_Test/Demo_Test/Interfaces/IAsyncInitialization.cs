using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test.Interfaces
{
    public interface IAsyncInitialization
    {
        Task Initialization { get; }
    }
}
