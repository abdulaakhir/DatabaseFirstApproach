using System;
using System.Collections.Generic;

namespace Abdul43.Models;

public partial class Employe
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int Salary { get; set; }
}
