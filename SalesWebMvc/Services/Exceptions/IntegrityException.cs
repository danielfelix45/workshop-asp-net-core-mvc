using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : AccessViolationException
    {
        public IntegrityException(string message) : base(message)
        {

        }
    }
}
