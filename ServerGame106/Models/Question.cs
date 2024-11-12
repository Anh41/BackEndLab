using System.ComponentModel.DataAnnotations.Schema;

namespace ServerGame106.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string ContentQuestion { get; set; }
        public string Answer  {  get; set; }
        public string Option1 {  get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        [ForeignKey("Level")]
        public int LevelId { get; set; }
    }
}
