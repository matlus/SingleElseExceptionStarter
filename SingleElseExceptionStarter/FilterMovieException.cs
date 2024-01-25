using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleElseExceptionStarter
{


    [Serializable]
    public sealed class FilterMovieException : Exception
    {
        public FilterMovieException() { }
        public FilterMovieException(string message) : base(message) { }
        public FilterMovieException(string message, Exception inner) : base(message, inner) { }
        private FilterMovieException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
