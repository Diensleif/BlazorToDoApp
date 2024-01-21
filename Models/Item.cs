using System;
using System.Collections.Generic;

namespace ToDoApp.Models;

public partial class Item
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? IsCompleted { get; set; }
}
