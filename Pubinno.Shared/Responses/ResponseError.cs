using System;

namespace Pubinno.Shared.Responses
{
    public class ResponseError : Exception
    {
        public string Messages { get; set; }
        public int StatusCode { get; set; }
    }
}
