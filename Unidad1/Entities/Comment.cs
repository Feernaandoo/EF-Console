using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1
{
    class Comment
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string CommentContent { get; set; }
        public User User { get; set; }
    }
}
