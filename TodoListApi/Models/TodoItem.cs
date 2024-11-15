namespace TodoListApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string? Name { get; set; } // el signo ? es para decirle que acepte nulos null
        public Boolean? IsComplete { get; set; }
    }
}
