namespace AssessmentAnswers.Models
{
    public class AssessmentQuestion
    {
        public int Id { get; set; }
        public AssessmentQuestionType QuestionType { get; set; }
        public ICollection<AssessmentMatch> AssessmentMatch { get; set; }
        public ICollection<AssessmentOption> AssessmentOptions { get; set; }
        public ICollection<AssessmentText> AssessmentText { get; set; }
        public ICollection<AssessmentTrueFalse> AssessmentTrueFalse { get; set; }
        public ICollection<AssessmentAnswer> AssessmentAnswers { get; set; }
    }
    public enum AssessmentQuestionType 
    {
        Match,
        FillInBlanks,
        OptionsMulitpleSelect,
        OptionsMultipleChoise,
        TextLongAnswer,
        TextShortAnswer,
        TrueFalse
    }
}
