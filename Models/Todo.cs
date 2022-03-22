using System.ComponentModel.DataAnnotations;

namespace DotnetTodoApi.Models;

public class Todo
{
    public Todo()
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Body { get; set; } = string.Empty();
    }
}
