using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Lab.DiMw.Services
{
    public interface ICounterService
    {
        void Increment();

        int GetValue();
    }
}
