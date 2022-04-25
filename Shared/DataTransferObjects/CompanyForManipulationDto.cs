﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public abstract record CompanyForManipulationDto
    {
        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the name property is 60 characters.")]
        public string? Name { get; init; }
        [Required(ErrorMessage = "Company address is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the address property is 60 characters.")]
        public string? Address { get; init; }
        public string? Country { get; init; }
        public IEnumerable<EmployeeForCreationDto>? Employees { get; init; }
    }
}
