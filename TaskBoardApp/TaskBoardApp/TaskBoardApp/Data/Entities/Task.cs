namespace TaskBoardApp.Data.Entities
{
    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedOn { get; set; }

        public int BoardId { get; set;}

        public Board Board { get; set; } = null!;
    }
}
