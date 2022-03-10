using Example.Domain.ExampleAggregate;

namespace Example.Application.ExampleService.Models.Dtos
{
    public class ExampleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static explicit operator ExampleDto(Domain.ExampleAggregate.Example v)
        {
            return new ExampleDto()
            {
                Id = v.Id,
                Name = v.Name,
                Age = v.Age
            };
        }
    }
}
