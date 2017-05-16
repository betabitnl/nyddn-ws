using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Lab.DiMw.Services
{
    public class CounterService : ICounterService
    {
        private int _currentValue = 1;

        public int GetValue() => _currentValue;

        public void Increment()
        {
            _currentValue++;
        }
    }
}
