using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Columns
{
    public int ColumnId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Articles> Articles { get; } = new List<Articles>();
}
