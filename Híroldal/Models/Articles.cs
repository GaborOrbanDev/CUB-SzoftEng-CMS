using System;
using System.Collections.Generic;

namespace Híroldal.Models;

public partial class Articles
{
    public int ArticleId { get; set; }

    public int? ColumnId { get; set; }

    public string Title { get; set; } = null!;

    public string Text { get; set; } = null!;

    public virtual Columns? Column { get; set; }
}
