using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Responses
{
    public class Response<TData>
    {
        private int _code = Configuration.DefaultStatusCode;

        [JsonConstructor] //informa q esse é o construtor padrão..
        public Response() => _code = Configuration.DefaultStatusCode;


        public Response(TData? data, int code = Configuration.DefaultStatusCode, string? message = null) 
        {
            Data = data;
            _code = code;
            Message = message;
        }
        

        public TData? Data { get; set; }  //para receber um tipo especifico, nesse caso pode ser uma categoria ou transação
        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code == 200;



    }
}
