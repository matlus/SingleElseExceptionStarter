using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleElseExceptionStarter
{

    [Serializable]
    public class MoreThanOneMovieMatchedException : Exception
    {
        public MoreThanOneMovieMatchedException() { }
        public MoreThanOneMovieMatchedException(string message) : base(message) { }
        public MoreThanOneMovieMatchedException(string message, Exception inner) : base(message, inner) { }
        protected MoreThanOneMovieMatchedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
