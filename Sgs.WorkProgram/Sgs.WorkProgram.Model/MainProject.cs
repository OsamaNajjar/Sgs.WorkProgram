using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sameer.Shared;

namespace Sgs.WorkProgram.Model
{
    public class MainProject : ISameerObject,IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name Required !")]
        [Unique(ErrorMessage ="Name Duplicate !")]
        [StringLength(200,MinimumLength =10,ErrorMessage ="Unvalid name !")]
        public string Name { get; set; }

        public DateTime StartDate { get; set; }
         
        public DateTime EndDate { get; set; }

        public int SgsProgramId { get; set; }

        public SgsProgram SgsProgram { get; set; }
         
        public string DepartmentCode { get; set; }

        public string DepartmentName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var resultes = new List<ValidationResult>();

            if(EndDate <= StartDate)
            {
                resultes.Add(new ValidationResult("End date can't before start date !",new string[] { nameof(EndDate) ,nameof(StartDate)}));
            }

            return resultes;
        }
    }
}
