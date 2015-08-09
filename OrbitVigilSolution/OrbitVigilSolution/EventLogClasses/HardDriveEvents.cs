using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitVigilSolution.EventLogClasses
{
    class HardDriveEvents
    {
    }

    [Serializable]
    public class HardDriveEventBadBlockException : Exception
    {
        public HardDriveEventBadBlockException() { }
        
        public HardDriveEventBadBlockException(string message) : base(message) { }

        public HardDriveEventBadBlockException(string message, Exception inner) : base(message, inner) { }
       
        protected HardDriveEventBadBlockException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
