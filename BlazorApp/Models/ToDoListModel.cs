namespace BlazorApp.Models
{
    public class ToDoListModel
    {
        public string? TaskName { get; set; }
        public string? Memo { get; set; }
        public byte Priority {  get; set; }
        public DateTime Term {  get; set; } 
    }
}
