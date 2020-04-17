using System;
namespace ReasonCodeExceptions
{
    public class MiscDataException : DataException
    {
        private const string reasonCode = "MISC";

        public MiscDataException(string message) : base(reasonCode, message)
        {
        }

        public MiscDataException(string message, Exception innerException) : base(reasonCode, message, innerException)
        {
        }
    }
}
