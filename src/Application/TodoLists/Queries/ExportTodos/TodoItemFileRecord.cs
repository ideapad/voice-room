using voice_room.Application.Common.Mappings;
using voice_room.Domain.Entities;

namespace voice_room.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
