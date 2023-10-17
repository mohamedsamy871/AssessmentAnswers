using System.ComponentModel.DataAnnotations.Schema;

namespace AssessmentAnswers.Models
{
    public class AssessmentQuestionRelation
    {
        public int Id { get; set; }

        [ForeignKey("Assessment")]
        public int AssessmentId { get; set; }

        [ForeignKey("AssessmentQuestion")]
        public int AssessmentQuestionId { get; set; }
        public AssessmentQuestion AssessmentQuestion { get; set; }
    }
}
