namespace AssessmentAnswers.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Score { get; set; }
        public ICollection<AssessmentEnrol> AssessmentEnrols { get; set; }
    }
}
