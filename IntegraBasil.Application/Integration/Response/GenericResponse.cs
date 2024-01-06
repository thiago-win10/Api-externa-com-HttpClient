using System.Dynamic;
using System.Net;

namespace IntegraBasil.Application.Integration.Response
{
    public class GenericResponse<T> where T : class
    {
        public HttpStatusCode CodeHttp { get; set; }
        public T? DatasReturn { get; set; }
        public ExpandoObject? ErrorReturn { get; set; }

    }
}
