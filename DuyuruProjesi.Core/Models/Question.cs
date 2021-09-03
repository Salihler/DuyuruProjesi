using System.Collections.Generic;

namespace DuyuruProjesi.Core.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public virtual Category Category { get; set; }
    }
}