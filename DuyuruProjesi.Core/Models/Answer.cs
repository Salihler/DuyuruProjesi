namespace DuyuruProjesi.Core.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int QuestionId { get; set; }
        public int CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Question Questions { get; set; }
    }
}