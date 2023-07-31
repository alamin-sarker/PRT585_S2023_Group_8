using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectDbExample.models;

public class Team: BaseEntity
{
    public string Name { get; set; } = "";
    public int Year { get; set; } = 2023;
}