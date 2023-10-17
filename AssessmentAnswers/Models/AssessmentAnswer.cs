using System.ComponentModel.DataAnnotations.Schema;

namespace AssessmentAnswers.Models
{
    public class AssessmentAnswer
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public int Score { get; set; }
        [ForeignKey("AssessmentQuestion")]
        public int QuestionId { get; set; }
    }
}
