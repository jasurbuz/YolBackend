﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yol.Services.DTOs.ApplicationDtos
{
    public class ApplicationDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string RoadName { get; set; }
        public string ApplicationText { get; set; }
        public string AdditionalFile { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
