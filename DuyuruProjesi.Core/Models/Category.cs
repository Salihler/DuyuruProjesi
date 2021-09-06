using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DuyuruProjesi.Core.Models
{
    public class Category
    {
        public Category()
        {
            Questions = new Collection<Question>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Question> Questions { get; set; } 
    }
}