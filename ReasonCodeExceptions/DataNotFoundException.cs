using System;
namespace ReasonCodeExceptions
{
    public class DataNotFoundException : DataException
    {
        private const string reasonCode = "NF";

        public DataNotFoundException(string message) : base(reasonCode, message)
        {
        }

        public DataNotFoundException(string message, Exception innerException) : base(reasonCode, message, innerException)
        {
        }
    }
}
