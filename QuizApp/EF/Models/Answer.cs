using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizApp.EF.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int QuesNumber { get; set; }
        [Required]
        public int Correct { get; set; }

       // public virtual Question Question { get; set; }
    }
}