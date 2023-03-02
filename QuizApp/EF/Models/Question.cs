using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizApp.EF.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ques { get; set; }

        [Required]

        public string Option1 { get; set; }
        [Required]
        public string Option2 { get; set; }
        [Required]
        public string Option3 { get; set; }
        [Required]
        public string Option4 { get; set; }
        [Required]
        public int RightQues { get; set; }

      //  public virtual ICollection<Answer> Answers { get; set; }
       // public Question()
      ////  {
      //      Answers = new List<Answer>();
       // }
    }
}