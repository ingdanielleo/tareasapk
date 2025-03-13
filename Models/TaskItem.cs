namespace TaskApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public bool Estado { get; set; } = false;
    }
}