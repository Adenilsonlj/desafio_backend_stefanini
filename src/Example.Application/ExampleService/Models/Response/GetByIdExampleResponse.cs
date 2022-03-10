using Example.Application.Common;
using Example.Application.ExampleService.Models.Dtos;

namespace Example.Application.ExampleService.Models.Response
{
    public class GetByIdExampleResponse : BaseResponse
    {
        public ExampleDto Example { get; set; }
    }
}
