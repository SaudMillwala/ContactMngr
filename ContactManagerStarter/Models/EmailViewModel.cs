﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using ContactManager.Data;

namespace ContactManager.Models
{
    public class EmailViewModel
    {
        public EmailType Type { get; set; }
        public string Email { get; set; }

        public EmailPriority Priority { get; set; }
    }
}
