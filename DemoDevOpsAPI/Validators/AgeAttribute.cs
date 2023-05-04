using System.ComponentModel.DataAnnotations;

namespace DemoDevOpsAPI.Validators
{
    public class AgeAttribute : ValidationAttribute
    {

        public int Age { get; set; }

        public AgeAttribute(int age)
        {
            Age = age;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime ValidBirthdate = DateTime.Now.AddYears(-Age);

            if ((DateTime)value > ValidBirthdate)
            {
                return new ValidationResult(ErrorMessage ?? "T'as pas l'age");
            }

            return ValidationResult.Success;


        }
    }
}
