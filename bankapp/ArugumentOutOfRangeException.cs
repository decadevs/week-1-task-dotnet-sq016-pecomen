using System.Runtime.Serialization;

namespace bankapp
{
    [Serializable]
    internal class ArugumentOutOfRangeException : Exception
    {
        private string v1;
        private string v2;

        public ArugumentOutOfRangeException()
        {
        }

        public ArugumentOutOfRangeException(string? message) : base(message)
        {
        }

        public ArugumentOutOfRangeException(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public ArugumentOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ArugumentOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}