using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Exceptions
{
    public class EventException : ApplicationException
    {
        public string Message { get; set; }
        public EventException(string message)
        {
            Message = message;
        }
    }
}
