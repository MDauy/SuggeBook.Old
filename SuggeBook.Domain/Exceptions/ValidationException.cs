using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuggeBook.Domain.Exceptions
{
    public class ValidationException: Exception
    {
        public ValidationException(string message) : base(message) { }      
    }

    public class ValidationException<T> : ValidationException
    {
        public ValidationException() : base($"{typeof(T).Name} is not valid")
        {

        }
    }
}
