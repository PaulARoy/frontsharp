﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontSharp.Models
{
    public class Comment : BaseResponseBody
    {
        public string id { get; set; }
        public Author author { get; set; }
        public string body { get; set; }
        public float posted_at { get; set; }
    }
}
