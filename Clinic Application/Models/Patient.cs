using System.ComponentModel.DataAnnotations;

namespace Clinic_Application.Models
{
    public class Patient

    {
        [Required]
        [Range(5,30, ErrorMessage =" your first name is either too long or too short")]
        public string? Firstname { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required(ErrorMessage ="Your Age is required")]
        [Range(18,90,ErrorMessage ="Your age should be between 18 and 90")]
        public int? Age { get; set; }
        public DateOnly? DateofBirth { get; set; }
        public Guid? PatientId { get; set; }

        [EmailAddress(ErrorMessage ="Enter a valid email Adress")]
        public string? EmailAddress { get; set; }

        public override string ToString()
        {
            return "$ The patient name is: {FirstName} {lastName}. The Patients is {Age} old. The Date of birth is {DateofBirth} and the patient id is {patientId}.";
        }




    }
    } 

