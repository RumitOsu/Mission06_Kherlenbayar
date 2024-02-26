﻿using System;
using System.Collections.Generic;

namespace Mission07_Kherlenbayar.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
