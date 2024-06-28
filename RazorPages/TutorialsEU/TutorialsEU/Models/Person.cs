namespace TutorialsEU.Models
{
    public class Person
    {
        public int Id { get; set; } //It's always a good idea to have a unique id for your entities - primary key
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
