using System.ComponentModel.DataAnnotations.Schema;

namespace AssessmentAnswers.Models
{
    public class AssessmentTrueFalse
    {
        public int Id { get; set; }

        [ForeignKey("AssessmentQuestion")]
        public string Question { get; set; }
    }
}
