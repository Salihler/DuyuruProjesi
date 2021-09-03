using System.Collections.Generic;

namespace DuyuruProjesi.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Question> Questions { get; set; } 
    }
}