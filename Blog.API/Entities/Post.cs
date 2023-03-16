namespace Blog.API.Entities
{
    public class Post : BlogEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public Guid AutorId { get; set; }
    }
}
