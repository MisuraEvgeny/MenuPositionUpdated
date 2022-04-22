﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPosition
{
  public  interface IDoctorRepository
    {
        Doctor[] GetAllByName(string namePart);
    }
}