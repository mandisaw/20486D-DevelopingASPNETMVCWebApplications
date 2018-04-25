﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAnnotationsExample.Models;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsExample.Validators
{
    public class InUniversityValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Student student = (Student)validationContext.ObjectInstance;
            if (!student.UniversityStudent)
            {
                return new ValidationResult("Sorry you should be a student in the university to submit");
            }
            return ValidationResult.Success;
        }
    }
}