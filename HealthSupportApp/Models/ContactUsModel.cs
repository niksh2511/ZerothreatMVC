﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthSupportApp.Models
{
    public class ContactUsModel
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}