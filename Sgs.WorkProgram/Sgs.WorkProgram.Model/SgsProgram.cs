using Sameer.Shared;
using System.ComponentModel.DataAnnotations;

namespace Sgs.WorkProgram.Model
{
    public class SgsProgram : ISameerObject
    {
        public int Id { get; set; }

        [Required]
        [Unique]
        [StringLength(100,MinimumLength = 10)]
        public string Name { get; set; }
    }
}
