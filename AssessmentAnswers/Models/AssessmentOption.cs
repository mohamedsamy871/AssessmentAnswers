using System.ComponentModel.DataAnnotations.Schema;

namespace AssessmentAnswers.Models
{
    public class AssessmentOption
    {
        public int Id { get; set; }
        public string Question { get; set; }

        [ForeignKey("AssessmentQuestion")]
        public int QuestionId { get; set; }

    }

}
