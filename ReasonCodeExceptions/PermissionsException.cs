using System;
namespace ReasonCodeExceptions
{
    public class PermissionsException : AuthenticationException
    {
        private const string reasonCode = "P";

        public PermissionsException(string message) : base(reasonCode, message)
        {
        }

        public PermissionsException(string message, Exception innerException) : base(reasonCode, message, innerException)
        {
        }
    }
}
