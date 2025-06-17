using System.ComponentModel.DataAnnotations;

namespace PAW.Mvc.Helper.Attributes;

    public class ValidateId : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {

        var id = (decimal)value;

        if (id > 0 || id > int.MaxValue)
            return new ValidationResult("El id es invalido");


        return ValidationResult.Success!;
    }
}
