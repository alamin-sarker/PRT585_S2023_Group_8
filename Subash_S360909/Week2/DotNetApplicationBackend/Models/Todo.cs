namespace DotNetApplicationBackend.API.Models
{
    public class Todo{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Activity { get; set; }
        public string Date {get; set; }
        public long Days { get; set; }
    }
}