using AssessmentAnswers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Linq;

namespace AssessmentAnswers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentController : ControllerBase
    {
        private readonly DataContext _db;

        public AssessmentController(DataContext db)
        {
            _db = db;
        }
        [HttpGet("GetAssessmentQuestionsWithAnswers/{userId}/{questionType}")]
        public async Task<IActionResult> GetAssessmentQuestionsWithAnswers(int userId, AssessmentQuestionType questionType)
        {
            try
            {
                IEnumerable<AssessmentQuestion> assessmentQuestions;
                var assessmentIds = await _db.AssessmentEnrols.Where(m=>m.UserId == userId).Select(m=>m.AssessmentId).ToListAsync();
                var assessments = await _db.Assessments.Where(m=> assessmentIds.Contains(m.Id)).Include(m=>m.AssessmentQuestionRelation).ToListAsync();
                var AssessmentQuestionsIds = assessments.SelectMany(m=>m.AssessmentQuestionRelation).Select(m=>m.AssessmentQuestionId).ToList();
                switch (questionType)
                {
                    case AssessmentQuestionType.Match | AssessmentQuestionType.FillInBlanks:
                        assessmentQuestions = await _db.AssessmentQuestions.Where(m => AssessmentQuestionsIds.Contains(m.Id) && m.QuestionType == questionType).Include(m => m.AssessmentMatch).Include(m => m.AssessmentAnswers).ToListAsync();
                        break;
                    case AssessmentQuestionType.OptionsMulitpleSelect | AssessmentQuestionType.OptionsMultipleChoise:
                        assessmentQuestions = await _db.AssessmentQuestions.Where(m => AssessmentQuestionsIds.Contains(m.Id) && m.QuestionType == questionType).Include(m => m.AssessmentOptions).Include(m => m.AssessmentAnswers).ToListAsync();
                        break;
                    case AssessmentQuestionType.TextLongAnswer | AssessmentQuestionType.TextShortAnswer:
                        assessmentQuestions = await _db.AssessmentQuestions.Where(m => AssessmentQuestionsIds.Contains(m.Id) && m.QuestionType == questionType).Include(m => m.AssessmentText).Include(m => m.AssessmentAnswers).ToListAsync();
                        break;
                    case AssessmentQuestionType.TrueFalse:
                        assessmentQuestions = await _db.AssessmentQuestions.Where(m => AssessmentQuestionsIds.Contains(m.Id) && m.QuestionType == questionType).Include(m => m.AssessmentTrueFalse).Include(m => m.AssessmentAnswers).ToListAsync();
                        break;
                    default:
                        assessmentQuestions = await _db.AssessmentQuestions.Where(m => AssessmentQuestionsIds.Contains(m.Id) && m.QuestionType == questionType)
                            .Include(m => m.AssessmentAnswers).Include(m => m.AssessmentMatch).Include(m => m.AssessmentOptions).Include(m => m.AssessmentText).Include(m => m.AssessmentTrueFalse).ToListAsync();
                        break;
                }
                return Ok(assessmentQuestions); 
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }
    }
}
