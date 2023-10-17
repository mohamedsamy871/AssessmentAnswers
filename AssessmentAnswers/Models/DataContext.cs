using Microsoft.EntityFrameworkCore;

namespace AssessmentAnswers.Models
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
            
        }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentEnrol> AssessmentEnrols { get; set; }
        public DbSet<AssessmentQuestion> AssessmentQuestions { get; set; }
        public DbSet<AssessmentQuestionRelation> AssessmentQuestionRelations { get; set; }
        public DbSet<AssessmentMatch> AssessmentMatch { get; set; }
        public DbSet<AssessmentOption> AssessmentOptions { get; set; }
        public DbSet<AssessmentText> AssessmentText { get; set; }
        public DbSet<AssessmentTrueFalse> AssessmentTrueFalse { get; set; }
        public DbSet<AssessmentAnswer> AssessmentAnswers { get; set; }


    }
}
