using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Bases
{
    public class Response<T>
    {
        public Response()
        {

        }

        public Response(T response, string message = null)
        {
            Data= response;
            Message= message;
            Succeeded= true;
        }

        public Response(string message) { 
            Message= message;
            Succeeded= false;
        }

        public Response(string message, bool succeeded)
        {
            Message= message;
            Succeeded= succeeded;
        }

        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public bool Succeeded { get; set; }
        public T Data { get; set; }
        public object Meta { get; set; }
    }
}
