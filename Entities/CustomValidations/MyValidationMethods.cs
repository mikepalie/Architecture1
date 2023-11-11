using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CustomValidations
{
    public class MyValidationMethods
    {
        public static ValidationResult Validate0_150(int value,ValidationContext context)
        {
            bool isValid = true;

            if(value>150 || value < 0)
            {
                isValid = false;
            }

            if (isValid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"The field {context.MemberName} must be [0-150]", new List<string> { context.MemberName });
            }


        }
    }
}
