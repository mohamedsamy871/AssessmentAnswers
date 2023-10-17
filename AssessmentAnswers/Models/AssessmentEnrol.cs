using System.ComponentModel.DataAnnotations.Schema;

namespace AssessmentAnswers.Models
{
    public class AssessmentEnrol
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Assessment")]
        public int AssessmentId { get; set; }
    }
}
