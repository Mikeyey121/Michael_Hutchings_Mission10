﻿using System;
using System.Collections.Generic;

namespace Michael_Hutchings_Mission10.Data;

public partial class ZtblWeek
{
    public DateOnly WeekStart { get; set; }

    public DateOnly? WeekEnd { get; set; }
}
