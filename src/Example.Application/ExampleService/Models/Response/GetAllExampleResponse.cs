using System.Collections.Generic;
using Example.Application.Common;
using Example.Application.ExampleService.Models.Dtos;

namespace Example.Application.ExampleService.Models.Response
{
    public class GetAllExampleResponse: BaseResponse
    {
        public List<ExampleDto> Examples { get; set; }
    }
}
