using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public interface IPost
    {
        DateTime CreatedOn { get; set; }
        Guid Id { get; set; }
        string Content { get; set; }
        string Title { get; set; }
        DateTime UpdatedOn { get; set; }
    }

    public class Post : IPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
