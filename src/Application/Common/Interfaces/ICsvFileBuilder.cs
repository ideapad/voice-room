using voice_room.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace voice_room.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
