﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provalist.Models
{
    internal class Log
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public DateTime timeOfEvent { get; set; }
    }
}
