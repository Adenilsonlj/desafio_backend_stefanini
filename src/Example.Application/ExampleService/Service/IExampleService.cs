using Example.Application.ExampleService.Models.Request;
using Example.Application.ExampleService.Models.Response;
using System.Threading.Tasks;

namespace Example.Application.ExampleService.Service
{
    public interface IExampleService
    {
        Task<GetAllExampleResponse> GetAllAsync();
        Task<GetByIdExampleResponse> GetByIdAsync(int id);
        Task<CreateExampleResponse> CreateAsync(CreateExampleRequest request);
        Task<UpdateExampleResponse> UpdateAsync(int id, UpdateExampleRequest request);
        Task<DeleteExampleResponse> DeleteAsync(int id);
    }
}
