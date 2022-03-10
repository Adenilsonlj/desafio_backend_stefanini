namespace Example.Domain.ExampleAggregate
{
    public sealed class Example
    {
        private Example(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

       

        public static Example Create(string name, int age)
        {
            if (name == null) 
                throw new ArgumentException("Invalid " + nameof(name));

            if (age == 0)
                throw new ArgumentException("Invalid " + nameof(age));


            return new Example(name, age);
        }

        public void Update(string name, int age)
        {
            if (name != null) 
                Name = name;

            if (age > 50)
                throw new InvalidAgeExceptions();

            if (age != 0)
                Age = age;
        }
    }
}
