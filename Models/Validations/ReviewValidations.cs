using System;
using System.ComponentModel.DataAnnotations;
using RESTaurant.Models;

namespace RESTaurant.Models.Validations
{
    public class ValidateDate: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date = (DateTime)value;
            if(date <= DateTime.UtcNow)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Date of visit cannot be greater than current date");
        }
    }
}