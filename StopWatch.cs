using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_OOP
{
    public  class StopWatch
    {
        private DateTime _startTime { get; set; }
        
        public DateTime start()
        {
            if(_startTime!=DateTime.MinValue)            
                throw new InvalidOperationException("Stop watch is alreay running");
            _startTime = DateTime.Now;
            return _startTime;
        }
        public TimeSpan stop()
        {
            if (_startTime == DateTime.MinValue)
                throw new InvalidOperationException("Stop watch is not running");
            var timeSpan = DateTime.Now - _startTime;
            _startTime = DateTime.MinValue;
            return timeSpan;
        }
    }
}
