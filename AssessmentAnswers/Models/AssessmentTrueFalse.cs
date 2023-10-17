﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AssessmentAnswers.Models
{
    public class AssessmentTrueFalse
    {
        public int Id { get; set; }
        public string Question { get; set; }

        [ForeignKey("AssessmentQuestion")]
        public int AssessmentQuestionId { get; set; }
    }
}
