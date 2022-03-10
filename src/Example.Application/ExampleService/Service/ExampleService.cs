using Example.Application.Common;
using Example.Application.ExampleService.Models.Dtos;
using Example.Application.ExampleService.Models.Request;
using Example.Application.ExampleService.Models.Response;
using Example.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Example.Application.ExampleService.Service
{
    public class ExampleService : BaseService<ExampleService>, IExampleService
    {
        private readonly ExampleContext _db;

        public ExampleService(ILogger<ExampleService> logger, Infra.Data.ExampleContext db) : base(logger)
        {
            _db = db;
        }

        public async Task<GetAllExampleResponse> GetAllAsync()
        {
            var entity = await _db.Example.ToListAsync();
            return new GetAllExampleResponse()
            {
                Examples = entity != null ? entity.Select(a => (ExampleDto)a).ToList() : new List<ExampleDto>()
            };
        }

        public async Task<GetByIdExampleResponse> GetByIdAsync(int id)
        {

            var response = new GetByIdExampleResponse();

            var entity = await _db.Example.FirstOrDefaultAsync(item => item.Id == id);

            if (entity != null) response.Example = (ExampleDto)entity;

            return response;
        }

        public async Task<CreateExampleResponse> CreateAsync(CreateExampleRequest request)
        {
            if (request == null)
                throw new ArgumentException("Request empty!");

            var newExample = Domain.ExampleAggregate.Example.Create(request.Name, request.Age);

            _db.Example.Add(newExample);

            await _db.SaveChangesAsync();

            return new CreateExampleResponse() { Id = newExample.Id };
        }

        public async Task<UpdateExampleResponse> UpdateAsync(int id, UpdateExampleRequest request)
        {
            if (request == null)
                throw new ArgumentException("Request empty!");

            var entity = await _db.Example.FirstOrDefaultAsync(item => item.Id == id);

            if (entity != null)
            {
                entity.Update(request.Name, request.Age);
                await _db.SaveChangesAsync();
            }

            return new UpdateExampleResponse();
        }

        public async Task<DeleteExampleResponse> DeleteAsync(int id)
        {

            var entity = await _db.Example.FirstOrDefaultAsync(item => item.Id == id);

            if (entity != null)
            {
                _db.Remove(entity);
                await _db.SaveChangesAsync();
            }

            return new DeleteExampleResponse();
        }
    }
}
