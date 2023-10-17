namespace AssessmentAnswers.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AssessmentEnrol> AssessmentEnrols { get; set; }
        public ICollection<AssessmentQuestionRelation> AssessmentQuestionRelation { get; set; }
        
    }
}
